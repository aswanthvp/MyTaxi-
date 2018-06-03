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
    public partial class database : UserControl
    {
       
        public database()
        {
            InitializeComponent();
        }



        private void Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                backup_location.Text = dlg.SelectedPath;
            }
        }

        private void Browse_restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Data backup";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restore_location.Text = dlg.FileName;
            }
        }


        private void backup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            string database = conn.Database.ToString();
            try
            {
                conn.Open();
                if(backup_location.Text==string.Empty)
                {
                    MessageBox.Show("Select the location to save the backup file");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK= '" + backup_location.Text + "\\" + "DATABASE" + "-" + DateTime.Now.ToString("yyyy-mm-dd--HH-mm-ss") + ".bak '";
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data backup done successfully");
                    backup_location.Clear();

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

        private void Restore_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MyTaxi;Integrated Security=True";
            string database = conn.Database.ToString();
            
            if (restore_location.Text == string.Empty)
            {
                MessageBox.Show("Select the backup file");
            }
            else
            {

                try
                {
                    conn.Open();
                    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand bu2 = new SqlCommand(sqlStmt2, conn);
                    bu2.ExecuteNonQuery();

                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + restore_location.Text + "'WITH REPLACE;";
                    SqlCommand bu3 = new SqlCommand(sqlStmt3, conn);
                    bu3.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand bu4 = new SqlCommand(sqlStmt4, conn);
                    bu4.ExecuteNonQuery();
                    restore_location.Clear();

                    MessageBox.Show("data restoration done successefully");

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
        }
    }
}
