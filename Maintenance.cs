using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MyTaxi
{
    public partial class Maintenance : UserControl
    {
        public string vehicle, type, date, from_date_temp , to_date_temp;
        public Maintenance()
        {
            InitializeComponent();
            Load_vehicle();
        }

        //Toload the lit of vehicles into the dropdown list
        public void Load_vehicle()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("vehicle_list_show", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                dropdown_vehicle_list_maintenance.Items.Clear();               
                while (reader.Read())
                {
                    string vehicle_nos = (string)reader["vehicle_no"];
                    dropdown_vehicle_list_maintenance.Items.Add(vehicle_nos);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //To check if the type of maintenance is tyre or not if it is tyre km textbox is set to visible
        private void type_tyre(object sender, EventArgs e)
        {
            if (Type_combobox.SelectedItem.ToString() == "Tyre")
            {
                KM_label.Visible = true;
                KM_text.Visible = true;
            }
            else
            {
                KM_label.Visible = false;
                KM_text.Visible = false;
            }
        }


        //To check if the text typedin the combobx is tyre or not
        private void type_text(object sender, EventArgs e)
        {
            if (Type_combobox.Text == "Tyre" || Type_combobox.Text == "tyre")
            {
                KM_label.Visible = true;
                KM_text.Visible = true;
            }
            else
            {
                KM_label.Visible = false;
                KM_text.Visible = false;
            }
        }
        //Submit button to upload the maintenance details to the database
        private void Submit_maintenance_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert_maintanance_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vehicle", SqlDbType.VarChar).Value = dropdown_vehicle_list_maintenance.Text.Trim();
                cmd.Parameters.AddWithValue("@type", SqlDbType.VarChar).Value = Type_combobox.Text.Trim();
                cmd.Parameters.AddWithValue("@cost", Convert.ToInt32(Cost_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@date_add", Convert.ToDateTime( date_pick.Text.Trim()));   
                if(KM_text.Visible==true)
                    cmd.Parameters.AddWithValue("@km", Convert.ToInt32 (KM_text.Text.Trim()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details uploaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                KM_text.Clear();
                Cost_text.Clear();
                Type_combobox.ResetText();
            }
        }

        private void Submit_maintenance_search_button_Click(object sender, EventArgs e)
        {

            from_date_temp = from_date.Text.Trim();
            to_date_temp = to_date.Text.Trim();
            expence_details_panel.Visible = false;

            Populatelist();
            
        }


        public void Populatelist()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("maintenance_search", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@from_date", Convert.ToDateTime(from_date_temp));
                cmd.Parameters.AddWithValue("@to_date", Convert.ToDateTime(to_date_temp));
                maintenance_search_listView.Clear();
                loadcoloum();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                maintenance_search_listView.View = View.Details;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow dr = data.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["vehicle"].ToString());
                    listitem.SubItems.Add(dr["type"].ToString());
                    listitem.SubItems.Add(dr["cost"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["date"]).ToString("d/MM/yyyy"));
                    listitem.SubItems.Add(dr["km"].ToString());


                    maintenance_search_listView.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            vehicle_text_expence.ReadOnly = false;
            cost_text_expence.ReadOnly = false;         
            date_expence.Enabled = true;
            type_text_expence.ReadOnly = false;

            vehicle_text_expence.BorderStyle = BorderStyle.Fixed3D;
            cost_text_expence.BorderStyle = BorderStyle.Fixed3D; 
            type_text_expence.BorderStyle = BorderStyle.Fixed3D;

            if (type_text_expence.Text == "Tyre" || type_text_expence.Text == "tyre")
            {
                km_text_expence.ReadOnly = false;
                km_text_expence.BorderStyle = BorderStyle.Fixed3D;
            }

            Cancel_button.Visible = true;
            Update_button.Visible = true;

            Edit_button.Visible = false;
            Delet_button.Visible = false;
        }
        public void readonlymode()
        {
            vehicle_text_expence.ReadOnly = true;
            cost_text_expence.ReadOnly = true;
            km_text_expence.ReadOnly = true;
            date_expence.Enabled = false;
            type_text_expence.ReadOnly = true;

            Cancel_button.Visible = false;
            Update_button.Visible = false;

            Edit_button.Visible = true;
            Delet_button.Visible = true;

            vehicle_text_expence.BorderStyle = BorderStyle.None;
            cost_text_expence.BorderStyle = BorderStyle.None;
            km_text_expence.BorderStyle = BorderStyle.None;
            type_text_expence.BorderStyle = BorderStyle.None;
        }

        private void Delet_button_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBoxResult m = System.Windows.MessageBox.Show("Do you really want to delete the maintenance list", "After deletion of the list it is not possible to get it back", System.Windows.MessageBoxButton.OKCancel);
            if(m==System.Windows.MessageBoxResult.OK)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete_maintenance", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@vehicle", vehicle);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(date));
                    cmd.ExecuteNonQuery();

                    Populatelist();
                    MessageBox.Show("Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    readonlymode();
                    conn.Close();
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            readonlymode();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("maintenance_update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vehicle",vehicle_text_expence.Text.Trim());
                cmd.Parameters.AddWithValue("@type", type_text_expence.Text.Trim());
                cmd.Parameters.AddWithValue("@date_new", Convert.ToDateTime(date_expence.Text.Trim()));
                cmd.Parameters.AddWithValue("@cost", Convert.ToInt32(cost_text_expence.Text.Trim()));
                cmd.Parameters.AddWithValue("@km", Convert.ToInt32(km_text_expence.Text.Trim()));

                cmd.Parameters.AddWithValue("@vehicle_old",vehicle);
                cmd.Parameters.AddWithValue("@type_old", type);
                cmd.Parameters.AddWithValue("@date_old", Convert.ToDateTime(date));
                cmd.ExecuteNonQuery();

                Populatelist();
                MessageBox.Show("Updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                readonlymode();
                conn.Close();
            }
        }
        public void loadcoloum()
        {
            maintenance_search_listView.Columns.Add("Vehicle");
            maintenance_search_listView.Columns.Add("Type");
            maintenance_search_listView.Columns.Add("Cost");
            maintenance_search_listView.Columns.Add("Date");
            maintenance_search_listView.Columns.Add("Km");

        }

        private void maintenance_search_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            expence_details_panel.Visible = true;
            if (maintenance_search_listView.SelectedItems.Count > 0)
            {
                vehicle_text_expence.Text = maintenance_search_listView.SelectedItems[0].SubItems[0].Text;
                type_text_expence.Text = maintenance_search_listView.SelectedItems[0].SubItems[1].Text;
                cost_text_expence.Text = maintenance_search_listView.SelectedItems[0].SubItems[2].Text;
                date_expence.Text = maintenance_search_listView.SelectedItems[0].SubItems[3].Text;
                km_text_expence.Text = maintenance_search_listView.SelectedItems[0].SubItems[4].Text;

                vehicle = maintenance_search_listView.SelectedItems[0].SubItems[0].Text;
                type = maintenance_search_listView.SelectedItems[0].SubItems[1].Text;
                date = maintenance_search_listView.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
