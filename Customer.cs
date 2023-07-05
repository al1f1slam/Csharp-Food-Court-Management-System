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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Connection.sqlCon.Open();

                SqlCommand cmd = new SqlCommand("SELECT fcode,fname,rid,fprice FROM FoodItem WHERE ftype=@Type", Connection.sqlCon);
                cmd.Parameters.AddWithValue("@Type", checkBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Connection.sqlCon.Close();
                dataGridViewFoodList.DataSource = dt;
            }
            else if (checkBox2.Checked)
            {
                Connection.sqlCon.Open();

                SqlCommand cmd = new SqlCommand("SELECT fcode,fname,rid,fprice FROM FoodItem WHERE ftype=@Type", Connection.sqlCon);
                cmd.Parameters.AddWithValue("@Type", checkBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Connection.sqlCon.Close();
                dataGridViewFoodList.DataSource = dt;
            }
            else if (checkBox3.Checked)
            {
                Connection.sqlCon.Open();

                SqlCommand cmd = new SqlCommand("SELECT fcode,fname,rid,fprice FROM FoodItem WHERE ftype=@Type", Connection.sqlCon);
                cmd.Parameters.AddWithValue("@Type", checkBox3.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Connection.sqlCon.Close();
                dataGridViewFoodList.DataSource = dt;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage();
            this.Hide();
            l1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO OrderList(fcode, rid, quantity, tableNumber) VALUES (@Code,@RID,@Quantity,@TableNumber)", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@Code", int.Parse(textBoxFoodCode.Text));
            cmd.Parameters.AddWithValue("@RID", int.Parse(textBoxReId.Text));
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBoxFoodQuantity.Text));
            cmd.Parameters.AddWithValue("@TableNumber", int.Parse(comboBoxTableNum.Text));
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxFoodCode.Text = "";
            textBoxReId.Text = "";
            textBoxFoodQuantity.Text = "";
            comboBoxTableNum.Text = "";
            MessageBox.Show("Successfully Ordered");
        }
    }
}
