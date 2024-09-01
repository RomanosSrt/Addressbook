using System.Windows.Forms;

namespace AddressBook
{
    partial class ShowContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowContact));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.birthdatelabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grouplabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Address Book";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 723);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 199);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.ImageLocation = "Images\\logout.png";
            this.pictureBox4.Location = new System.Drawing.Point(364, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.toolTip4.SetToolTip(this.pictureBox4, "Exit");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "Images\\trash-can.png";
            this.pictureBox2.Location = new System.Drawing.Point(161, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Click to erase contact information");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.namelabel.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(51, 232);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(408, 32);
            this.namelabel.TabIndex = 6;
            this.namelabel.Text = "Some big text for setting this centered";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip2.SetToolTip(this.namelabel, "Doubleclick to change");
            this.namelabel.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.birthdatelabel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.emaillabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addresslabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.grouplabel);
            this.panel2.Controls.Add(this.phonelabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.namelabel);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.PhoneTextBox);
            this.panel2.Controls.Add(this.AddressTextBox);
            this.panel2.Controls.Add(this.EmailTextBox);
            this.panel2.Controls.Add(this.GroupComboBox);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(36, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 583);
            this.panel2.TabIndex = 8;
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
            this.toolTip3.SetToolTip(this.pictureBox3, "Save");
            this.pictureBox3.Visible = false;
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
            // birthdatelabel
            // 
            this.birthdatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdatelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthdatelabel.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.birthdatelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.birthdatelabel.Location = new System.Drawing.Point(64, 533);
            this.birthdatelabel.Name = "birthdatelabel";
            this.birthdatelabel.Size = new System.Drawing.Size(387, 29);
            this.birthdatelabel.TabIndex = 17;
            this.birthdatelabel.Text = "Some big text for setting this centered";
            this.birthdatelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip2.SetToolTip(this.birthdatelabel, "Doubleclick to change");
            this.birthdatelabel.DoubleClick += new System.EventHandler(this.birthdatelabel_DoubleClick);
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
            // emaillabel
            // 
            this.emaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emaillabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emaillabel.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.emaillabel.ForeColor = System.Drawing.SystemColors.Control;
            this.emaillabel.Location = new System.Drawing.Point(59, 463);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(387, 29);
            this.emaillabel.TabIndex = 15;
            this.emaillabel.Text = "Some big text for setting this centered";
            this.emaillabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip2.SetToolTip(this.emaillabel, "Doubleclick to change");
            this.emaillabel.DoubleClick += new System.EventHandler(this.emaillabel_DoubleClick);
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
            // addresslabel
            // 
            this.addresslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addresslabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addresslabel.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.addresslabel.ForeColor = System.Drawing.SystemColors.Control;
            this.addresslabel.Location = new System.Drawing.Point(64, 386);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(387, 29);
            this.addresslabel.TabIndex = 13;
            this.addresslabel.Text = "Some big text for setting this centered";
            this.addresslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip2.SetToolTip(this.addresslabel, "Doubleclick to change");
            this.addresslabel.DoubleClick += new System.EventHandler(this.addresslabel_DoubleClick);
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
            // grouplabel
            // 
            this.grouplabel.AutoSize = true;
            this.grouplabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grouplabel.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.grouplabel.ForeColor = System.Drawing.SystemColors.Control;
            this.grouplabel.Location = new System.Drawing.Point(12, 13);
            this.grouplabel.Name = "grouplabel";
            this.grouplabel.Size = new System.Drawing.Size(70, 29);
            this.grouplabel.TabIndex = 11;
            this.grouplabel.Text = "label7";
            this.toolTip2.SetToolTip(this.grouplabel, "Doubleclick to change");
            this.grouplabel.DoubleClick += new System.EventHandler(this.grouplabel_DoubleClick);
            // 
            // phonelabel
            // 
            this.phonelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phonelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phonelabel.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.phonelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.phonelabel.Location = new System.Drawing.Point(64, 310);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(387, 29);
            this.phonelabel.TabIndex = 8;
            this.phonelabel.Text = "Some big text for setting this centered";
            this.phonelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip2.SetToolTip(this.phonelabel, "Doubleclick to change");
            this.phonelabel.DoubleClick += new System.EventHandler(this.phonelabel_DoubleClick);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.NameTextBox.Location = new System.Drawing.Point(126, 232);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(259, 32);
            this.NameTextBox.TabIndex = 19;
            this.NameTextBox.Text = "";
            this.NameTextBox.Visible = false;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneTextBox.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.PhoneTextBox.Location = new System.Drawing.Point(126, 310);
            this.PhoneTextBox.MaxLength = 50;
            this.PhoneTextBox.Multiline = false;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(259, 29);
            this.PhoneTextBox.TabIndex = 21;
            this.PhoneTextBox.Text = "";
            this.PhoneTextBox.Visible = false;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddressTextBox.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.AddressTextBox.Location = new System.Drawing.Point(126, 386);
            this.AddressTextBox.MaxLength = 50;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(259, 29);
            this.AddressTextBox.TabIndex = 22;
            this.AddressTextBox.Text = "";
            this.AddressTextBox.Visible = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailTextBox.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.EmailTextBox.Location = new System.Drawing.Point(126, 463);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(259, 29);
            this.EmailTextBox.TabIndex = 23;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.Visible = false;
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
            this.GroupComboBox.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 533);
            this.dateTimePicker1.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 32);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Visible = false;
            // 
            // ShowContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(582, 953);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Contact";
            this.Load += new System.EventHandler(this.ShowContact_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label grouplabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label birthdatelabel;
        private PictureBox pictureBox2;
        private ToolTip toolTip1;
        private RichTextBox NameTextBox;
        private PictureBox pictureBox3;
        private RichTextBox PhoneTextBox;
        private RichTextBox AddressTextBox;
        private RichTextBox EmailTextBox;
        private ComboBox GroupComboBox;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox4;
        private ToolTip toolTip4;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
    }
}