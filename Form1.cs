using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTaxi
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public int xx, yy;

        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void Home_Click_1(object sender, EventArgs e)
        {
            vehicle_new.Visible = false;
            home_new.Visible = true;          
            maintenance1.Visible = false;
            driver1.Visible = false;
            company1.Visible = false;

            home_new.Load_vehicle();
            home_new.Load_company();
            home_new.Load_driver();
        }

        private void Maintenence_Click(object sender, EventArgs e)
        {
            vehicle_new.Visible = false;
            home_new.Visible = false;
            maintenance1.Visible = true;          
            driver1.Visible = false;
            company1.Visible = false;

            maintenance1.Load_vehicle();

        }

        private void Driver_Click(object sender, EventArgs e)
        {
            vehicle_new.Visible = false;
            home_new.Visible = false;
            maintenance1.Visible = false;
            driver1.Visible = true;
            company1.Visible = false;

        }

        private void Company_Click(object sender, EventArgs e)
        {
            vehicle_new.Visible = false;
            home_new.Visible = false;
            maintenance1.Visible = false;
            driver1.Visible = false;
            company1.Visible = true;

        }

        private void Vehicle_button_Click(object sender, EventArgs e)
        {
            vehicle_new.Visible = true;
            company1.Visible = false;
            home_new.Visible = false;
            maintenance1.Visible = false;
            driver1.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //mouse drag funtion 

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flag = true;
                xx = e.X;
                yy = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)

            {
                Point tmp = new Point();
                tmp.X = this.Location.X + (e.X - xx);

                tmp.Y = this.Location.Y + (e.Y - yy);
                this.Location = tmp;


            }
        }

       


       
    }
}
