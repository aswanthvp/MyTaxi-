using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace MyTaxi
{
    public partial class vehicle : UserControl
    {

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        //string myconnstrng = ConfigurationManager.ConnectionStrings["Data Source=(local)\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True"].ConnectionString;
        string vehicle_temp = null;//to access the database to make the updation
        public vehicle()
        {
            InitializeComponent();
            Graphicload();
            Listbox_Display();

        }

        public void Graphicload()
        {
            int style = NativeWinAPI.GetWindowLong(tabPage2.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(tabPage2.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            int style1 = NativeWinAPI.GetWindowLong(tabPage1.Handle, NativeWinAPI.GWL_EXSTYLE);
            style1 |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(tabPage1.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        //to populate the listbox
        public void Listbox_Display()
        {
           
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("vehicle_list_show", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                listBox_vehicle.Items.Clear();
                while(reader.Read())
                {
                    string vehicle_nos = (string)reader["vehicle_no"];
                    listBox_vehicle.Items.Add(vehicle_nos);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }


        //submit button clicked adding vehicle
        private void Submit_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert_vehicle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vehicle_id", Vehicle_text.Text.Trim());
                cmd.Parameters.AddWithValue("@date",Convert.ToDateTime( date_pick.Text.Trim()));
                cmd.Parameters.AddWithValue("@cost",Convert.ToInt32( Cost_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@showroom_place",Place_text.Text.Trim());
                cmd.Parameters.AddWithValue("@showrrom_no", Convert.ToInt32( Number_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@showroom_mail",  Mail_text.Text.Trim());
                cmd.ExecuteNonQuery();

               
                //clearing the field after updating
                Vehicle_text.Clear();
                Cost_text.Clear();
                Place_text.Clear();
                Number_text.Clear();
                Mail_text.Clear();

                MessageBox.Show("Vehicle details updated");
                
                Listbox_Display();
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




        private void listBox_vehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            date_edit.Visible = true;
            Edit_button.Visible = true;
        
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                 SqlCommand cmd = new SqlCommand("vehicle_details_return", conn);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@vehicle", SqlDbType.VarChar).Value = listBox_vehicle.Text.Trim();
                SqlDataReader reader = cmd.ExecuteReader();
               
                while(reader.Read())
                {
                    string vehicle_dis = (string)reader["vehicle_no"];
                    decimal cost_dis = (decimal)reader["cost"];
                    string date_dis = Convert.ToDateTime(reader["Date"]).ToString("dd/MM/yyyy");
                    decimal showroomno_dis = (decimal)reader["showroom_no"];
                    string showroomplace_dis = (string)reader["showroom_place"];
                    string showroommail_dis = (string)reader["showroom_mail"];



                    //setting the details to the label
                 
                    vehicle_text_edit.Text = vehicle_dis;        
                    cost_text_edit.Text= cost_dis.ToString();          
                    date_edit.Text = date_dis;
                    showroom_no_text_edit.Text= showroomno_dis.ToString();
                    showroom_place_text_edit.Text = showroomplace_dis;
                    showroom_mail_text_edit.Text = showroommail_dis;

                    vehicle_temp = vehicle_dis.Trim();//to access the database with this identiy for editing
                    Edit_button.Visible = true;
                    Cancel_button.Visible = false;
                    Update_button.Visible = false;
                    BackToViewMode();
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





        private void Cancel_button_Click_1(object sender, EventArgs e)
        {
            BackToViewMode();
        }

        private void Update_button_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update_vehicle", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@vehicle_id",  vehicle_text_edit.Text.Trim());
                cmd.Parameters.AddWithValue("@date",Convert.ToDateTime( date_edit.Text.Trim()));
                cmd.Parameters.AddWithValue("@cost", Convert.ToInt32( cost_text_edit.Text.Trim()));
                cmd.Parameters.AddWithValue("@showroom_place", showroom_place_text_edit.Text.Trim());
                cmd.Parameters.AddWithValue("@showrrom_no", Convert.ToInt32( showroom_no_text_edit.Text.Trim()));
                cmd.Parameters.AddWithValue("@showroom_mail",  showroom_mail_text_edit.Text.Trim());  
                cmd.Parameters.AddWithValue("@vehicle_old",  vehicle_temp);

                cmd.ExecuteNonQuery();
                BackToViewMode();
                MessageBox.Show("Updated");


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



        private void Edit_button_Click_1(object sender, EventArgs e)
        {
            Cancel_button.Visible = true;
            Update_button.Visible = true;
            Edit_button.Visible = false;
            vehicle_text_edit.ReadOnly = false;
            cost_text_edit.ReadOnly = false;
            date_edit.Enabled = true;
            showroom_no_text_edit.ReadOnly = false;
            showroom_place_text_edit.ReadOnly = false;
            showroom_mail_text_edit.ReadOnly = false;

            vehicle_text_edit.BorderStyle = BorderStyle.Fixed3D;
            cost_text_edit.BorderStyle = BorderStyle.Fixed3D;
            showroom_no_text_edit.BorderStyle = BorderStyle.Fixed3D;
            showroom_place_text_edit.BorderStyle = BorderStyle.Fixed3D;
            showroom_mail_text_edit.BorderStyle = BorderStyle.Fixed3D;

            date_edit.Visible = true;
        }

        public void BackToViewMode()
        {
            Cancel_button.Visible = false;
            Update_button.Visible = false;
            Edit_button.Visible = true;
            vehicle_text_edit.ReadOnly = true;
            cost_text_edit.ReadOnly = true;
            date_edit.Enabled = false;
            showroom_no_text_edit.ReadOnly = true;
            showroom_place_text_edit.ReadOnly = true;
            showroom_mail_text_edit.ReadOnly = true;

            vehicle_text_edit.BorderStyle = BorderStyle.None;
            cost_text_edit.BorderStyle = BorderStyle.None;
            showroom_no_text_edit.BorderStyle = BorderStyle.None;
            showroom_place_text_edit.BorderStyle = BorderStyle.None;
            showroom_mail_text_edit.BorderStyle = BorderStyle.None;

        }

        
    }
}
