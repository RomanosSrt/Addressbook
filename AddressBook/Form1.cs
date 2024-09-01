using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;

namespace AddressBook
{
    public partial class Addressbook : Form
    {

        String connectionstring = "Data source=Addressbook.db;Version=3";
        SQLiteConnection connection;
        private string selection;

        public Addressbook()
        {
            InitializeComponent();
            
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddContact addContactForm = new AddContact();
            addContactForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                connection = new SQLiteConnection(connectionstring);
                connection.Open();

                int contacts = 0;

                String selectSQL = "Select Name,Phone,Image from Contacts";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0).IndexOf(richTextBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (reader.IsDBNull(2))
                        {
                            populateItems(contacts, reader.GetString(0), reader.GetString(1), "Images\\contactDefault.png");
                        }
                        else
                        {
                            populateItems(contacts, reader.GetString(0), reader.GetString(1), reader.GetString(2));
                        }

                        contacts++;
                    }
                }

                reader.Close();
                command.Dispose();
                connection.Close();
            }
            else
            {
                ToolTip toolTip3 = new ToolTip();
                toolTip3.IsBalloon = true;
                toolTip3.Show("Name required", richTextBox1, 0, -50, 2000);
            }
        }


        private void populateItems(int contacts, string name, string number, string image)
        {
            ContactTemplate contactTemplate = new ContactTemplate();

            contactTemplate._Name = name;
            contactTemplate._Phone = number;
            contactTemplate._Image = @"" + image;


            flowLayoutPanel1.Controls.Add(contactTemplate);


        }

        private void Addressbook_Activated(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            richTextBox1.Text = string.Empty;

            connection = new SQLiteConnection(connectionstring);
            connection.Open();

            int contacts = 0;

            String selectSQL = "Select Name,Phone,Image from Contacts";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(2))
                {
                    populateItems(contacts, reader.GetString(0), reader.GetString(1), "Images\\contactDefault.png");
                }
                else
                {
                    populateItems(contacts, reader.GetString(0), reader.GetString(1), reader.GetString(2));
                }

                contacts++;
            }


            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            GroupComboBox.SelectedIndex = 0;
            flowLayoutPanel1.Controls.Clear();
            connection = new SQLiteConnection(connectionstring);
            connection.Open();

            int contacts = 0;

            String selectSQL = "Select Name,Phone,Image from Contacts";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0).IndexOf(richTextBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    if (reader.IsDBNull(2))
                    {
                        populateItems(contacts, reader.GetString(0), reader.GetString(1), "Images\\contactDefault.png");
                    }
                    else
                    {
                        populateItems(contacts, reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    }

                    contacts++;
                }
            }

            reader.Close();
            command.Dispose();
            connection.Close();
            
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            flowLayoutPanel1.Controls.Clear();

            connection = new SQLiteConnection(connectionstring);
            connection.Open();

            int contacts = 0;

            String selectSQL = "";

            switch (GroupComboBox.SelectedIndex)
            {
                case 0:
                    selectSQL = "Select Name,Phone,Image from Contacts";
                    break;
                case 1:
                    selection = "Family";
                    selectSQL = "Select Name,Phone,Image from Contacts where Grouped=@grouped";
                    break;
                case 2:
                    selection = "Work";
                    selectSQL = "Select Name,Phone,Image from Contacts where Grouped=@grouped";
                    break;
                case 3:
                    selection = "Friend";
                    selectSQL = "Select Name,Phone,Image from Contacts where Grouped=@grouped";
                    break;
            }

            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            if (GroupComboBox.SelectedIndex != 0)
            {
                
                command.Parameters.AddWithValue("@grouped", selection);
            } 
            

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                    if (reader.IsDBNull(2))
                    {
                        populateItems(contacts, reader.GetString(0), reader.GetString(1), "Images\\contactDefault.png");
                    }
                    else
                    {
                        populateItems(contacts, reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    }

                    contacts++;
            }

            reader.Close();
            command.Dispose();
            connection.Close();
        }


        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            GroupComboBox.SelectedIndex = 0;
            flowLayoutPanel1.Controls.Clear();
            richTextBox1.Text = string.Empty;
            

            connection = new SQLiteConnection(connectionstring);
            connection.Open();

            int contacts = 0;

            String selectSQL = "Select Name,Phone,Image from Contacts";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(2))
                {
                    populateItems(contacts, reader.GetString(0), reader.GetString(1), "Images\\contactDefault.png");
                }
                else
                {
                    populateItems(contacts, reader.GetString(0), reader.GetString(1), reader.GetString(2));
                }

                contacts++;
            }


            reader.Close();
            command.Dispose();
            connection.Close();
        }
    }
}
