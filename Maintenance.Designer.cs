namespace MyTaxi
{
    partial class Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.Maintenance_tab = new System.Windows.Forms.TabControl();
            this.DoubleBuffered = true;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Table_maintenance = new System.Windows.Forms.TableLayoutPanel();
            this.Vehicle_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            this.Type_label = new System.Windows.Forms.Label();
            this.Type_combobox = new System.Windows.Forms.ComboBox();
            this.Cost_label = new System.Windows.Forms.Label();
            this.Cost_text = new System.Windows.Forms.TextBox();
            this.KM_label = new System.Windows.Forms.Label();
            this.KM_text = new System.Windows.Forms.TextBox();
            this.Submit_maintenance = new System.Windows.Forms.Button();
            this.dropdown_vehicle_list_maintenance = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expence_details_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Update_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delet_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cost_text_expence = new System.Windows.Forms.TextBox();
            this.type_text_expence = new System.Windows.Forms.TextBox();
            this.Cost_label_expence = new System.Windows.Forms.Label();
            this.Type_label_expence = new System.Windows.Forms.Label();
            this.vehicle_label_expence = new System.Windows.Forms.Label();
            this.date_label_expence = new System.Windows.Forms.Label();
            this.km_label_expence = new System.Windows.Forms.Label();
            this.vehicle_text_expence = new System.Windows.Forms.TextBox();
            this.km_text_expence = new System.Windows.Forms.TextBox();
            this.date_expence = new System.Windows.Forms.DateTimePicker();
            this.maintenance_search_listView = new System.Windows.Forms.ListView();
            this.Details_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.to_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.from_date = new System.Windows.Forms.DateTimePicker();
            this.Submit_maintenance_search_button = new System.Windows.Forms.Button();
            this.Maintenance_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Table_maintenance.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.expence_details_panel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Maintenance_tab
            // 
            this.Maintenance_tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Maintenance_tab.Controls.Add(this.tabPage1);
            this.Maintenance_tab.Controls.Add(this.tabPage2);
            this.Maintenance_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maintenance_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintenance_tab.Location = new System.Drawing.Point(0, 0);
            this.Maintenance_tab.Name = "Maintenance_tab";
            this.Maintenance_tab.SelectedIndex = 0;
            this.Maintenance_tab.Size = new System.Drawing.Size(866, 423);
            this.Maintenance_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Table_maintenance);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Maintenance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Table_maintenance
            // 
            this.Table_maintenance.BackColor = System.Drawing.Color.Transparent;
            this.Table_maintenance.ColumnCount = 5;
            this.Table_maintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Table_maintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Table_maintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_maintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Table_maintenance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.Table_maintenance.Controls.Add(this.Vehicle_label, 0, 0);
            this.Table_maintenance.Controls.Add(this.Date_label, 3, 0);
            this.Table_maintenance.Controls.Add(this.date_pick, 4, 0);
            this.Table_maintenance.Controls.Add(this.Type_label, 0, 1);
            this.Table_maintenance.Controls.Add(this.Type_combobox, 1, 1);
            this.Table_maintenance.Controls.Add(this.Cost_label, 0, 2);
            this.Table_maintenance.Controls.Add(this.Cost_text, 1, 2);
            this.Table_maintenance.Controls.Add(this.KM_label, 3, 1);
            this.Table_maintenance.Controls.Add(this.KM_text, 4, 1);
            this.Table_maintenance.Controls.Add(this.Submit_maintenance, 1, 3);
            this.Table_maintenance.Controls.Add(this.dropdown_vehicle_list_maintenance, 1, 0);
            this.Table_maintenance.Location = new System.Drawing.Point(3, 3);
            this.Table_maintenance.Name = "Table_maintenance";
            this.Table_maintenance.RowCount = 5;
            this.Table_maintenance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_maintenance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_maintenance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_maintenance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_maintenance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table_maintenance.Size = new System.Drawing.Size(624, 391);
            this.Table_maintenance.TabIndex = 0;
            // 
            // Vehicle_label
            // 
            this.Vehicle_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Vehicle_label.AutoSize = true;
            this.Vehicle_label.Location = new System.Drawing.Point(90, 31);
            this.Vehicle_label.Name = "Vehicle_label";
            this.Vehicle_label.Size = new System.Drawing.Size(47, 15);
            this.Vehicle_label.TabIndex = 0;
            this.Vehicle_label.Text = "Vehicle";
            // 
            // Date_label
            // 
            this.Date_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(446, 31);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(33, 15);
            this.Date_label.TabIndex = 1;
            this.Date_label.Text = "Date";
            // 
            // date_pick
            // 
            this.date_pick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_pick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pick.Location = new System.Drawing.Point(485, 28);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(122, 21);
            this.date_pick.TabIndex = 2;
            // 
            // Type_label
            // 
            this.Type_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(33, 109);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(104, 15);
            this.Type_label.TabIndex = 4;
            this.Type_label.Text = "Maintenance type";
            // 
            // Type_combobox
            // 
            this.Type_combobox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Type_combobox.FormattingEnabled = true;
            this.Type_combobox.Items.AddRange(new object[] {
            "Tyre",
            "Workshop",
            "Service",
            "GPS"});
            this.Type_combobox.Location = new System.Drawing.Point(143, 106);
            this.Type_combobox.Name = "Type_combobox";
            this.Type_combobox.Size = new System.Drawing.Size(121, 23);
            this.Type_combobox.TabIndex = 3;
            this.Type_combobox.SelectedIndexChanged += new System.EventHandler(this.type_tyre);
            this.Type_combobox.TextChanged += new System.EventHandler(this.type_text);
            // 
            // Cost_label
            // 
            this.Cost_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cost_label.AutoSize = true;
            this.Cost_label.Location = new System.Drawing.Point(106, 187);
            this.Cost_label.Name = "Cost_label";
            this.Cost_label.Size = new System.Drawing.Size(31, 15);
            this.Cost_label.TabIndex = 6;
            this.Cost_label.Text = "Cost";
            // 
            // Cost_text
            // 
            this.Cost_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cost_text.Location = new System.Drawing.Point(143, 184);
            this.Cost_text.Name = "Cost_text";
            this.Cost_text.Size = new System.Drawing.Size(121, 21);
            this.Cost_text.TabIndex = 5;
            // 
            // KM_label
            // 
            this.KM_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.KM_label.AutoSize = true;
            this.KM_label.Location = new System.Drawing.Point(453, 109);
            this.KM_label.Name = "KM_label";
            this.KM_label.Size = new System.Drawing.Size(26, 15);
            this.KM_label.TabIndex = 8;
            this.KM_label.Text = "KM";
            this.KM_label.Visible = false;
            // 
            // KM_text
            // 
            this.KM_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.KM_text.Location = new System.Drawing.Point(485, 106);
            this.KM_text.Name = "KM_text";
            this.KM_text.Size = new System.Drawing.Size(122, 21);
            this.KM_text.TabIndex = 4;
            this.KM_text.Visible = false;
            // 
            // Submit_maintenance
            // 
            this.Submit_maintenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submit_maintenance.Location = new System.Drawing.Point(172, 261);
            this.Submit_maintenance.Name = "Submit_maintenance";
            this.Submit_maintenance.Size = new System.Drawing.Size(75, 23);
            this.Submit_maintenance.TabIndex = 6;
            this.Submit_maintenance.Text = "Submit";
            this.Submit_maintenance.UseVisualStyleBackColor = true;
            this.Submit_maintenance.Click += new System.EventHandler(this.Submit_maintenance_Click);
            // 
            // dropdown_vehicle_list_maintenance
            // 
            this.dropdown_vehicle_list_maintenance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropdown_vehicle_list_maintenance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_vehicle_list_maintenance.FormattingEnabled = true;
            this.dropdown_vehicle_list_maintenance.Location = new System.Drawing.Point(143, 28);
            this.dropdown_vehicle_list_maintenance.MaxDropDownItems = 100;
            this.dropdown_vehicle_list_maintenance.Name = "dropdown_vehicle_list_maintenance";
            this.dropdown_vehicle_list_maintenance.Size = new System.Drawing.Size(121, 23);
            this.dropdown_vehicle_list_maintenance.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.expence_details_panel);
            this.tabPage2.Controls.Add(this.maintenance_search_listView);
            this.tabPage2.Controls.Add(this.Details_label);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Expence";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(170, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 396);
            this.panel2.TabIndex = 5;
            // 
            // expence_details_panel
            // 
            this.expence_details_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expence_details_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expence_details_panel.Controls.Add(this.tableLayoutPanel3);
            this.expence_details_panel.Controls.Add(this.tableLayoutPanel2);
            this.expence_details_panel.Location = new System.Drawing.Point(560, 56);
            this.expence_details_panel.Name = "expence_details_panel";
            this.expence_details_panel.Size = new System.Drawing.Size(278, 311);
            this.expence_details_panel.TabIndex = 4;
            this.expence_details_panel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.Update_button, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.Cancel_button, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Edit_button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Delet_button, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 271);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(276, 35);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Update_button
            // 
            this.Update_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update_button.Location = new System.Drawing.Point(210, 6);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(63, 23);
            this.Update_button.TabIndex = 10;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Visible = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_button.Location = new System.Drawing.Point(141, 6);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(63, 23);
            this.Cancel_button.TabIndex = 12;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Visible = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_button.Location = new System.Drawing.Point(3, 6);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(63, 23);
            this.Edit_button.TabIndex = 4;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delet_button
            // 
            this.Delet_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delet_button.Location = new System.Drawing.Point(72, 6);
            this.Delet_button.Name = "Delet_button";
            this.Delet_button.Size = new System.Drawing.Size(63, 23);
            this.Delet_button.TabIndex = 13;
            this.Delet_button.Text = "Delete";
            this.Delet_button.UseVisualStyleBackColor = true;
            this.Delet_button.Click += new System.EventHandler(this.Delet_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cost_text_expence, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.type_text_expence, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Cost_label_expence, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Type_label_expence, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.vehicle_label_expence, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.date_label_expence, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.km_label_expence, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.vehicle_text_expence, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.km_text_expence, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.date_expence, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 268);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cost_text_expence
            // 
            this.cost_text_expence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cost_text_expence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cost_text_expence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_text_expence.Location = new System.Drawing.Point(141, 125);
            this.cost_text_expence.Name = "cost_text_expence";
            this.cost_text_expence.ReadOnly = true;
            this.cost_text_expence.Size = new System.Drawing.Size(100, 14);
            this.cost_text_expence.TabIndex = 7;
            // 
            // type_text_expence
            // 
            this.type_text_expence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.type_text_expence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.type_text_expence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_text_expence.Location = new System.Drawing.Point(141, 72);
            this.type_text_expence.Name = "type_text_expence";
            this.type_text_expence.ReadOnly = true;
            this.type_text_expence.Size = new System.Drawing.Size(100, 14);
            this.type_text_expence.TabIndex = 6;
            // 
            // Cost_label_expence
            // 
            this.Cost_label_expence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cost_label_expence.AutoSize = true;
            this.Cost_label_expence.Location = new System.Drawing.Point(98, 125);
            this.Cost_label_expence.Name = "Cost_label_expence";
            this.Cost_label_expence.Size = new System.Drawing.Size(37, 15);
            this.Cost_label_expence.TabIndex = 4;
            this.Cost_label_expence.Text = "Cost :";
            // 
            // Type_label_expence
            // 
            this.Type_label_expence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Type_label_expence.AutoSize = true;
            this.Type_label_expence.Location = new System.Drawing.Point(96, 72);
            this.Type_label_expence.Name = "Type_label_expence";
            this.Type_label_expence.Size = new System.Drawing.Size(39, 15);
            this.Type_label_expence.TabIndex = 2;
            this.Type_label_expence.Text = "Type :";
            // 
            // vehicle_label_expence
            // 
            this.vehicle_label_expence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vehicle_label_expence.AutoSize = true;
            this.vehicle_label_expence.Location = new System.Drawing.Point(82, 19);
            this.vehicle_label_expence.Name = "vehicle_label_expence";
            this.vehicle_label_expence.Size = new System.Drawing.Size(53, 15);
            this.vehicle_label_expence.TabIndex = 0;
            this.vehicle_label_expence.Text = "Vehicle :";
            // 
            // date_label_expence
            // 
            this.date_label_expence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.date_label_expence.AutoSize = true;
            this.date_label_expence.Location = new System.Drawing.Point(96, 178);
            this.date_label_expence.Name = "date_label_expence";
            this.date_label_expence.Size = new System.Drawing.Size(39, 15);
            this.date_label_expence.TabIndex = 3;
            this.date_label_expence.Text = "Date :";
            // 
            // km_label_expence
            // 
            this.km_label_expence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.km_label_expence.AutoSize = true;
            this.km_label_expence.Location = new System.Drawing.Point(103, 232);
            this.km_label_expence.Name = "km_label_expence";
            this.km_label_expence.Size = new System.Drawing.Size(32, 15);
            this.km_label_expence.TabIndex = 1;
            this.km_label_expence.Text = "KM :";
            // 
            // vehicle_text_expence
            // 
            this.vehicle_text_expence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vehicle_text_expence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehicle_text_expence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_text_expence.Location = new System.Drawing.Point(141, 19);
            this.vehicle_text_expence.Name = "vehicle_text_expence";
            this.vehicle_text_expence.ReadOnly = true;
            this.vehicle_text_expence.Size = new System.Drawing.Size(100, 14);
            this.vehicle_text_expence.TabIndex = 5;
            // 
            // km_text_expence
            // 
            this.km_text_expence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.km_text_expence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.km_text_expence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.km_text_expence.Location = new System.Drawing.Point(141, 233);
            this.km_text_expence.Name = "km_text_expence";
            this.km_text_expence.ReadOnly = true;
            this.km_text_expence.Size = new System.Drawing.Size(100, 14);
            this.km_text_expence.TabIndex = 9;
            // 
            // date_expence
            // 
            this.date_expence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_expence.Enabled = false;
            this.date_expence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_expence.Location = new System.Drawing.Point(141, 175);
            this.date_expence.Name = "date_expence";
            this.date_expence.Size = new System.Drawing.Size(100, 21);
            this.date_expence.TabIndex = 8;
            // 
            // maintenance_search_listView
            // 
            this.maintenance_search_listView.AllowColumnReorder = true;
            this.maintenance_search_listView.FullRowSelect = true;
            this.maintenance_search_listView.Location = new System.Drawing.Point(186, 56);
            this.maintenance_search_listView.MultiSelect = false;
            this.maintenance_search_listView.Name = "maintenance_search_listView";
            this.maintenance_search_listView.Size = new System.Drawing.Size(355, 313);
            this.maintenance_search_listView.TabIndex = 3;
            this.maintenance_search_listView.UseCompatibleStateImageBehavior = false;
            this.maintenance_search_listView.SelectedIndexChanged += new System.EventHandler(this.maintenance_search_listView_SelectedIndexChanged);
            // 
            // Details_label
            // 
            this.Details_label.AutoSize = true;
            this.Details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details_label.Location = new System.Drawing.Point(325, 15);
            this.Details_label.Name = "Details_label";
            this.Details_label.Size = new System.Drawing.Size(65, 20);
            this.Details_label.TabIndex = 2;
            this.Details_label.Text = "Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 386);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select the date ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.to_date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.from_date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Submit_maintenance_search_button, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // to_date
            // 
            this.to_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.to_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_date.Location = new System.Drawing.Point(50, 106);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(105, 21);
            this.to_date.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // from_date
            // 
            this.from_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.from_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_date.Location = new System.Drawing.Point(50, 28);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(105, 21);
            this.from_date.TabIndex = 1;
            // 
            // Submit_maintenance_search_button
            // 
            this.Submit_maintenance_search_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submit_maintenance_search_button.Location = new System.Drawing.Point(65, 164);
            this.Submit_maintenance_search_button.Name = "Submit_maintenance_search_button";
            this.Submit_maintenance_search_button.Size = new System.Drawing.Size(75, 23);
            this.Submit_maintenance_search_button.TabIndex = 3;
            this.Submit_maintenance_search_button.Text = "Submit";
            this.Submit_maintenance_search_button.UseVisualStyleBackColor = true;
            this.Submit_maintenance_search_button.Click += new System.EventHandler(this.Submit_maintenance_search_button_Click);
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Maintenance_tab);
            this.Name = "Maintenance";
            this.Size = new System.Drawing.Size(866, 423);
            this.Maintenance_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Table_maintenance.ResumeLayout(false);
            this.Table_maintenance.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.expence_details_panel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Maintenance_tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel Table_maintenance;
        private System.Windows.Forms.Label Vehicle_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.DateTimePicker date_pick;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.ComboBox Type_combobox;
        private System.Windows.Forms.Label Cost_label;
        private System.Windows.Forms.TextBox Cost_text;
        private System.Windows.Forms.Label KM_label;
        private System.Windows.Forms.TextBox KM_text;
        private System.Windows.Forms.Button Submit_maintenance;
        private System.Windows.Forms.ComboBox dropdown_vehicle_list_maintenance;
        private System.Windows.Forms.Label Details_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker to_date;
        private System.Windows.Forms.DateTimePicker from_date;
        private System.Windows.Forms.Button Submit_maintenance_search_button;
        private System.Windows.Forms.ListView maintenance_search_listView;
        private System.Windows.Forms.Panel expence_details_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delet_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Cost_label_expence;
        private System.Windows.Forms.Label Type_label_expence;
        private System.Windows.Forms.Label vehicle_label_expence;
        private System.Windows.Forms.Label date_label_expence;
        private System.Windows.Forms.Label km_label_expence;
        private System.Windows.Forms.TextBox cost_text_expence;
        private System.Windows.Forms.TextBox type_text_expence;
        private System.Windows.Forms.TextBox vehicle_text_expence;
        private System.Windows.Forms.TextBox km_text_expence;
        private System.Windows.Forms.DateTimePicker date_expence;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}
