using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food_Court_Management_System
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            comboBox1.Select();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Admin")
            {
                Connection.sqlCon.Open();
                string query = "Select * from Admin where aid='" + textBoxID.Text.Trim() + "' and password = '" + textBoxPass.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Connection.sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                Connection.sqlCon.Close();

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (dtbl.Rows.Count == 1)
                    {
                        Admin a1 = new Admin();
                        this.Hide();
                        a1.Show();
                    }

                    else
                    {
                        MessageBox.Show("Wrong username or password");
                    }
                }
            }

            else if (comboBox1.Text == "Manager")
            {
                Connection.sqlCon.Open();
                string query = "Select * from Manager where mid='" + textBoxID.Text.Trim() + "' and mpassword = '" + textBoxPass.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Connection.sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                Connection.sqlCon.Close();

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (dtbl.Rows.Count == 1)
                    {
                        Manager m1 = new Manager();
                        this.Hide();
                        m1.Show();
                    }

                    else
                    {
                        MessageBox.Show("Wrong username or password");
                    }
                }
            }

            else if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select user type !");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                e.Cancel = true;
                textBoxID.Focus();
                errorProvider1.SetError(textBoxID, "Please Enter your ID !");
            }
            else
            {
                errorProvider1.SetError(textBoxID, null);
            }
        }

        private void textBoxPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPass.Text))
            {
                e.Cancel = true;
                textBoxPass.Focus();
                errorProvider2.SetError(textBoxPass, "Please Enter your Password !");
            }
            else
            {
                errorProvider1.SetError(textBoxPass, null);
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider3.SetError(comboBox1, "Please select user type !");
            }
            else
            {
                errorProvider1.SetError(comboBox1, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            this.Hide();
            c1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
