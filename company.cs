using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MyTaxi
{
    public partial class Company : UserControl
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

        public Company()
        {
            InitializeComponent();
            Graphicload();
            Load_company();
        }

        public void Graphicload()
        {
            int style = NativeWinAPI.GetWindowLong(Company_add.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(Company_add.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            int style1 = NativeWinAPI.GetWindowLong(Company_tab.Handle, NativeWinAPI.GWL_EXSTYLE);
            style1 |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(Company_tab.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }


        private void Submit_driver_Click(object sender, EventArgs e)
        {
            Company_show_label.Text = Company_droplist.Text.Trim();
            Company_details();
        }

        private void Details_trip_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
           try
           {
                conn.Open();
                SqlCommand cmd = new SqlCommand("company_trip", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", Company_show_label.Text.Trim());
                cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(from_date.Text.Trim()));
                cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(to_date.Text.Trim()));
                company_trip_list.Clear();
                Loadcoloum();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                company_trip_list.View = View.Details;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow dr = data.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["vehicle_number"].ToString());
                    listitem.SubItems.Add(dr["from_place"].ToString());
                    listitem.SubItems.Add(dr["to_place"].ToString());
                    listitem.SubItems.Add(dr["driver"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["date_new"]).ToString("d/MM/yyyy"));
                    company_trip_list.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Payment_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("company_payment_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", Company_show_label.Text.Trim());
                cmd.Parameters.AddWithValue("@payment_type", dropdown_payment_type.Text.Trim());
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(date_for_payment.Text.Trim()));
                cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(amount.Text.Trim()));
                cmd.ExecuteNonQuery();

                Company_details();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                conn.Close();
                amount.Clear();
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("update_company", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", Company_show_label.Text.Trim());
                cmd.Parameters.AddWithValue("@contact",Convert.ToInt32( contact_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@email", email_text.Text.Trim());
                cmd.ExecuteNonQuery();
   
                MessageBox.Show("Details updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                Off_edit_mode();
                conn.Close();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Off_edit_mode();
            Company_details();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            email_text.ReadOnly = false;
            contact_text.ReadOnly = false;
            Edit_button.Visible = false;
            cancel_button.Visible = true;
            Update_button.Visible = true;
        }


        public void Load_company()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("company_list_show", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                Company_droplist.Items.Clear();
                Company_drop.Items.Clear();
                while (reader.Read())
                {
                    Company_droplist.Items.Add((string)reader["company"]);
                    Company_drop.Items.Add((string)reader["company"]);
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

        public void Company_details()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("Company_cash_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", Company_show_label.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {                  
                    Total_info.Text = reader["total"].ToString();
                    email_text.Text = reader["email"].ToString();
                    contact_text.Text = reader["contact"].ToString();
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

        public void Off_edit_mode()
        {
            email_text.ReadOnly = true;
            contact_text.ReadOnly = true;
            cancel_button.Visible = false;
            Update_button.Visible = false;
            Edit_button.Visible = true;
        }

        public void Loadcoloum()
        {
            company_trip_list.Columns.Add("Vehicle");
            company_trip_list.Columns.Add("From");
            company_trip_list.Columns.Add("To");
            company_trip_list.Columns.Add("Driver");
            company_trip_list.Columns.Add("Date");
        }

        private void Submit_company_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("add_company", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", Company_text_add.Text.Trim());
                cmd.Parameters.AddWithValue("@contact",Convert.ToInt32( contact_text_add.Text.Trim()));
                cmd.Parameters.AddWithValue("@email", email_text_add.Text.Trim());
                cmd.ExecuteNonQuery();
                Load_company();

                Company_text_add.Clear();
                contact_text_add.Clear();
                email_text_add.Clear();

                MessageBox.Show("Details uploaded");

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

        private void Company_payment_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
             try
            {
            conn.Open();

                SqlCommand cmd = new SqlCommand("company_pay", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", Company_drop.Text.Trim());
                cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(from_date_pay.Text.Trim()));
                cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(to_date_pay.Text.Trim()));
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                company_pay_listview.Clear();
                Listcoloum_load_payment();
                company_pay_listview.View = View.Details;


                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow dr = data.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["payment_type"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["date"]).ToString("d/MM/yyyy"));
                    listitem.SubItems.Add(dr["amount"].ToString());
                    company_pay_listview.Items.Add(listitem);
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


        public void Listcoloum_load_payment()
        {
            company_pay_listview.Columns.Add("Payment Type");
            company_pay_listview.Columns.Add("Date");
            company_pay_listview.Columns.Add("Amount");
        }
    }
}
