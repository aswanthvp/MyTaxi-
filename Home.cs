using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace MyTaxi
{
    public partial class Home : UserControl
    {
        
       
        public Home()
        {
            InitializeComponent();
            Load_vehicle();
            Listcoloum_load();
            Load_driver();
            Load_company();
        }

        //To load the vehicle list into the droplist
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
                dropdown_vehicle_details.Items.Clear();
                dropdown_vehicle_trip.Items.Clear();
                while (reader.Read())
                {
                    string vehicle_nos = (string)reader["vehicle_no"];
                    dropdown_vehicle_trip.Items.Add(vehicle_nos);
                    dropdown_vehicle_details.Items.Add(vehicle_nos);
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
        //submiting to search to details from vehicles and date 
        private void Submit1_button_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("vehicle_fetch_triptab", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vehicle", SqlDbType.VarChar).Value = dropdown_vehicle_details.Text.Trim();
                cmd.Parameters.AddWithValue("@from_date", Convert.ToDateTime(from_date.Text.Trim()));
                cmd.Parameters.AddWithValue("@to_date", Convert.ToDateTime(to_date.Text.Trim()));
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                vehicle_listview.Clear();
                Listcoloum_load();
                vehicle_listview.View = View.Details;
                //Laoding data into vehicle_listview
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow dr = data.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["company"].ToString());
                    listitem.SubItems.Add(dr["cost_km"].ToString());
                    listitem.SubItems.Add(dr["km"].ToString());
                    listitem.SubItems.Add(dr["from_place"].ToString());
                    listitem.SubItems.Add(dr["to_place"].ToString());
                    listitem.SubItems.Add(dr["diesel_cost"].ToString());
                    listitem.SubItems.Add(dr["material"].ToString());
                    listitem.SubItems.Add(dr["driver"].ToString());
                    listitem.SubItems.Add(dr["remarks"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["date_new"]).ToString("d/MM/yyyy"));
                    listitem.SubItems.Add(dr["quality_in_feed"].ToString());
                    vehicle_listview.Items.Add(listitem);
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


        //while selecting the vehicle number from the drop down list in trip tab
        private void dropdown_vehicle_trip_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {  
                conn.Open();
                SqlCommand cmd = new SqlCommand("vehicle_last_trip", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vehicle", SqlDbType.VarChar).Value = dropdown_vehicle_trip.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                From_text.Clear();
                To_text.Clear();
                while (reader.Read())
                {
                    if (reader["from_place"] != DBNull.Value)
                    {
                        From_text.Text = (string)reader["from_place"];
                    }
                    if (reader["to_place"] != DBNull.Value)
                    {
                        To_text.Text = (string)reader["to_place"];
                    }  
                    if(reader["driver"]!=DBNull.Value)
                    {
                        driver_droplist.Text = (string)reader["driver"];
                    }
                }
                if(driver_droplist.Text!=null)
                {
                    driver_pending_load();
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
        //submiting to insert to database about
        private void Submit_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";

           
             try
             {
                conn.Open();
                int advance_payment=0, temp=0;
                if (Advance_text_company.Text != null || Advance_text_US.Text != null)
                {
                    if (Advance_text_company.Text != null && Advance_text_US.Text != null)
                    {
                        advance_payment = Convert.ToInt32((Advance_text_company.Text.Trim())) + Convert.ToInt32((Advance_text_US.Text.Trim()));
                    }
                    else if (Advance_text_US.Text != null)
                    {
                        advance_payment = Convert.ToInt32((Advance_text_US.Text.Trim()));
                    }
                    else
                    {
                        advance_payment = Convert.ToInt32((Advance_text_company.Text.Trim()));
                    }

                    temp = advance_payment;
                    advance_payment = advance_payment - Convert.ToInt32((Remarks_text.Text.Trim()));

                    SqlCommand cmd_new = new SqlCommand("advance_update", conn);
                    cmd_new.CommandType = CommandType.StoredProcedure;
                    cmd_new.Parameters.AddWithValue("@driver", driver_droplist.Text);
                    cmd_new.Parameters.AddWithValue("@amount", advance_payment);
                    cmd_new.ExecuteNonQuery();

                    int company_reduce = Convert.ToInt32((Advance_text_company.Text.Trim())) + Convert.ToInt32((Diesel_text.Text.Trim()));
                    SqlCommand cmd_new_company = new SqlCommand("company_driver_advance_reduce", conn);
                    cmd_new_company.CommandType = CommandType.StoredProcedure;
                    cmd_new_company.Parameters.AddWithValue("@company", company_text.Text);
                    cmd_new_company.Parameters.AddWithValue("@amount", company_reduce);
                    cmd_new_company.ExecuteNonQuery();
                }

                SqlCommand cmd = new SqlCommand("insert_trip_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vehicle_number",  dropdown_vehicle_trip.Text.Trim());
                cmd.Parameters.AddWithValue("@cost", Convert.ToInt32( Cost_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@km", Convert.ToInt32( KM_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@company",  company_text.Text.Trim());
                cmd.Parameters.AddWithValue("@from_place", From_text.Text.Trim());
                cmd.Parameters.AddWithValue("@to_place",  To_text.Text.Trim());
                cmd.Parameters.AddWithValue("@diesel_cost", Convert.ToInt32( Diesel_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@diesel_cost_us", Convert.ToInt32(diesel_text_us.Text.Trim()));
                cmd.Parameters.AddWithValue("@material", Material_text.Text.Trim());
                cmd.Parameters.AddWithValue("@driver",driver_droplist.Text.Trim());
                cmd.Parameters.AddWithValue("@remarks", Convert.ToInt32( Remarks_text.Text.Trim()));
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(date_pick.Text.Trim()));
                cmd.Parameters.AddWithValue("@quality_in_feed",  Quality_in_feeds_text.Text.Trim());
                cmd.Parameters.AddWithValue("@advance", temp);
                cmd.ExecuteNonQuery();
               

                //resetting after inserting

                Cost_text.Clear();
                KM_text.Clear();
                Remarks_text.Clear();
                date_pick.ResetText();
                Quality_in_feeds_text.Clear();
                Diesel_text.Clear();
                Material_text.Clear();
                Advance_text_company.Clear();
                Advance_text_US.Clear();

   
                MessageBox.Show("Trip details updated");
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

       
        public void Listcoloum_load()
        {
            vehicle_listview.Columns.Add("Company");
            vehicle_listview.Columns.Add("Cost/km");
            vehicle_listview.Columns.Add("KM");
            vehicle_listview.Columns.Add("From");
            vehicle_listview.Columns.Add("To");
            vehicle_listview.Columns.Add("Diesel");
            vehicle_listview.Columns.Add("Material");
            vehicle_listview.Columns.Add("Driver");
            vehicle_listview.Columns.Add("Remarks");
            vehicle_listview.Columns.Add("Date");
            vehicle_listview.Columns.Add("Quality");
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
                while (reader.Read())
                {
                    string vehicle_nos = (string)reader["driver"];
                    driver_droplist.Items.Add(vehicle_nos);
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

        private void driver_droplist_SelectedIndexChanged(object sender, EventArgs e)
        {

            driver_pending_load();
        }

        public void driver_pending_load()
        {
            SqlConnection conn_new = new SqlConnection();
            conn_new.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            try
            {
                conn_new.Open();
                SqlCommand cmd_new = new SqlCommand("pending_driver", conn_new);
                cmd_new.CommandType = CommandType.StoredProcedure;
                cmd_new.Parameters.AddWithValue("@driver", SqlDbType.VarChar).Value = driver_droplist.Text;
                SqlDataReader reader_new = cmd_new.ExecuteReader();
                pending_info_text.Text = "";
                while (reader_new.Read())
                {
                    if (reader_new["pending_with_driver"] != DBNull.Value)
                    {
                        pending_info_text.Text = Convert.ToString( reader_new["pending_with_driver"]);
                    }
                }
            }catch(Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                conn_new.Close();
            }
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
                company_text.Items.Clear();
                while (reader.Read())
                {
                    company_text.Items.Add((string)reader["company"]);
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

        private void Overview_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn_new = new SqlConnection();
            conn_new.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
           // try
            //{
                conn_new.Open();
                SqlCommand cmd_new = new SqlCommand("total_overview", conn_new);
                cmd_new.CommandType = CommandType.StoredProcedure;
                cmd_new.Parameters.AddWithValue("@from",Convert.ToDateTime(overview_from_date.Text.Trim()));
                cmd_new.Parameters.AddWithValue("@to", Convert.ToDateTime(overview_to_date.Text.Trim()));
                SqlDataReader reader_new = cmd_new.ExecuteReader(); 
                while (reader_new.Read())
                {
                    
                        int total_company_temp = Convert.ToInt32(reader_new["total_company"]);
                        int driver_money = Convert.ToInt32(total_company_temp*.15);
                        int remarks_temp = Convert.ToInt32(reader_new["remark"]);
                        int diesel_temp= Convert.ToInt32(reader_new["diesel"]);

                        int total_profit = total_company_temp - driver_money - remarks_temp - diesel_temp;

                        company_money.Text= Convert.ToString(total_company_temp);
                        Driver_money.Text = Convert.ToString(driver_money);
                        petrol_money.Text = Convert.ToString(diesel_temp);
                        Fine_money.Text = Convert.ToString(remarks_temp);
                        Profit_money.Text = Convert.ToString(total_profit);
               
                }
           /* }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                conn_new.Close();
            }*/
        }
    }
}
