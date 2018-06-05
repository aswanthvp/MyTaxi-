using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace MyTaxi
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }


        SqlConnection masterConnection = new SqlConnection();
        private string GetSql(string Name)
        {

            try
            {
                // Gets the current assembly.
                Assembly Asm = Assembly.GetExecutingAssembly();

                // Resources are named using a fully qualified name.
                Stream strm = Asm.GetManifestResourceStream(Asm.GetName().Name + "." + Name);

                // Reads the contents of the embedded file.
                StreamReader reader = new StreamReader(strm);
                return reader.ReadToEnd();

            }
            catch (Exception ex)
            {
                MessageBox.Show("In GetSQL: " + ex.Message);
                throw ex;
            }
        }

        private void ExecuteSql(string DatabaseName, string Sql)
        {
            SqlCommand Command = new SqlCommand(Sql, masterConnection);

            // Initialize the connection, open it, and set it to the "master" database
            masterConnection.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=master;Integrated Security=True";
            Command.Connection.Open();
            Command.Connection.ChangeDatabase(DatabaseName);
            try
            {
                Command.ExecuteNonQuery();
            }
            finally
            {
                // Closing the connection should be done in a Finally block
                Command.Connection.Close();
            }
        }

        protected void AddDBTable(string strDBName)
        {
            try
            {
                // Creates the database.

                ExecuteSql("master", "CREATE DATABASE " + strDBName);
                ExecuteSql(strDBName, "ALTER DATABASE MyTaxi SET AUTO_CLOSE OFF");

               // ExecuteSql("master", "CREATE DATABASE " + strDBName);


                // Creates the tables.
                ExecuteSql(strDBName, GetSql("COMPANY.txt"));
                ExecuteSql(strDBName, GetSql("company_payment.txt"));
                ExecuteSql(strDBName, GetSql("driver.txt"));
                ExecuteSql(strDBName, GetSql("driver_payment_details_table.txt"));
                ExecuteSql(strDBName, GetSql("maintenance.txt"));
                ExecuteSql(strDBName, GetSql("trip_details.txt"));
                ExecuteSql(strDBName, GetSql("vehicle_details.txt"));

                // Creates the stored procedure.
                ExecuteSql(strDBName, GetSql("add_company.txt"));
                ExecuteSql(strDBName, GetSql("add_driver.txt"));
                ExecuteSql(strDBName, GetSql("company_cash_details.txt"));
                ExecuteSql(strDBName, GetSql("company_list_show.txt"));
                ExecuteSql(strDBName, GetSql("company_pay.txt"));
                ExecuteSql(strDBName, GetSql("company_payment_details.txt"));
                ExecuteSql(strDBName, GetSql("company_trip.txt"));
                ExecuteSql(strDBName, GetSql("delete_maintenance.txt"));
                ExecuteSql(strDBName, GetSql("driver_cash_details.txt"));
                ExecuteSql(strDBName, GetSql("driver_list_show.txt"));             
                ExecuteSql(strDBName, GetSql("driver_pay.txt"));
                ExecuteSql(strDBName, GetSql("driver_payment_details.txt"));
                ExecuteSql(strDBName, GetSql("driver_trip.txt"));
                ExecuteSql(strDBName, GetSql("driver_trip_pay.txt"));
                ExecuteSql(strDBName, GetSql("insert_maintanance_details.txt"));
                ExecuteSql(strDBName, GetSql("insert_trip_details.txt"));
                ExecuteSql(strDBName, GetSql("insert_vehicle.txt"));
                ExecuteSql(strDBName, GetSql("maintanence_search.txt"));
                ExecuteSql(strDBName, GetSql("maintenance_update.txt"));
                ExecuteSql(strDBName, GetSql("pending_driver.txt"));
                ExecuteSql(strDBName, GetSql("reduce_pending.txt"));
                ExecuteSql(strDBName, GetSql("total_overview.txt"));
                ExecuteSql(strDBName, GetSql("trip_delete_details.txt"));
                ExecuteSql(strDBName, GetSql("trip_list_view.txt"));
                ExecuteSql(strDBName, GetSql("update_company.txt"));
                ExecuteSql(strDBName, GetSql("update_driver_money.txt"));
                ExecuteSql(strDBName, GetSql("update_vehicle.txt"));
                ExecuteSql(strDBName, GetSql("vehicle_details_return.txt"));
                ExecuteSql(strDBName, GetSql("vehicle_fetch_triptab.txt"));
                ExecuteSql(strDBName, GetSql("vehicle_last_trip.txt"));
                ExecuteSql(strDBName, GetSql("vehicle_list_show.txt"));

                //create triggers
                ExecuteSql(strDBName, GetSql("company_payment_update_trigger.txt"));
                ExecuteSql(strDBName, GetSql("delete_res_triggert.txt"));
                ExecuteSql(strDBName, GetSql("insert_vehicle_last_trip_trigger.txt"));

            }
            catch (Exception ex)
            {
                // Reports any errors and abort.
                MessageBox.Show("In exception handler: " + ex.Message);
                throw ex;

            }
        }


        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
            AddDBTable("MyTaxi");
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
            ExecuteSql("master", "DROP DATABASE MyTaxi");
        }
    }
}
