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
    public partial class Driver : UserControl
    {
        public Driver()
        {
            InitializeComponent();
            Load_driver();
        }

        public void Load_driver()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("driver_list_show", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                driver_droplist.Items.Clear();
                Driver_drop.Items.Clear();
                while (reader.Read())
                {
                    string vehicle_nos = (string)reader["driver"];
                    driver_droplist.Items.Add(vehicle_nos);
                    Driver_drop.Items.Add(vehicle_nos);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error occured in loading the vehicle list");
            }
            finally
            {
                conn.Close();
            }
        }
        //to load the coloum of the list
        public void loadcoloum()
        {
            driver_trip_list.Columns.Add("Vehicle");
            driver_trip_list.Columns.Add("From");
            driver_trip_list.Columns.Add("To");
            driver_trip_list.Columns.Add("Date");
        }
        // to load the trip detailsof the driver
        private void Details_trip_button_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("driver_trip", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@driver", Driver_show_label.Text.Trim());
                cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(from_date.Text.Trim()));
                cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(to_date.Text.Trim()));
                driver_trip_list.Clear();
                loadcoloum();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                driver_trip_list.View = View.Details;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow dr = data.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["vehicle_number"].ToString());
                    listitem.SubItems.Add(dr["from_place"].ToString());
                    listitem.SubItems.Add(dr["to_place"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["date_new"]).ToString("d/MM/yyyy"));
                    driver_trip_list.Items.Add(listitem);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Submit_driver_Click(object sender, EventArgs e)
        {
            Driver_show_label.Text = driver_droplist.Text;
            Driver_details();
        }


        public void Driver_details()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
               
                conn.Open();
                SqlCommand cmd = new SqlCommand("driver_cash_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@driver", Driver_show_label.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["pending_with_driver"] != DBNull.Value)
                    {
                        pending_info.Text = reader["pending_with_driver"].ToString();
                        if (reader["payment"] != DBNull.Value)
                        {

                            Total_info.Text = reader["payment"].ToString();

                            Double outstanding = Convert.ToDouble(Total_info.Text) - Convert.ToDouble(pending_info.Text);
                            outstanding_info.Text =Convert.ToString( outstanding);
                        }
                    }

                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
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
                SqlCommand cmd = new SqlCommand("driver_payment_date", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@driver", Driver_show_label.Text.Trim());
                cmd.Parameters.AddWithValue("@payment_type", dropdown_payment_type.Text.Trim());
                cmd.Parameters.AddWithValue("@date",Convert.ToDateTime(date_for_payment.Text.Trim()));
                cmd.Parameters.AddWithValue("@amount",Convert.ToInt32( amount.Text.Trim()));
                cmd.ExecuteNonQuery();

                SqlCommand cmdnxt = new SqlCommand("update_driver_money", conn);
                cmdnxt.CommandType = CommandType.StoredProcedure;
                cmdnxt.Parameters.AddWithValue("@driver",Driver_show_label.Text.Trim());
                cmdnxt.Parameters.AddWithValue("@amount", amount.Text.Trim());
                cmdnxt.ExecuteNonQuery();

                Driver_details();
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

        private void reduce_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {            
                conn.Open();
                SqlCommand cmd = new SqlCommand("reduce_pending", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@driver", Driver_show_label.Text.Trim());            
                cmd.ExecuteNonQuery();

                Driver_details();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Submit_driver_add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("add_driver", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@driver", Driver_text_add.Text.Trim());
                cmd.ExecuteNonQuery();
                Load_driver();
                Driver_text_add.Clear();
                MessageBox.Show("Details uploaded");

            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                conn.Close();
            }
        }







        public void Listcoloum_load_trip()
        {
            driver_pay_listview.Columns.Add("Vehicle");
            driver_pay_listview.Columns.Add("From");
            driver_pay_listview.Columns.Add("To");
            driver_pay_listview.Columns.Add("Date");
            driver_pay_listview.Columns.Add("Amount");
            driver_pay_listview.Columns.Add("Advance");
        }

        public void Listcoloum_load_payment()
        {
            driver_pay_listview.Columns.Add("Payment Type");
            driver_pay_listview.Columns.Add("Date");
            driver_pay_listview.Columns.Add("Amount");
        }



        private void Driver_payment_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();

                if (trip_payment.Checked)
                {
                    SqlCommand cmd = new SqlCommand("driver_trip_pay", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@driver", Driver_drop.Text.Trim());
                    cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(from_date_pay.Text.Trim()));
                    cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(to_date_pay.Text.Trim()));
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable data = new DataTable();
                    data.Load(reader);
                    driver_pay_listview.Clear();
                    Listcoloum_load_trip();
                    driver_pay_listview.View = View.Details;

              
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        DataRow dr = data.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["vehicle_number"].ToString());
                        listitem.SubItems.Add(dr["from_place"].ToString());
                        listitem.SubItems.Add(dr["to_place"].ToString());
                        listitem.SubItems.Add(Convert.ToDateTime(dr["date_new"]).ToString("d/MM/yyyy"));
                        listitem.SubItems.Add(dr["amount"].ToString());
                        listitem.SubItems.Add(dr["Advance"].ToString());
                        driver_pay_listview.Items.Add(listitem);
                    }
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("driver_pay", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@driver", Driver_drop.Text.Trim());
                    cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(from_date_pay.Text.Trim()));
                    cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(to_date_pay.Text.Trim()));
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable data = new DataTable();
                    data.Load(reader);
                    driver_pay_listview.Clear();
                    Listcoloum_load_payment();
                    driver_pay_listview.View = View.Details;

                   
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        DataRow dr = data.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["payment_type"].ToString());
                        listitem.SubItems.Add(Convert.ToDateTime(dr["date"]).ToString("d/MM/yyyy"));
                        listitem.SubItems.Add(dr["amount"].ToString());
                        driver_pay_listview.Items.Add(listitem);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
