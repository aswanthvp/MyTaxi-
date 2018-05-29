using System;

namespace MyTaxi
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Home_tab = new System.Windows.Forms.TabControl();
            this.Trip = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Quality_in_feeds_label = new System.Windows.Forms.Label();
            this.vehicle_label = new System.Windows.Forms.Label();
            this.Pending_label = new System.Windows.Forms.Label();
            this.From_label = new System.Windows.Forms.Label();
            this.From_text = new System.Windows.Forms.TextBox();
            this.To_label = new System.Windows.Forms.Label();
            this.To_text = new System.Windows.Forms.TextBox();
            this.KM_label = new System.Windows.Forms.Label();
            this.KM_text = new System.Windows.Forms.TextBox();
            this.Remarks_label = new System.Windows.Forms.Label();
            this.Remarks_text = new System.Windows.Forms.TextBox();
            this.Cost_text = new System.Windows.Forms.TextBox();
            this.Cost_label = new System.Windows.Forms.Label();
            this.Driver_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.Diesel = new System.Windows.Forms.Label();
            this.Material_text = new System.Windows.Forms.TextBox();
            this.Advance_label = new System.Windows.Forms.Label();
            this.dropdown_vehicle_trip = new System.Windows.Forms.ComboBox();
            this.company_label = new System.Windows.Forms.Label();
            this.Material_label = new System.Windows.Forms.Label();
            this.pending_info_text = new System.Windows.Forms.Label();
            this.driver_droplist = new System.Windows.Forms.ComboBox();
            this.Quality_in_feeds_text = new System.Windows.Forms.TextBox();
            this.company_text = new System.Windows.Forms.ComboBox();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Advance_text_company = new System.Windows.Forms.TextBox();
            this.Advance_text_US = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.diesel_text_us = new System.Windows.Forms.TextBox();
            this.Diesel_text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Submit_button = new System.Windows.Forms.Button();
            this.Trip_details = new System.Windows.Forms.TabPage();
            this.TripDetails_panel = new System.Windows.Forms.Panel();
            this.vehicle_listview = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.TripDetails_Table = new System.Windows.Forms.TableLayoutPanel();
            this.to_date = new System.Windows.Forms.DateTimePicker();
            this.Vehicle = new System.Windows.Forms.Label();
            this.To1_label = new System.Windows.Forms.Label();
            this.From1_label = new System.Windows.Forms.Label();
            this.Submit1_button = new System.Windows.Forms.Button();
            this.dropdown_vehicle_details = new System.Windows.Forms.ComboBox();
            this.from_date = new System.Windows.Forms.DateTimePicker();
            this.Total = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Fine_money = new System.Windows.Forms.Label();
            this.petrol_money = new System.Windows.Forms.Label();
            this.company_money = new System.Windows.Forms.Label();
            this.Driver_money = new System.Windows.Forms.Label();
            this.Profit_money = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Overview_submit = new System.Windows.Forms.Button();
            this.overview_to_date = new System.Windows.Forms.DateTimePicker();
            this.overview_from_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.delete_label = new System.Windows.Forms.Label();
            this.Home_tab.SuspendLayout();
            this.Trip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Trip_details.SuspendLayout();
            this.TripDetails_panel.SuspendLayout();
            this.TripDetails_Table.SuspendLayout();
            this.Total.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home_tab
            // 
            this.Home_tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Home_tab.Controls.Add(this.Trip);
            this.Home_tab.Controls.Add(this.Trip_details);
            this.Home_tab.Controls.Add(this.Total);
            this.Home_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_tab.Location = new System.Drawing.Point(0, 0);
            this.Home_tab.Name = "Home_tab";
            this.Home_tab.SelectedIndex = 0;
            this.Home_tab.Size = new System.Drawing.Size(866, 406);
            this.Home_tab.TabIndex = 0;
            // 
            // Trip
            // 
            this.Trip.Controls.Add(this.panel2);
            this.Trip.Controls.Add(this.panel1);
            this.Trip.Location = new System.Drawing.Point(4, 25);
            this.Trip.Name = "Trip";
            this.Trip.Padding = new System.Windows.Forms.Padding(3);
            this.Trip.Size = new System.Drawing.Size(858, 326);
            this.Trip.TabIndex = 0;
            this.Trip.Text = "Trip";
            this.Trip.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 245);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.25822F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.78873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.01408F));
            this.tableLayoutPanel1.Controls.Add(this.Quality_in_feeds_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.vehicle_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pending_label, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.From_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.From_text, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.To_label, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.To_text, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.KM_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.KM_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Remarks_label, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Remarks_text, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.Cost_text, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cost_label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Driver_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Date_label, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Diesel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Material_text, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Advance_label, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dropdown_vehicle_trip, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.company_label, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Material_label, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pending_info_text, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.driver_droplist, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Quality_in_feeds_text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.company_text, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.date_pick, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 245);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Quality_in_feeds_label
            // 
            this.Quality_in_feeds_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Quality_in_feeds_label.AutoSize = true;
            this.Quality_in_feeds_label.BackColor = System.Drawing.Color.Transparent;
            this.Quality_in_feeds_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quality_in_feeds_label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Quality_in_feeds_label.Location = new System.Drawing.Point(44, 214);
            this.Quality_in_feeds_label.Name = "Quality_in_feeds_label";
            this.Quality_in_feeds_label.Size = new System.Drawing.Size(95, 13);
            this.Quality_in_feeds_label.TabIndex = 28;
            this.Quality_in_feeds_label.Text = "Quality in feeds";
            // 
            // vehicle_label
            // 
            this.vehicle_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vehicle_label.AutoSize = true;
            this.vehicle_label.BackColor = System.Drawing.Color.Transparent;
            this.vehicle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.vehicle_label.Location = new System.Drawing.Point(90, 18);
            this.vehicle_label.Name = "vehicle_label";
            this.vehicle_label.Size = new System.Drawing.Size(49, 13);
            this.vehicle_label.TabIndex = 0;
            this.vehicle_label.Text = "Vehicle";
            // 
            // Pending_label
            // 
            this.Pending_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Pending_label.AutoSize = true;
            this.Pending_label.BackColor = System.Drawing.Color.Transparent;
            this.Pending_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pending_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Pending_label.Location = new System.Drawing.Point(365, 116);
            this.Pending_label.Name = "Pending_label";
            this.Pending_label.Size = new System.Drawing.Size(53, 13);
            this.Pending_label.TabIndex = 26;
            this.Pending_label.Text = "Pending";
            // 
            // From_label
            // 
            this.From_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.From_label.AutoSize = true;
            this.From_label.BackColor = System.Drawing.Color.Transparent;
            this.From_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.From_label.Location = new System.Drawing.Point(384, 18);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(34, 13);
            this.From_label.TabIndex = 4;
            this.From_label.Text = "From";
            // 
            // From_text
            // 
            this.From_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.From_text.Location = new System.Drawing.Point(424, 14);
            this.From_text.Name = "From_text";
            this.From_text.Size = new System.Drawing.Size(83, 20);
            this.From_text.TabIndex = 2;
            // 
            // To_label
            // 
            this.To_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.To_label.AutoSize = true;
            this.To_label.BackColor = System.Drawing.Color.Transparent;
            this.To_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.To_label.Location = new System.Drawing.Point(664, 18);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(22, 13);
            this.To_label.TabIndex = 9;
            this.To_label.Text = "To";
            // 
            // To_text
            // 
            this.To_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.To_text.Location = new System.Drawing.Point(692, 14);
            this.To_text.Name = "To_text";
            this.To_text.Size = new System.Drawing.Size(82, 20);
            this.To_text.TabIndex = 3;
            // 
            // KM_label
            // 
            this.KM_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.KM_label.AutoSize = true;
            this.KM_label.BackColor = System.Drawing.Color.Transparent;
            this.KM_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KM_label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.KM_label.Location = new System.Drawing.Point(114, 67);
            this.KM_label.Name = "KM_label";
            this.KM_label.Size = new System.Drawing.Size(25, 13);
            this.KM_label.TabIndex = 6;
            this.KM_label.Text = "KM";
            // 
            // KM_text
            // 
            this.KM_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.KM_text.Location = new System.Drawing.Point(145, 63);
            this.KM_text.Name = "KM_text";
            this.KM_text.Size = new System.Drawing.Size(83, 20);
            this.KM_text.TabIndex = 4;
            // 
            // Remarks_label
            // 
            this.Remarks_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Remarks_label.AutoSize = true;
            this.Remarks_label.BackColor = System.Drawing.Color.Transparent;
            this.Remarks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remarks_label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Remarks_label.Location = new System.Drawing.Point(598, 165);
            this.Remarks_label.Name = "Remarks_label";
            this.Remarks_label.Size = new System.Drawing.Size(88, 13);
            this.Remarks_label.TabIndex = 5;
            this.Remarks_label.Text = "Remarks(cost)";
            // 
            // Remarks_text
            // 
            this.Remarks_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Remarks_text.Location = new System.Drawing.Point(692, 161);
            this.Remarks_text.Name = "Remarks_text";
            this.Remarks_text.Size = new System.Drawing.Size(82, 20);
            this.Remarks_text.TabIndex = 13;
            // 
            // Cost_text
            // 
            this.Cost_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cost_text.Location = new System.Drawing.Point(424, 63);
            this.Cost_text.Name = "Cost_text";
            this.Cost_text.Size = new System.Drawing.Size(83, 20);
            this.Cost_text.TabIndex = 5;
            // 
            // Cost_label
            // 
            this.Cost_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cost_label.AutoSize = true;
            this.Cost_label.BackColor = System.Drawing.Color.Transparent;
            this.Cost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Cost_label.Location = new System.Drawing.Point(362, 67);
            this.Cost_label.Name = "Cost_label";
            this.Cost_label.Size = new System.Drawing.Size(56, 13);
            this.Cost_label.TabIndex = 2;
            this.Cost_label.Text = "Cost/KM";
            // 
            // Driver_label
            // 
            this.Driver_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_label.AutoSize = true;
            this.Driver_label.BackColor = System.Drawing.Color.Transparent;
            this.Driver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Driver_label.Location = new System.Drawing.Point(98, 116);
            this.Driver_label.Name = "Driver_label";
            this.Driver_label.Size = new System.Drawing.Size(41, 13);
            this.Driver_label.TabIndex = 3;
            this.Driver_label.Text = "Driver";
            // 
            // Date_label
            // 
            this.Date_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Date_label.AutoSize = true;
            this.Date_label.BackColor = System.Drawing.Color.Transparent;
            this.Date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Date_label.Location = new System.Drawing.Point(652, 67);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(34, 13);
            this.Date_label.TabIndex = 21;
            this.Date_label.Text = "Date";
            // 
            // Diesel
            // 
            this.Diesel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Diesel.AutoSize = true;
            this.Diesel.BackColor = System.Drawing.Color.Transparent;
            this.Diesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diesel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Diesel.Location = new System.Drawing.Point(97, 165);
            this.Diesel.Name = "Diesel";
            this.Diesel.Size = new System.Drawing.Size(42, 13);
            this.Diesel.TabIndex = 23;
            this.Diesel.Text = "Diesel";
            // 
            // Material_text
            // 
            this.Material_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Material_text.Location = new System.Drawing.Point(424, 161);
            this.Material_text.Name = "Material_text";
            this.Material_text.Size = new System.Drawing.Size(83, 20);
            this.Material_text.TabIndex = 12;
            // 
            // Advance_label
            // 
            this.Advance_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Advance_label.AutoSize = true;
            this.Advance_label.BackColor = System.Drawing.Color.Transparent;
            this.Advance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advance_label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Advance_label.Location = new System.Drawing.Point(629, 116);
            this.Advance_label.Name = "Advance_label";
            this.Advance_label.Size = new System.Drawing.Size(57, 13);
            this.Advance_label.TabIndex = 8;
            this.Advance_label.Text = "Advance";
            // 
            // dropdown_vehicle_trip
            // 
            this.dropdown_vehicle_trip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropdown_vehicle_trip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown_vehicle_trip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown_vehicle_trip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_vehicle_trip.FormattingEnabled = true;
            this.dropdown_vehicle_trip.Location = new System.Drawing.Point(145, 14);
            this.dropdown_vehicle_trip.MaxDropDownItems = 100;
            this.dropdown_vehicle_trip.Name = "dropdown_vehicle_trip";
            this.dropdown_vehicle_trip.Size = new System.Drawing.Size(83, 21);
            this.dropdown_vehicle_trip.TabIndex = 1;
            this.dropdown_vehicle_trip.SelectedIndexChanged += new System.EventHandler(this.dropdown_vehicle_trip_SelectedIndexChanged);
            // 
            // company_label
            // 
            this.company_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.company_label.AutoSize = true;
            this.company_label.BackColor = System.Drawing.Color.Transparent;
            this.company_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_label.ForeColor = System.Drawing.SystemColors.MenuText;
            this.company_label.Location = new System.Drawing.Point(360, 214);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(58, 13);
            this.company_label.TabIndex = 30;
            this.company_label.Text = "Company";
            // 
            // Material_label
            // 
            this.Material_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Material_label.AutoSize = true;
            this.Material_label.BackColor = System.Drawing.Color.Transparent;
            this.Material_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Material_label.Location = new System.Drawing.Point(366, 165);
            this.Material_label.Name = "Material_label";
            this.Material_label.Size = new System.Drawing.Size(52, 13);
            this.Material_label.TabIndex = 7;
            this.Material_label.Text = "Material";
            // 
            // pending_info_text
            // 
            this.pending_info_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pending_info_text.Location = new System.Drawing.Point(424, 111);
            this.pending_info_text.Name = "pending_info_text";
            this.pending_info_text.Size = new System.Drawing.Size(83, 23);
            this.pending_info_text.TabIndex = 32;
            this.pending_info_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driver_droplist
            // 
            this.driver_droplist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.driver_droplist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.driver_droplist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.driver_droplist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driver_droplist.FormattingEnabled = true;
            this.driver_droplist.Location = new System.Drawing.Point(145, 112);
            this.driver_droplist.MaxDropDownItems = 100;
            this.driver_droplist.Name = "driver_droplist";
            this.driver_droplist.Size = new System.Drawing.Size(83, 21);
            this.driver_droplist.TabIndex = 7;
            this.driver_droplist.SelectedIndexChanged += new System.EventHandler(this.driver_droplist_SelectedIndexChanged);
            // 
            // Quality_in_feeds_text
            // 
            this.Quality_in_feeds_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Quality_in_feeds_text.Location = new System.Drawing.Point(145, 210);
            this.Quality_in_feeds_text.Name = "Quality_in_feeds_text";
            this.Quality_in_feeds_text.Size = new System.Drawing.Size(83, 20);
            this.Quality_in_feeds_text.TabIndex = 14;
            // 
            // company_text
            // 
            this.company_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.company_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.company_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.company_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_text.FormattingEnabled = true;
            this.company_text.ItemHeight = 13;
            this.company_text.Location = new System.Drawing.Point(424, 210);
            this.company_text.MaxDropDownItems = 100;
            this.company_text.Name = "company_text";
            this.company_text.Size = new System.Drawing.Size(83, 21);
            this.company_text.TabIndex = 15;
            // 
            // date_pick
            // 
            this.date_pick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_pick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pick.Location = new System.Drawing.Point(692, 63);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(82, 20);
            this.date_pick.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(692, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 43);
            this.panel3.TabIndex = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.02837F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.97163F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Advance_text_company, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Advance_text_US, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(157, 43);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(90, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "(from us)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(90, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "(company)";
            // 
            // Advance_text_company
            // 
            this.Advance_text_company.Location = new System.Drawing.Point(3, 3);
            this.Advance_text_company.Name = "Advance_text_company";
            this.Advance_text_company.Size = new System.Drawing.Size(81, 20);
            this.Advance_text_company.TabIndex = 8;
            // 
            // Advance_text_US
            // 
            this.Advance_text_US.Location = new System.Drawing.Point(3, 24);
            this.Advance_text_US.Name = "Advance_text_US";
            this.Advance_text_US.Size = new System.Drawing.Size(81, 20);
            this.Advance_text_US.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.tableLayoutPanel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(145, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(143, 43);
            this.panel6.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.03704F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.96296F));
            this.tableLayoutPanel3.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.diesel_text_us, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Diesel_text, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(143, 43);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label15.Location = new System.Drawing.Point(84, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "(from us)";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label14.Location = new System.Drawing.Point(84, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "(company)";
            // 
            // diesel_text_us
            // 
            this.diesel_text_us.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diesel_text_us.Location = new System.Drawing.Point(3, 24);
            this.diesel_text_us.Name = "diesel_text_us";
            this.diesel_text_us.Size = new System.Drawing.Size(75, 20);
            this.diesel_text_us.TabIndex = 11;
            // 
            // Diesel_text
            // 
            this.Diesel_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Diesel_text.Location = new System.Drawing.Point(3, 3);
            this.Diesel_text.Name = "Diesel_text";
            this.Diesel_text.Size = new System.Drawing.Size(75, 20);
            this.Diesel_text.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Submit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 75);
            this.panel1.TabIndex = 1;
            // 
            // Submit_button
            // 
            this.Submit_button.BackColor = System.Drawing.Color.Transparent;
            this.Submit_button.Location = new System.Drawing.Point(623, 6);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(169, 23);
            this.Submit_button.TabIndex = 16;
            this.Submit_button.Text = "Submit";
            this.Submit_button.UseVisualStyleBackColor = false;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // Trip_details
            // 
            this.Trip_details.Controls.Add(this.TripDetails_panel);
            this.Trip_details.Controls.Add(this.TripDetails_Table);
            this.Trip_details.Location = new System.Drawing.Point(4, 25);
            this.Trip_details.Name = "Trip_details";
            this.Trip_details.Padding = new System.Windows.Forms.Padding(3);
            this.Trip_details.Size = new System.Drawing.Size(858, 377);
            this.Trip_details.TabIndex = 1;
            this.Trip_details.Text = "Trip_details";
            this.Trip_details.UseVisualStyleBackColor = true;
            // 
            // TripDetails_panel
            // 
            this.TripDetails_panel.Controls.Add(this.delete_label);
            this.TripDetails_panel.Controls.Add(this.Delete);
            this.TripDetails_panel.Controls.Add(this.vehicle_listview);
            this.TripDetails_panel.Controls.Add(this.label1);
            this.TripDetails_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TripDetails_panel.Location = new System.Drawing.Point(160, 3);
            this.TripDetails_panel.Name = "TripDetails_panel";
            this.TripDetails_panel.Size = new System.Drawing.Size(695, 371);
            this.TripDetails_panel.TabIndex = 1;
            // 
            // vehicle_listview
            // 
            this.vehicle_listview.FullRowSelect = true;
            this.vehicle_listview.HideSelection = false;
            this.vehicle_listview.Location = new System.Drawing.Point(3, 33);
            this.vehicle_listview.Name = "vehicle_listview";
            this.vehicle_listview.Size = new System.Drawing.Size(689, 287);
            this.vehicle_listview.TabIndex = 2;
            this.vehicle_listview.UseCompatibleStateImageBehavior = false;
            this.vehicle_listview.SelectedIndexChanged += new System.EventHandler(this.vehicle_listview_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details";
            // 
            // TripDetails_Table
            // 
            this.TripDetails_Table.ColumnCount = 2;
            this.TripDetails_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TripDetails_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TripDetails_Table.Controls.Add(this.to_date, 1, 2);
            this.TripDetails_Table.Controls.Add(this.Vehicle, 0, 0);
            this.TripDetails_Table.Controls.Add(this.To1_label, 0, 2);
            this.TripDetails_Table.Controls.Add(this.From1_label, 0, 1);
            this.TripDetails_Table.Controls.Add(this.dropdown_vehicle_details, 1, 0);
            this.TripDetails_Table.Controls.Add(this.from_date, 1, 1);
            this.TripDetails_Table.Controls.Add(this.Submit1_button, 1, 3);
            this.TripDetails_Table.Dock = System.Windows.Forms.DockStyle.Left;
            this.TripDetails_Table.Location = new System.Drawing.Point(3, 3);
            this.TripDetails_Table.Name = "TripDetails_Table";
            this.TripDetails_Table.RowCount = 4;
            this.TripDetails_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TripDetails_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TripDetails_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TripDetails_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TripDetails_Table.Size = new System.Drawing.Size(157, 371);
            this.TripDetails_Table.TabIndex = 0;
            // 
            // to_date
            // 
            this.to_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_date.Location = new System.Drawing.Point(57, 220);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(97, 20);
            this.to_date.TabIndex = 3;
            // 
            // Vehicle
            // 
            this.Vehicle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Vehicle.AutoSize = true;
            this.Vehicle.Location = new System.Drawing.Point(9, 39);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(42, 13);
            this.Vehicle.TabIndex = 0;
            this.Vehicle.Text = "Vehicle";
            // 
            // To1_label
            // 
            this.To1_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.To1_label.AutoSize = true;
            this.To1_label.Location = new System.Drawing.Point(31, 223);
            this.To1_label.Name = "To1_label";
            this.To1_label.Size = new System.Drawing.Size(20, 13);
            this.To1_label.TabIndex = 2;
            this.To1_label.Text = "To";
            // 
            // From1_label
            // 
            this.From1_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.From1_label.AutoSize = true;
            this.From1_label.Location = new System.Drawing.Point(21, 131);
            this.From1_label.Name = "From1_label";
            this.From1_label.Size = new System.Drawing.Size(30, 13);
            this.From1_label.TabIndex = 1;
            this.From1_label.Text = "From";
            // 
            // Submit1_button
            // 
            this.Submit1_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Submit1_button.Location = new System.Drawing.Point(57, 312);
            this.Submit1_button.Name = "Submit1_button";
            this.Submit1_button.Size = new System.Drawing.Size(91, 23);
            this.Submit1_button.TabIndex = 4;
            this.Submit1_button.Text = "Submit";
            this.Submit1_button.UseVisualStyleBackColor = true;
            this.Submit1_button.Click += new System.EventHandler(this.Submit1_button_Click);
            // 
            // dropdown_vehicle_details
            // 
            this.dropdown_vehicle_details.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropdown_vehicle_details.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_vehicle_details.FormattingEnabled = true;
            this.dropdown_vehicle_details.Location = new System.Drawing.Point(57, 35);
            this.dropdown_vehicle_details.MaxDropDownItems = 100;
            this.dropdown_vehicle_details.Name = "dropdown_vehicle_details";
            this.dropdown_vehicle_details.Size = new System.Drawing.Size(91, 21);
            this.dropdown_vehicle_details.TabIndex = 1;
            // 
            // from_date
            // 
            this.from_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.from_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_date.Location = new System.Drawing.Point(57, 128);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(97, 20);
            this.from_date.TabIndex = 2;
            // 
            // Total
            // 
            this.Total.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Total.BackgroundImage")));
            this.Total.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Total.Controls.Add(this.panel5);
            this.Total.Controls.Add(this.label7);
            this.Total.Controls.Add(this.panel4);
            this.Total.Location = new System.Drawing.Point(4, 25);
            this.Total.Name = "Total";
            this.Total.Padding = new System.Windows.Forms.Padding(3);
            this.Total.Size = new System.Drawing.Size(858, 326);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Fine_money);
            this.panel5.Controls.Add(this.petrol_money);
            this.panel5.Controls.Add(this.company_money);
            this.panel5.Controls.Add(this.Driver_money);
            this.panel5.Controls.Add(this.Profit_money);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(213, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 238);
            this.panel5.TabIndex = 3;
            // 
            // Fine_money
            // 
            this.Fine_money.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Fine_money.BackColor = System.Drawing.Color.Silver;
            this.Fine_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fine_money.Location = new System.Drawing.Point(249, 110);
            this.Fine_money.Name = "Fine_money";
            this.Fine_money.Size = new System.Drawing.Size(69, 20);
            this.Fine_money.TabIndex = 17;
            // 
            // petrol_money
            // 
            this.petrol_money.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.petrol_money.BackColor = System.Drawing.Color.Silver;
            this.petrol_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrol_money.Location = new System.Drawing.Point(249, 58);
            this.petrol_money.Name = "petrol_money";
            this.petrol_money.Size = new System.Drawing.Size(69, 20);
            this.petrol_money.TabIndex = 16;
            // 
            // company_money
            // 
            this.company_money.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.company_money.BackColor = System.Drawing.Color.Silver;
            this.company_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_money.Location = new System.Drawing.Point(85, 50);
            this.company_money.Name = "company_money";
            this.company_money.Size = new System.Drawing.Size(69, 20);
            this.company_money.TabIndex = 15;
            // 
            // Driver_money
            // 
            this.Driver_money.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_money.BackColor = System.Drawing.Color.Silver;
            this.Driver_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_money.Location = new System.Drawing.Point(85, 110);
            this.Driver_money.Name = "Driver_money";
            this.Driver_money.Size = new System.Drawing.Size(69, 20);
            this.Driver_money.TabIndex = 14;
            // 
            // Profit_money
            // 
            this.Profit_money.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Profit_money.BackColor = System.Drawing.Color.Silver;
            this.Profit_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit_money.Location = new System.Drawing.Point(184, 188);
            this.Profit_money.Name = "Profit_money";
            this.Profit_money.Size = new System.Drawing.Size(69, 20);
            this.Profit_money.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(104, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Profit :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Petrol";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Police/fine";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "from company";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total Money";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Driver charge";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Overview of the profits";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Overview_submit);
            this.panel4.Controls.Add(this.overview_to_date);
            this.panel4.Controls.Add(this.overview_from_date);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(17, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 238);
            this.panel4.TabIndex = 0;
            // 
            // Overview_submit
            // 
            this.Overview_submit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Overview_submit.Location = new System.Drawing.Point(50, 164);
            this.Overview_submit.Name = "Overview_submit";
            this.Overview_submit.Size = new System.Drawing.Size(91, 23);
            this.Overview_submit.TabIndex = 3;
            this.Overview_submit.Text = "Submit";
            this.Overview_submit.UseVisualStyleBackColor = true;
            this.Overview_submit.Click += new System.EventHandler(this.Overview_submit_Click);
            // 
            // overview_to_date
            // 
            this.overview_to_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.overview_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.overview_to_date.Location = new System.Drawing.Point(56, 115);
            this.overview_to_date.Name = "overview_to_date";
            this.overview_to_date.Size = new System.Drawing.Size(85, 20);
            this.overview_to_date.TabIndex = 2;
            // 
            // overview_from_date
            // 
            this.overview_from_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.overview_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.overview_from_date.Location = new System.Drawing.Point(56, 76);
            this.overview_from_date.Name = "overview_from_date";
            this.overview_from_date.Size = new System.Drawing.Size(85, 20);
            this.overview_from_date.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "From";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select the dates";
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delete.Location = new System.Drawing.Point(369, 326);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(91, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // delete_label
            // 
            this.delete_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delete_label.AutoSize = true;
            this.delete_label.Location = new System.Drawing.Point(466, 331);
            this.delete_label.Name = "delete_label";
            this.delete_label.Size = new System.Drawing.Size(193, 13);
            this.delete_label.TabIndex = 6;
            this.delete_label.Text = "(press to delete the selected trip details)";
            this.delete_label.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Home_tab);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(866, 406);
            this.Home_tab.ResumeLayout(false);
            this.Trip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Trip_details.ResumeLayout(false);
            this.TripDetails_panel.ResumeLayout(false);
            this.TripDetails_panel.PerformLayout();
            this.TripDetails_Table.ResumeLayout(false);
            this.TripDetails_Table.PerformLayout();
            this.Total.ResumeLayout(false);
            this.Total.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Home_tab;
        private System.Windows.Forms.TabPage Trip;
        private System.Windows.Forms.TabPage Trip_details;
        private System.Windows.Forms.TabPage Total;
        private System.Windows.Forms.Panel TripDetails_panel;
        private System.Windows.Forms.TableLayoutPanel TripDetails_Table;
        private System.Windows.Forms.Label Vehicle;
        private System.Windows.Forms.Label To1_label;
        private System.Windows.Forms.Label From1_label;
        private System.Windows.Forms.Button Submit1_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label vehicle_label;
        private System.Windows.Forms.Label Pending_label;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.TextBox From_text;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.TextBox To_text;
        private System.Windows.Forms.Label KM_label;
        private System.Windows.Forms.TextBox KM_text;
        private System.Windows.Forms.Label Remarks_label;
        private System.Windows.Forms.TextBox Remarks_text;
        private System.Windows.Forms.TextBox Cost_text;
        private System.Windows.Forms.Label Cost_label;
        private System.Windows.Forms.Label Driver_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.TextBox Advance_text_company;
        private System.Windows.Forms.Label Diesel;
        private System.Windows.Forms.TextBox Diesel_text;
        private System.Windows.Forms.Label Material_label;
        private System.Windows.Forms.TextBox Material_text;
        private System.Windows.Forms.Label Advance_label;
        private System.Windows.Forms.ComboBox dropdown_vehicle_trip;
        private System.Windows.Forms.ComboBox dropdown_vehicle_details;
        private System.Windows.Forms.Label Quality_in_feeds_label;
        private System.Windows.Forms.TextBox Quality_in_feeds_text;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker to_date;
        private System.Windows.Forms.DateTimePicker from_date;
        private System.Windows.Forms.ListView vehicle_listview;
        private System.Windows.Forms.Label pending_info_text;
        private System.Windows.Forms.ComboBox driver_droplist;
        private System.Windows.Forms.ComboBox company_text;
        private System.Windows.Forms.DateTimePicker date_pick;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Advance_text_US;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Overview_submit;
        private System.Windows.Forms.DateTimePicker overview_to_date;
        private System.Windows.Forms.DateTimePicker overview_from_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Fine_money;
        private System.Windows.Forms.Label petrol_money;
        private System.Windows.Forms.Label company_money;
        private System.Windows.Forms.Label Driver_money;
        private System.Windows.Forms.Label Profit_money;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox diesel_text_us;
        private System.Windows.Forms.Label delete_label;
        private System.Windows.Forms.Button Delete;
    }
}
