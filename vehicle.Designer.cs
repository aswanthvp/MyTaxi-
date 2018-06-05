namespace MyTaxi
{
    partial class vehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicle));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DoubleBuffered = true;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edit_panel = new System.Windows.Forms.Panel();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.showroom_place_text_edit = new System.Windows.Forms.TextBox();
            this.showroom_no_text_edit = new System.Windows.Forms.TextBox();
            this.cost_text_edit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.vehicle_text_edit = new System.Windows.Forms.TextBox();
            this.showroom_mail_text_edit = new System.Windows.Forms.TextBox();
            this.date_edit = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_vehicle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Place_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Vehicle_text = new System.Windows.Forms.TextBox();
            this.Cost_text = new System.Windows.Forms.TextBox();
            this.Number_text = new System.Windows.Forms.TextBox();
            this.Mail_text = new System.Windows.Forms.TextBox();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.edit_panel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.edit_panel);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edit_panel
            // 
            this.edit_panel.Controls.Add(this.Edit_button);
            this.edit_panel.Controls.Add(this.Cancel_button);
            this.edit_panel.Controls.Add(this.Update_button);
            this.edit_panel.Controls.Add(this.tableLayoutPanel3);
            this.edit_panel.Location = new System.Drawing.Point(241, 28);
            this.edit_panel.Name = "edit_panel";
            this.edit_panel.Size = new System.Drawing.Size(310, 340);
            this.edit_panel.TabIndex = 3;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(9, 310);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.TabIndex = 1;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Visible = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click_1);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(90, 311);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 8;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Visible = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click_1);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(199, 310);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 9;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Visible = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.47458F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.52542F));
            this.tableLayoutPanel3.Controls.Add(this.showroom_place_text_edit, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.showroom_no_text_edit, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cost_text_edit, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.vehicle_text_edit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.showroom_mail_text_edit, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.date_edit, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(295, 233);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // showroom_place_text_edit
            // 
            this.showroom_place_text_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.showroom_place_text_edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showroom_place_text_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showroom_place_text_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showroom_place_text_edit.Location = new System.Drawing.Point(146, 163);
            this.showroom_place_text_edit.Name = "showroom_place_text_edit";
            this.showroom_place_text_edit.ReadOnly = true;
            this.showroom_place_text_edit.Size = new System.Drawing.Size(139, 16);
            this.showroom_place_text_edit.TabIndex = 6;
            // 
            // showroom_no_text_edit
            // 
            this.showroom_no_text_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.showroom_no_text_edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showroom_no_text_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showroom_no_text_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showroom_no_text_edit.Location = new System.Drawing.Point(146, 125);
            this.showroom_no_text_edit.Name = "showroom_no_text_edit";
            this.showroom_no_text_edit.ReadOnly = true;
            this.showroom_no_text_edit.Size = new System.Drawing.Size(139, 16);
            this.showroom_no_text_edit.TabIndex = 5;
            // 
            // cost_text_edit
            // 
            this.cost_text_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cost_text_edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cost_text_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cost_text_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_text_edit.Location = new System.Drawing.Point(146, 49);
            this.cost_text_edit.Name = "cost_text_edit";
            this.cost_text_edit.ReadOnly = true;
            this.cost_text_edit.Size = new System.Drawing.Size(139, 16);
            this.cost_text_edit.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Showroom mail:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Showroom place:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Showroom no.:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Date:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Cost:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Vehicle no:";
            // 
            // vehicle_text_edit
            // 
            this.vehicle_text_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vehicle_text_edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vehicle_text_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehicle_text_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_text_edit.Location = new System.Drawing.Point(146, 11);
            this.vehicle_text_edit.Name = "vehicle_text_edit";
            this.vehicle_text_edit.ReadOnly = true;
            this.vehicle_text_edit.Size = new System.Drawing.Size(139, 16);
            this.vehicle_text_edit.TabIndex = 2;
            // 
            // showroom_mail_text_edit
            // 
            this.showroom_mail_text_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.showroom_mail_text_edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showroom_mail_text_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showroom_mail_text_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showroom_mail_text_edit.Location = new System.Drawing.Point(146, 204);
            this.showroom_mail_text_edit.Name = "showroom_mail_text_edit";
            this.showroom_mail_text_edit.ReadOnly = true;
            this.showroom_mail_text_edit.Size = new System.Drawing.Size(139, 16);
            this.showroom_mail_text_edit.TabIndex = 7;
            // 
            // date_edit
            // 
            this.date_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_edit.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.date_edit.Enabled = false;
            this.date_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_edit.Location = new System.Drawing.Point(146, 84);
            this.date_edit.Name = "date_edit";
            this.date_edit.Size = new System.Drawing.Size(139, 23);
            this.date_edit.TabIndex = 4;
            this.date_edit.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_vehicle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 408);
            this.panel1.TabIndex = 0;
            // 
            // listBox_vehicle
            // 
            this.listBox_vehicle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_vehicle.FormattingEnabled = true;
            this.listBox_vehicle.IntegralHeight = false;
            this.listBox_vehicle.ItemHeight = 25;
            this.listBox_vehicle.Location = new System.Drawing.Point(0, 25);
            this.listBox_vehicle.Name = "listBox_vehicle";
            this.listBox_vehicle.Size = new System.Drawing.Size(171, 386);
            this.listBox_vehicle.TabIndex = 1;
            this.listBox_vehicle.SelectedIndexChanged += new System.EventHandler(this.listBox_vehicle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(31, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.Submit);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add vehicle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(291, 213);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(128, 29);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.Place_text, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Vehicle_text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cost_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Number_text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Mail_text, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.date_pick, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Place_text
            // 
            this.Place_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Place_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Place_text.Location = new System.Drawing.Point(322, 72);
            this.Place_text.Name = "Place_text";
            this.Place_text.Size = new System.Drawing.Size(91, 20);
            this.Place_text.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle No.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Showroom no.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(231, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Showroom Place";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(231, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(231, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Showroom mail";
            // 
            // Vehicle_text
            // 
            this.Vehicle_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Vehicle_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Vehicle_text.Location = new System.Drawing.Point(94, 17);
            this.Vehicle_text.Name = "Vehicle_text";
            this.Vehicle_text.Size = new System.Drawing.Size(100, 20);
            this.Vehicle_text.TabIndex = 1;
            // 
            // Cost_text
            // 
            this.Cost_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cost_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cost_text.Location = new System.Drawing.Point(94, 72);
            this.Cost_text.Name = "Cost_text";
            this.Cost_text.Size = new System.Drawing.Size(100, 20);
            this.Cost_text.TabIndex = 3;
            // 
            // Number_text
            // 
            this.Number_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Number_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Number_text.Location = new System.Drawing.Point(94, 128);
            this.Number_text.Name = "Number_text";
            this.Number_text.Size = new System.Drawing.Size(100, 20);
            this.Number_text.TabIndex = 5;
            // 
            // Mail_text
            // 
            this.Mail_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Mail_text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mail_text.Location = new System.Drawing.Point(322, 128);
            this.Mail_text.Name = "Mail_text";
            this.Mail_text.Size = new System.Drawing.Size(91, 20);
            this.Mail_text.TabIndex = 6;
            // 
            // date_pick
            // 
            this.date_pick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_pick.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.date_pick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pick.Location = new System.Drawing.Point(322, 17);
            this.date_pick.MaxDate = new System.DateTime(2018, 7, 8, 22, 29, 16, 776);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(91, 20);
            this.date_pick.TabIndex = 2;
            // 
            // vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.tabControl1);
            this.Name = "vehicle";
            this.Size = new System.Drawing.Size(651, 440);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.edit_panel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Place_text;
        private System.Windows.Forms.TextBox Vehicle_text;
        private System.Windows.Forms.TextBox Cost_text;
        private System.Windows.Forms.TextBox Number_text;
        private System.Windows.Forms.TextBox Mail_text;
        private System.Windows.Forms.DateTimePicker date_pick;
        private System.Windows.Forms.ListBox listBox_vehicle;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Panel edit_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox showroom_place_text_edit;
        private System.Windows.Forms.TextBox showroom_no_text_edit;
        private System.Windows.Forms.TextBox cost_text_edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox vehicle_text_edit;
        private System.Windows.Forms.TextBox showroom_mail_text_edit;
        private System.Windows.Forms.DateTimePicker date_edit;
    }
}
