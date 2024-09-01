using System.Windows.Forms;

namespace AddressBook
{
    partial class AddContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameTextBox = new System.Windows.Forms.RichTextBox();
            this.PhoneTextBox = new System.Windows.Forms.RichTextBox();
            this.AddressTextBox = new System.Windows.Forms.RichTextBox();
            this.EmailTextBox = new System.Windows.Forms.RichTextBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Location = new System.Drawing.Point(-1, 723);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 199);
            this.panel1.TabIndex = 5;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.ImageLocation = "Images\\logout.png";
            this.Logout.Location = new System.Drawing.Point(258, 13);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(69, 69);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logout.TabIndex = 2;
            this.Logout.TabStop = false;
            this.toolTip8.SetToolTip(this.Logout, "Exit");
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Address Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.PhoneTextBox);
            this.panel2.Controls.Add(this.AddressTextBox);
            this.panel2.Controls.Add(this.EmailTextBox);
            this.panel2.Controls.Add(this.GroupComboBox);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(36, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 583);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(429, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Save");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(220, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Birthdate";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(232, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(224, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(199, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phone Number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "Images\\contactDefault.png";
            this.pictureBox1.Location = new System.Drawing.Point(165, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.NameTextBox.Location = new System.Drawing.Point(126, 232);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(259, 32);
            this.NameTextBox.TabIndex = 19;
            this.NameTextBox.Text = "Name";
            this.toolTip2.SetToolTip(this.NameTextBox, "Name");
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTextBox.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.PhoneTextBox.Location = new System.Drawing.Point(126, 310);
            this.PhoneTextBox.MaxLength = 50;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(259, 29);
            this.PhoneTextBox.TabIndex = 21;
            this.PhoneTextBox.Text = "Phone";
            this.toolTip3.SetToolTip(this.PhoneTextBox, "Phone");
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.AddressTextBox.Location = new System.Drawing.Point(126, 386);
            this.AddressTextBox.MaxLength = 50;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(259, 29);
            this.AddressTextBox.TabIndex = 22;
            this.AddressTextBox.Text = "Address";
            this.toolTip4.SetToolTip(this.AddressTextBox, "Address");
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.EmailTextBox.Location = new System.Drawing.Point(126, 463);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(259, 29);
            this.EmailTextBox.TabIndex = 23;
            this.EmailTextBox.Text = "Email";
            this.toolTip5.SetToolTip(this.EmailTextBox, "Email");
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Items.AddRange(new object[] {
            "Family",
            "Work",
            "Friend"});
            this.GroupComboBox.Location = new System.Drawing.Point(17, 13);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(121, 37);
            this.GroupComboBox.TabIndex = 24;
            this.toolTip7.SetToolTip(this.GroupComboBox, "Group");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 533);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 6, 8, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 32);
            this.dateTimePicker1.TabIndex = 25;
            this.toolTip6.SetToolTip(this.dateTimePicker1, "Birthdate");
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 8, 0, 0, 0, 0);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(582, 953);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox NameTextBox;
        private System.Windows.Forms.RichTextBox PhoneTextBox;
        private System.Windows.Forms.RichTextBox AddressTextBox;
        private System.Windows.Forms.RichTextBox EmailTextBox;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PictureBox Logout;
        private ToolTip toolTip8;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip7;
        private ToolTip toolTip6;
    }
}