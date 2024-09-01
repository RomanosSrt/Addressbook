using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Globalization;
using System.Xml.Linq;

namespace AddressBook
{
    public partial class ShowContact : Form
    {

        String connectionstring = "Data source=Addressbook.db;Version=3";
        SQLiteConnection connection;


        public ShowContact(string passed)
        {
            InitializeComponent();
            phonelabel.Text = passed;
            
        }

        private void ShowContact_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionstring);
            connection.Open();

            String showSQL = "Select * from [Contacts] where Phone=\"" + phonelabel.Text + "\"";
            SQLiteCommand command = new SQLiteCommand(showSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                //Check and fill the form with existing data
                fillForm(namelabel, reader.IsDBNull(0), reader.GetString(0));
                fillForm(addresslabel, reader.IsDBNull(2), reader.GetString(2));
                fillForm(grouplabel, reader.IsDBNull(5), reader.GetString(5));
                fillForm(emaillabel, reader.IsDBNull(3), reader.GetString(3));
                fillForm(birthdatelabel, reader.IsDBNull(4), reader.GetString(4));
                
                if (!reader.IsDBNull(6))
                {
                    pictureBox1.ImageLocation = @"" + reader.GetString(6);
                }
            
            }
            reader.Close();
            command.Dispose();
            connection.Close();

            this.Text = namelabel.Text;

        }
        
        private void fillForm(Label element, bool condition, string element1)
        {
            if (!condition) 
            {
                
                element.Text = element1;                
            } 
            else
            {
                element.Text = "-";
            }
        }


        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor= Cursors.Default;
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            namelabel.Visible = false;
            NameTextBox.SelectionAlignment = HorizontalAlignment.Center;
            NameTextBox.Text = namelabel.Text;
            NameTextBox.Visible = true;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Saving the data inserted in the text boxes
            connection.Open();
            String updateSQL = "Update [Contacts] set Phone=@phone, Name=@name, Address=@address, Email=@email, Birthdate=@birthdate, Grouped=@grouped where Phone=\"" + phonelabel.Text + "\"";
            SQLiteCommand command = new SQLiteCommand(updateSQL, connection);
            command.Parameters.AddWithValue("@name", isChanged(namelabel, NameTextBox));
            command.Parameters.AddWithValue("@phone", isChanged(phonelabel, PhoneTextBox));
            command.Parameters.AddWithValue("@address", isChanged(addresslabel, AddressTextBox));
            command.Parameters.AddWithValue("@email", isChanged(emaillabel, EmailTextBox));
            command.Parameters.AddWithValue("@birthdate", changedDate(birthdatelabel, dateTimePicker1));
            command.Parameters.AddWithValue("@grouped", changedComboBox(grouplabel, GroupComboBox));
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            this.Close();
        }

        private void phonelabel_DoubleClick(object sender, EventArgs e)
        {
            phonelabel.Visible = false;
            PhoneTextBox.SelectionAlignment = HorizontalAlignment.Center;
            PhoneTextBox.Text = phonelabel.Text;
            PhoneTextBox.Visible = true;
            pictureBox3.Visible = true;
        }

        private void addresslabel_DoubleClick(object sender, EventArgs e)
        {
            addresslabel.Visible = false;
            AddressTextBox.SelectionAlignment = HorizontalAlignment.Center;
            AddressTextBox.Text = addresslabel.Text;
            AddressTextBox.Visible = true;
            pictureBox3.Visible = true;
        }

        private void emaillabel_DoubleClick(object sender, EventArgs e)
        {
            emaillabel.Visible = false;
            EmailTextBox.SelectionAlignment = HorizontalAlignment.Center;
            EmailTextBox.Text = emaillabel.Text;
            EmailTextBox.Visible = true;
            pictureBox3.Visible = true;
        }

        private void grouplabel_DoubleClick(object sender, EventArgs e)
        {
            grouplabel.Visible = false;
            GroupComboBox.SelectedIndex = 2;
            GroupComboBox.Visible = true;
            pictureBox3.Visible = true;
        }

        private void birthdatelabel_DoubleClick(object sender, EventArgs e)
        {
            birthdatelabel.Visible = false;
            dateTimePicker1.Visible = true;
            pictureBox3.Visible = true;
            dateTimePicker1.Value = DateTime.Parse(birthdatelabel.Text);
        }

        private string isChanged(Label element1, RichTextBox element2)
        {
            string _changes;
            if (element1.Visible) { _changes = element1.Text; } else {  _changes = element2.Text; }
            return _changes;
        }

        private string changedComboBox(Label element1, ComboBox element2)
        {
            string _changes;
            if (element1.Visible) { _changes = element1.Text; } else { _changes = element2.Text; }
            return _changes;
        }

        private string changedDate(Label element1, DateTimePicker element2)
        {
            string _changes;
            if (element1.Visible) 
            { 
                _changes = element1.Text; 
            } else {
                _changes = DateTime.ParseExact(element2.Text, "dd/MM/yyyy", null).Date.ToString("dd/MM/yyyy");
                // Removing time from date
            }
            return _changes;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection = new SQLiteConnection(connectionstring);
                connection.Open();

                String deleteSQL = "Delete from [Contacts] where Phone=\"" + phonelabel.Text + "\"";
                SQLiteCommand command = new SQLiteCommand(deleteSQL, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                this.Close();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
      
        }
    }
}
