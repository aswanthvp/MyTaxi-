namespace MyTaxi
{
    partial class Driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver));
            this.Driver_tab = new System.Windows.Forms.TabControl();
            this.DoubleBuffered = true;
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.driver_trip_list = new System.Windows.Forms.ListView();
            this.Details_trip_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.from_date = new System.Windows.Forms.DateTimePicker();
            this.from_label = new System.Windows.Forms.Label();
            this.to_label = new System.Windows.Forms.Label();
            this.to_date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.date_for_payment = new System.Windows.Forms.DateTimePicker();
            this.dropdown_payment_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Driver_show_label = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.payment_submit = new System.Windows.Forms.Button();
            this.Pay_label_details = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outstanding_info = new System.Windows.Forms.Label();
            this.Total_info = new System.Windows.Forms.Label();
            this.pending_info = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reduce_button = new System.Windows.Forms.Button();
            this.Details_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.driver_droplist = new System.Windows.Forms.ComboBox();
            this.Driver_label = new System.Windows.Forms.Label();
            this.Submit_driver = new System.Windows.Forms.Button();
            this.Driver_add = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Driver_drop = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.driver_pay_listview = new System.Windows.Forms.ListView();
            this.Driver_payment_submit = new System.Windows.Forms.Button();
            this.trip_payment = new System.Windows.Forms.CheckBox();
            this.to_date_pay = new System.Windows.Forms.DateTimePicker();
            this.from_date_pay = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Submit_driver_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.Driver_text_add = new System.Windows.Forms.TextBox();
            this.Driver_tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Driver_add.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Driver_tab
            // 
            this.Driver_tab.Controls.Add(this.tabPage2);
            this.Driver_tab.Controls.Add(this.Driver_add);
            this.Driver_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Driver_tab.Location = new System.Drawing.Point(0, 0);
            this.Driver_tab.Name = "Driver_tab";
            this.Driver_tab.SelectedIndex = 0;
            this.Driver_tab.Size = new System.Drawing.Size(825, 352);
            this.Driver_tab.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Driver";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.driver_trip_list);
            this.panel4.Controls.Add(this.Details_trip_button);
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(469, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 273);
            this.panel4.TabIndex = 4;
            // 
            // driver_trip_list
            // 
            this.driver_trip_list.Location = new System.Drawing.Point(3, 89);
            this.driver_trip_list.Name = "driver_trip_list";
            this.driver_trip_list.Size = new System.Drawing.Size(333, 179);
            this.driver_trip_list.TabIndex = 11;
            this.driver_trip_list.UseCompatibleStateImageBehavior = false;
            // 
            // Details_trip_button
            // 
            this.Details_trip_button.Location = new System.Drawing.Point(185, 42);
            this.Details_trip_button.Name = "Details_trip_button";
            this.Details_trip_button.Size = new System.Drawing.Size(75, 23);
            this.Details_trip_button.TabIndex = 10;
            this.Details_trip_button.Text = "Submit";
            this.Details_trip_button.UseVisualStyleBackColor = true;
            this.Details_trip_button.Click += new System.EventHandler(this.Details_trip_button_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.from_date, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.from_label, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.to_label, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.to_date, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(176, 55);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // from_date
            // 
            this.from_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.from_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_date.Location = new System.Drawing.Point(91, 3);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(82, 20);
            this.from_date.TabIndex = 8;
            // 
            // from_label
            // 
            this.from_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.from_label.AutoSize = true;
            this.from_label.Location = new System.Drawing.Point(29, 7);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(30, 13);
            this.from_label.TabIndex = 5;
            this.from_label.Text = "From";
            // 
            // to_label
            // 
            this.to_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(34, 34);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(20, 13);
            this.to_label.TabIndex = 4;
            this.to_label.Text = "To";
            // 
            // to_date
            // 
            this.to_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_date.Location = new System.Drawing.Point(91, 31);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(82, 20);
            this.to_date.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Details of the driven ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.Pay_label_details);
            this.panel3.Location = new System.Drawing.Point(6, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 185);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.date_for_payment, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.dropdown_payment_type, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Driver_show_label, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.amount, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.payment_submit, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(139, 144);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // date_for_payment
            // 
            this.date_for_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_for_payment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_for_payment.Location = new System.Drawing.Point(3, 116);
            this.date_for_payment.Name = "date_for_payment";
            this.date_for_payment.Size = new System.Drawing.Size(63, 20);
            this.date_for_payment.TabIndex = 5;
            // 
            // dropdown_payment_type
            // 
            this.dropdown_payment_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropdown_payment_type.DisplayMember = "Advance";
            this.dropdown_payment_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_payment_type.FormattingEnabled = true;
            this.dropdown_payment_type.Items.AddRange(new object[] {
            "Payment",
            "Advance"});
            this.dropdown_payment_type.Location = new System.Drawing.Point(72, 43);
            this.dropdown_payment_type.MaxDropDownItems = 100;
            this.dropdown_payment_type.Name = "dropdown_payment_type";
            this.dropdown_payment_type.Size = new System.Drawing.Size(64, 21);
            this.dropdown_payment_type.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payment type";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // Driver_show_label
            // 
            this.Driver_show_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Driver_show_label.BackColor = System.Drawing.Color.White;
            this.Driver_show_label.Enabled = false;
            this.Driver_show_label.Location = new System.Drawing.Point(72, 11);
            this.Driver_show_label.Name = "Driver_show_label";
            this.Driver_show_label.Size = new System.Drawing.Size(64, 13);
            this.Driver_show_label.TabIndex = 4;
            this.Driver_show_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amount
            // 
            this.amount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amount.Location = new System.Drawing.Point(72, 80);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(64, 20);
            this.amount.TabIndex = 4;
            // 
            // payment_submit
            // 
            this.payment_submit.Location = new System.Drawing.Point(72, 111);
            this.payment_submit.Name = "payment_submit";
            this.payment_submit.Size = new System.Drawing.Size(64, 23);
            this.payment_submit.TabIndex = 6;
            this.payment_submit.Text = "Submit";
            this.payment_submit.UseVisualStyleBackColor = true;
            this.payment_submit.Click += new System.EventHandler(this.Payment_submit_Click);
            // 
            // Pay_label_details
            // 
            this.Pay_label_details.AutoSize = true;
            this.Pay_label_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_label_details.Location = new System.Drawing.Point(43, 14);
            this.Pay_label_details.Name = "Pay_label_details";
            this.Pay_label_details.Size = new System.Drawing.Size(62, 15);
            this.Pay_label_details.TabIndex = 0;
            this.Pay_label_details.Text = "Payment";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.Details_label);
            this.panel2.Location = new System.Drawing.Point(159, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 135);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.outstanding_info, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.Total_info, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pending_info, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.reduce_button, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 86);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 43);
            this.label10.TabIndex = 12;
            this.label10.Text = "Press to reduce the pending from Total";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pending";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // outstanding_info
            // 
            this.outstanding_info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outstanding_info.BackColor = System.Drawing.Color.White;
            this.outstanding_info.Location = new System.Drawing.Point(213, 58);
            this.outstanding_info.Name = "outstanding_info";
            this.outstanding_info.Size = new System.Drawing.Size(64, 13);
            this.outstanding_info.TabIndex = 8;
            this.outstanding_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Total_info
            // 
            this.Total_info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Total_info.BackColor = System.Drawing.Color.White;
            this.Total_info.Location = new System.Drawing.Point(213, 15);
            this.Total_info.Name = "Total_info";
            this.Total_info.Size = new System.Drawing.Size(64, 13);
            this.Total_info.TabIndex = 9;
            this.Total_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pending_info
            // 
            this.pending_info.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pending_info.BackColor = System.Drawing.Color.White;
            this.pending_info.Location = new System.Drawing.Point(73, 15);
            this.pending_info.Name = "pending_info";
            this.pending_info.Size = new System.Drawing.Size(64, 13);
            this.pending_info.TabIndex = 10;
            this.pending_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Outstanding Pay";
            // 
            // reduce_button
            // 
            this.reduce_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reduce_button.Location = new System.Drawing.Point(73, 53);
            this.reduce_button.Name = "reduce_button";
            this.reduce_button.Size = new System.Drawing.Size(64, 23);
            this.reduce_button.TabIndex = 7;
            this.reduce_button.Text = "Reduce";
            this.reduce_button.UseVisualStyleBackColor = true;
            this.reduce_button.Click += new System.EventHandler(this.reduce_button_Click);
            // 
            // Details_label
            // 
            this.Details_label.AutoSize = true;
            this.Details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details_label.Location = new System.Drawing.Point(3, 5);
            this.Details_label.Name = "Details_label";
            this.Details_label.Size = new System.Drawing.Size(257, 13);
            this.Details_label.TabIndex = 0;
            this.Details_label.Text = "Details of the money to be paid to the driver";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 67);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.driver_droplist, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Driver_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Submit_driver, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(145, 65);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // driver_droplist
            // 
            this.driver_droplist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.driver_droplist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driver_droplist.FormattingEnabled = true;
            this.driver_droplist.Location = new System.Drawing.Point(53, 5);
            this.driver_droplist.MaxDropDownItems = 100;
            this.driver_droplist.Name = "driver_droplist";
            this.driver_droplist.Size = new System.Drawing.Size(74, 21);
            this.driver_droplist.TabIndex = 1;
            // 
            // Driver_label
            // 
            this.Driver_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Driver_label.AutoSize = true;
            this.Driver_label.Location = new System.Drawing.Point(12, 9);
            this.Driver_label.Name = "Driver_label";
            this.Driver_label.Size = new System.Drawing.Size(35, 13);
            this.Driver_label.TabIndex = 0;
            this.Driver_label.Text = "Driver";
            // 
            // Submit_driver
            // 
            this.Submit_driver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Submit_driver.Location = new System.Drawing.Point(73, 35);
            this.Submit_driver.Name = "Submit_driver";
            this.Submit_driver.Size = new System.Drawing.Size(48, 23);
            this.Submit_driver.TabIndex = 2;
            this.Submit_driver.Text = "Submit";
            this.Submit_driver.UseVisualStyleBackColor = true;
            this.Submit_driver.Click += new System.EventHandler(this.Submit_driver_Click);
            // 
            // Driver_add
            // 
            this.Driver_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Driver_add.BackgroundImage")));
            this.Driver_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Driver_add.Controls.Add(this.panel5);
            this.Driver_add.Controls.Add(this.panel6);
            this.Driver_add.Location = new System.Drawing.Point(4, 22);
            this.Driver_add.Name = "Driver_add";
            this.Driver_add.Padding = new System.Windows.Forms.Padding(3);
            this.Driver_add.Size = new System.Drawing.Size(817, 326);
            this.Driver_add.TabIndex = 2;
            this.Driver_add.Text = "Add Driver";
            this.Driver_add.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Driver_drop);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.driver_pay_listview);
            this.panel5.Controls.Add(this.Driver_payment_submit);
            this.panel5.Controls.Add(this.trip_payment);
            this.panel5.Controls.Add(this.to_date_pay);
            this.panel5.Controls.Add(this.from_date_pay);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(193, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 243);
            this.panel5.TabIndex = 2;
            // 
            // Driver_drop
            // 
            this.Driver_drop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Driver_drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Driver_drop.FormattingEnabled = true;
            this.Driver_drop.Location = new System.Drawing.Point(47, 54);
            this.Driver_drop.MaxDropDownItems = 100;
            this.Driver_drop.Name = "Driver_drop";
            this.Driver_drop.Size = new System.Drawing.Size(79, 21);
            this.Driver_drop.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Driver";
            // 
            // driver_pay_listview
            // 
            this.driver_pay_listview.Location = new System.Drawing.Point(139, 57);
            this.driver_pay_listview.Name = "driver_pay_listview";
            this.driver_pay_listview.Size = new System.Drawing.Size(370, 171);
            this.driver_pay_listview.TabIndex = 9;
            this.driver_pay_listview.UseCompatibleStateImageBehavior = false;
            // 
            // Driver_payment_submit
            // 
            this.Driver_payment_submit.Location = new System.Drawing.Point(48, 175);
            this.Driver_payment_submit.Name = "Driver_payment_submit";
            this.Driver_payment_submit.Size = new System.Drawing.Size(75, 22);
            this.Driver_payment_submit.TabIndex = 7;
            this.Driver_payment_submit.Text = "Submit";
            this.Driver_payment_submit.UseVisualStyleBackColor = true;
            this.Driver_payment_submit.Click += new System.EventHandler(this.Driver_payment_submit_Click);
            // 
            // trip_payment
            // 
            this.trip_payment.AutoSize = true;
            this.trip_payment.Location = new System.Drawing.Point(46, 142);
            this.trip_payment.Name = "trip_payment";
            this.trip_payment.Size = new System.Drawing.Size(87, 17);
            this.trip_payment.TabIndex = 6;
            this.trip_payment.Text = "Trip payment";
            this.trip_payment.UseVisualStyleBackColor = true;
            // 
            // to_date_pay
            // 
            this.to_date_pay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_date_pay.Location = new System.Drawing.Point(48, 112);
            this.to_date_pay.Name = "to_date_pay";
            this.to_date_pay.Size = new System.Drawing.Size(78, 20);
            this.to_date_pay.TabIndex = 5;
            // 
            // from_date_pay
            // 
            this.from_date_pay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_date_pay.Location = new System.Drawing.Point(48, 86);
            this.from_date_pay.Name = "from_date_pay";
            this.from_date_pay.Size = new System.Drawing.Size(78, 20);
            this.from_date_pay.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "From";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Payment details";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Submit_driver_add);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.tableLayoutPanel6);
            this.panel6.Location = new System.Drawing.Point(6, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 198);
            this.panel6.TabIndex = 1;
            // 
            // Submit_driver_add
            // 
            this.Submit_driver_add.Location = new System.Drawing.Point(76, 153);
            this.Submit_driver_add.Name = "Submit_driver_add";
            this.Submit_driver_add.Size = new System.Drawing.Size(75, 23);
            this.Submit_driver_add.TabIndex = 2;
            this.Submit_driver_add.Text = "Submit";
            this.Submit_driver_add.UseVisualStyleBackColor = true;
            this.Submit_driver_add.Click += new System.EventHandler(this.Submit_driver_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "add Driver";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fill in the details to";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Driver_text_add, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(153, 45);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Driver";
            // 
            // Driver_text_add
            // 
            this.Driver_text_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Driver_text_add.Location = new System.Drawing.Point(79, 12);
            this.Driver_text_add.Name = "Driver_text_add";
            this.Driver_text_add.Size = new System.Drawing.Size(64, 20);
            this.Driver_text_add.TabIndex = 1;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Driver_tab);
            this.Name = "Driver";
            this.Size = new System.Drawing.Size(825, 352);
            this.Driver_tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Driver_add.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Driver_tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Driver_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label from_label;
        private System.Windows.Forms.Label Driver_label;
        private System.Windows.Forms.Button Submit_driver;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.DateTimePicker from_date;
        private System.Windows.Forms.DateTimePicker to_date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Details_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Driver_show_label;
        private System.Windows.Forms.Label Pay_label_details;
        private System.Windows.Forms.ComboBox dropdown_payment_type;
        private System.Windows.Forms.ComboBox driver_droplist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label outstanding_info;
        private System.Windows.Forms.Label Total_info;
        private System.Windows.Forms.Label pending_info;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button reduce_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView driver_trip_list;
        private System.Windows.Forms.Button Details_trip_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button payment_submit;
        private System.Windows.Forms.DateTimePicker date_for_payment;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Submit_driver_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Driver_text_add;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker from_date_pay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker to_date_pay;
        private System.Windows.Forms.ListView driver_pay_listview;
        private System.Windows.Forms.Button Driver_payment_submit;
        private System.Windows.Forms.CheckBox trip_payment;
        private System.Windows.Forms.ComboBox Driver_drop;
        private System.Windows.Forms.Label label15;
    }
}
