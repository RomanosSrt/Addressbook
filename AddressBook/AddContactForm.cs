using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AddressBook
{
    public partial class AddContact : Form
    {
        String connectionstring = "Data source=Addressbook.db;Version=3";
        SQLiteConnection connection;

        public AddContact()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            NameTextBox.SelectionAlignment = HorizontalAlignment.Center;
            PhoneTextBox.SelectionAlignment = HorizontalAlignment.Center;
            EmailTextBox.SelectionAlignment = HorizontalAlignment.Center;
            AddressTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                //Saving the data inserted in the text boxes
                connection = new SQLiteConnection(connectionstring);
                connection.Open();
                String updateSQL = "Insert into [Contacts] values(@Name,@Phone,@Address,@Email,@Birthdate,@Grouped,@Image)";
                SQLiteCommand command = new SQLiteCommand(updateSQL, connection);
                command.Parameters.AddWithValue("@Name", NameTextBox.Text);
                command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                command.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                command.Parameters.AddWithValue("@Birthdate", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@Grouped", GroupComboBox.Text);
                command.Parameters.AddWithValue("@Image", "Images\\contactDefault.png");
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                this.Close();
            } else
            {
                toolTip1.Active = true;
            }
        }

        private bool checkFields()
        {
            if (NameTextBox.Text.Length > 0 && PhoneTextBox.Text.Length > 0 && EmailTextBox.Text.Length > 0 && AddressTextBox.Text.Length > 0 )
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to leave without saving?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
