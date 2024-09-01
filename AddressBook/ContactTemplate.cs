using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    //Creating custom item for the contact list
    public partial class ContactTemplate : UserControl
    {
        public ContactTemplate()
        {
            InitializeComponent();
        }

        #region Properties

        [Category("Custom Props")]
        private string _name;
        public string _Name
        {
            get { return _name; }
            set {  _name = value; contactName.Text = value;  }
        }

        [Category("Custom Props")]
        private string _phone;
        public string _Phone
        {
            get { return _phone; }
            set { _phone = value; contactNumber.Text = value; }
        }



        [Category("Custom Props")]
        private string _image;
        public string _Image
        {
            get { return _image; }
            set { _image = value; contactPhoto.ImageLocation = value; }
        }

        #endregion

        private void ContactTemplate_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.Cursor = Cursors.Hand;
        }

        private void ContactTemplate_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.Cursor= Cursors.Default;
        }

        private void contactPhoto_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.Cursor=( Cursors.Hand);
        }

        private void contactNumber_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.Cursor = (Cursors.Hand);
        }

        private void ContactTemplate_DoubleClick(object sender, EventArgs e)
        {
            string clicked;
            clicked = contactNumber.Text;
            ShowContact showContact = new ShowContact(clicked);
            showContact.ShowDialog();
        }
    }
}