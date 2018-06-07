namespace MyTaxi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.backup_button = new System.Windows.Forms.Button();
            this.MyTaxi = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Break_panel = new System.Windows.Forms.Panel();
            this.Bottom_panel = new System.Windows.Forms.Panel();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Company = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Maintenance = new System.Windows.Forms.Button();
            this.Vehicle_button = new System.Windows.Forms.Button();
            this.Driver = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.database1 = new MyTaxi.database();
            this.company1 = new MyTaxi.Company();
            this.home_new = new MyTaxi.Home();
            this.vehicle_new = new MyTaxi.vehicle();
            this.maintenance1 = new MyTaxi.Maintenance();
            this.driver1 = new MyTaxi.Driver();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Left_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Top_panel.Controls.Add(this.backup_button);
            this.Top_panel.Controls.Add(this.MyTaxi);
            this.Top_panel.Controls.Add(this.Exit);
            this.Top_panel.Controls.Add(this.Logo);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1000, 34);
            this.Top_panel.TabIndex = 0;
            this.Top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // backup_button
            // 
            this.backup_button.BackColor = System.Drawing.Color.Tan;
            this.backup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backup_button.Location = new System.Drawing.Point(844, 4);
            this.backup_button.Name = "backup_button";
            this.backup_button.Size = new System.Drawing.Size(64, 23);
            this.backup_button.TabIndex = 2;
            this.backup_button.Text = "Backup";
            this.backup_button.UseVisualStyleBackColor = false;
            this.backup_button.Click += new System.EventHandler(this.backup_button_Click);
            // 
            // MyTaxi
            // 
            this.MyTaxi.AutoEllipsis = true;
            this.MyTaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTaxi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyTaxi.Location = new System.Drawing.Point(94, 0);
            this.MyTaxi.Name = "MyTaxi";
            this.MyTaxi.Size = new System.Drawing.Size(92, 34);
            this.MyTaxi.TabIndex = 1;
            this.MyTaxi.Text = "MyTaxi";
            this.MyTaxi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(968, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Logo
            // 
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(100, 34);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Break_panel
            // 
            this.Break_panel.BackColor = System.Drawing.Color.OldLace;
            this.Break_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Break_panel.Location = new System.Drawing.Point(0, 34);
            this.Break_panel.Name = "Break_panel";
            this.Break_panel.Size = new System.Drawing.Size(1000, 10);
            this.Break_panel.TabIndex = 1;
            // 
            // Bottom_panel
            // 
            this.Bottom_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_panel.Location = new System.Drawing.Point(0, 454);
            this.Bottom_panel.Name = "Bottom_panel";
            this.Bottom_panel.Size = new System.Drawing.Size(1000, 10);
            this.Bottom_panel.TabIndex = 2;
            // 
            // Left_panel
            // 
            this.Left_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Left_panel.Controls.Add(this.tableLayoutPanel1);
            this.Left_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_panel.Location = new System.Drawing.Point(0, 44);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(134, 410);
            this.Left_panel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Company, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Home, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Maintenance, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Vehicle_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Driver, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(131, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Company
            // 
            this.Company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Company.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Company.Location = new System.Drawing.Point(3, 331);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(125, 76);
            this.Company.TabIndex = 5;
            this.Company.Text = "Company";
            this.Company.Click += new System.EventHandler(this.Company_Click);
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(3, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(125, 76);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click_1);
            // 
            // Maintenance
            // 
            this.Maintenance.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Maintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maintenance.Location = new System.Drawing.Point(3, 85);
            this.Maintenance.Name = "Maintenance";
            this.Maintenance.Size = new System.Drawing.Size(125, 73);
            this.Maintenance.TabIndex = 2;
            this.Maintenance.Text = "Maintenance";
            this.Maintenance.Click += new System.EventHandler(this.Maintenence_Click);
            // 
            // Vehicle_button
            // 
            this.Vehicle_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Vehicle_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Vehicle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehicle_button.Location = new System.Drawing.Point(3, 167);
            this.Vehicle_button.Name = "Vehicle_button";
            this.Vehicle_button.Size = new System.Drawing.Size(125, 73);
            this.Vehicle_button.TabIndex = 3;
            this.Vehicle_button.Text = "Vehicle";
            this.Vehicle_button.UseVisualStyleBackColor = false;
            this.Vehicle_button.Click += new System.EventHandler(this.Vehicle_button_Click);
            // 
            // Driver
            // 
            this.Driver.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Driver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Driver.Location = new System.Drawing.Point(3, 249);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(125, 73);
            this.Driver.TabIndex = 4;
            this.Driver.Text = "Driver";
            this.Driver.Click += new System.EventHandler(this.Driver_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.database1);
            this.panel5.Controls.Add(this.company1);
            this.panel5.Controls.Add(this.home_new);
            this.panel5.Controls.Add(this.vehicle_new);
            this.panel5.Controls.Add(this.maintenance1);
            this.panel5.Controls.Add(this.driver1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(134, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(866, 410);
            this.panel5.TabIndex = 4;
            // 
            // database1
            // 
            this.database1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.database1.Location = new System.Drawing.Point(0, 0);
            this.database1.Name = "database1";
            this.database1.Size = new System.Drawing.Size(866, 410);
            this.database1.TabIndex = 7;
            this.database1.Visible = false;
            this.database1.Load += new System.EventHandler(this.database1_Load);
            // 
            // company1
            // 
            this.company1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.company1.Location = new System.Drawing.Point(0, 0);
            this.company1.Name = "company1";
            this.company1.Size = new System.Drawing.Size(866, 410);
            this.company1.TabIndex = 6;
            this.company1.Visible = false;
            // 
            // home_new
            // 
            this.home_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_new.BackgroundImage")));
            this.home_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_new.Location = new System.Drawing.Point(0, 0);
            this.home_new.Name = "home_new";
            this.home_new.Size = new System.Drawing.Size(866, 410);
            this.home_new.TabIndex = 5;
            // 
            // vehicle_new
            // 
            this.vehicle_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vehicle_new.BackgroundImage")));
            this.vehicle_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicle_new.Location = new System.Drawing.Point(0, 0);
            this.vehicle_new.Name = "vehicle_new";
            this.vehicle_new.Size = new System.Drawing.Size(866, 410);
            this.vehicle_new.TabIndex = 4;
            this.vehicle_new.Visible = false;
            // 
            // maintenance1
            // 
            this.maintenance1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maintenance1.BackgroundImage")));
            this.maintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintenance1.Location = new System.Drawing.Point(0, 0);
            this.maintenance1.Name = "maintenance1";
            this.maintenance1.Size = new System.Drawing.Size(866, 410);
            this.maintenance1.TabIndex = 3;
            this.maintenance1.Visible = false;
            // 
            // driver1
            // 
            this.driver1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("driver1.BackgroundImage")));
            this.driver1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver1.Location = new System.Drawing.Point(0, 0);
            this.driver1.Name = "driver1";
            this.driver1.Size = new System.Drawing.Size(866, 410);
            this.driver1.TabIndex = 2;
            this.driver1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 464);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Left_panel);
            this.Controls.Add(this.Bottom_panel);
            this.Controls.Add(this.Break_panel);
            this.Controls.Add(this.Top_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Left_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Break_panel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Bottom_panel;
        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.Panel panel5;   
        private System.Windows.Forms.Label MyTaxi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Company;
        private System.Windows.Forms.Button Maintenance;
        private System.Windows.Forms.Button Vehicle_button;
        private System.Windows.Forms.Button Driver;
        private System.Windows.Forms.Button Exit;
        private Maintenance maintenance1;
        private Driver driver1;
        private vehicle vehicle_new;
        private Home home_new;
        private Company company1;
        private System.Windows.Forms.Button backup_button;
        private database database1;
    }
}

