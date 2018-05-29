namespace MyTaxi
{
    partial class database
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backup_location = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Restore = new System.Windows.Forms.Button();
            this.Browse_restore = new System.Windows.Forms.Button();
            this.restore_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backup);
            this.groupBox1.Controls.Add(this.Browse);
            this.groupBox1.Controls.Add(this.backup_location);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // backup_location
            // 
            this.backup_location.Location = new System.Drawing.Point(97, 39);
            this.backup_location.Name = "backup_location";
            this.backup_location.ReadOnly = true;
            this.backup_location.Size = new System.Drawing.Size(220, 20);
            this.backup_location.TabIndex = 1;
            this.backup_location.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(359, 37);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(359, 79);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(75, 23);
            this.backup.TabIndex = 3;
            this.backup.Text = "Backup";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Restore);
            this.groupBox2.Controls.Add(this.Browse_restore);
            this.groupBox2.Controls.Add(this.restore_location);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Restore";
            // 
            // Restore
            // 
            this.Restore.Location = new System.Drawing.Point(359, 79);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(75, 23);
            this.Restore.TabIndex = 3;
            this.Restore.Text = "Restore";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Browse_restore
            // 
            this.Browse_restore.Location = new System.Drawing.Point(359, 37);
            this.Browse_restore.Name = "Browse_restore";
            this.Browse_restore.Size = new System.Drawing.Size(75, 23);
            this.Browse_restore.TabIndex = 2;
            this.Browse_restore.Text = "Browse";
            this.Browse_restore.UseVisualStyleBackColor = true;
            this.Browse_restore.Click += new System.EventHandler(this.Browse_restore_Click);
            // 
            // restore_location
            // 
            this.restore_location.Location = new System.Drawing.Point(97, 39);
            this.restore_location.Name = "restore_location";
            this.restore_location.ReadOnly = true;
            this.restore_location.Size = new System.Drawing.Size(220, 20);
            this.restore_location.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            // 
            // database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "database";
            this.Size = new System.Drawing.Size(729, 365);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox backup_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Restore;
        private System.Windows.Forms.Button Browse_restore;
        private System.Windows.Forms.TextBox restore_location;
        private System.Windows.Forms.Label label2;
    }
}
