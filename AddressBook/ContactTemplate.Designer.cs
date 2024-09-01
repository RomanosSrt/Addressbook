using System.Drawing;
using System.Windows.Forms;

namespace AddressBook
{
    partial class ContactTemplate
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contactName = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.contactPhoto = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // contactName
            // 
            this.contactName.AutoSize = true;
            this.contactName.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactName.Location = new System.Drawing.Point(135, 28);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(0, 31);
            this.contactName.TabIndex = 1;
            this.contactName.MouseEnter += new System.EventHandler(this.contactNumber_MouseEnter);
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumber.Location = new System.Drawing.Point(136, 72);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(0, 27);
            this.contactNumber.TabIndex = 2;
            this.contactNumber.MouseEnter += new System.EventHandler(this.contactNumber_MouseEnter);
            // 
            // contactPhoto
            // 
            this.contactPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contactPhoto.Location = new System.Drawing.Point(14, 15);
            this.contactPhoto.Name = "contactPhoto";
            this.contactPhoto.Size = new System.Drawing.Size(96, 96);
            this.contactPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contactPhoto.TabIndex = 0;
            this.contactPhoto.TabStop = false;
            this.contactPhoto.MouseEnter += new System.EventHandler(this.contactPhoto_MouseEnter);
            // 
            // ContactTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.contactPhoto);
            this.Name = "ContactTemplate";
            this.Size = new System.Drawing.Size(428, 127);
            this.toolTip1.SetToolTip(this, "Doubleclick to view contact");
            this.DoubleClick += new System.EventHandler(this.ContactTemplate_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.ContactTemplate_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ContactTemplate_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.contactPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label contactName;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.PictureBox contactPhoto;
        private ToolTip toolTip1;
    }
}
