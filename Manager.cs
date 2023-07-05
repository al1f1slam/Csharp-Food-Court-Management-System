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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        void BindDataFoodItem()
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM FoodItem", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewFoodItem.DataSource = dt;
        }

        void BindDataFoodQuantity()
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT fcode,fname,rid,fquantity FROM FoodItem", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewFoodQuantity.DataSource = dt;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFoAdd_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO FoodItem(fcode, fname, ftype, rid, fprice, frating, fquantity) VALUES (@Code,@Name,@Type,@RID,@Price,@Rating,@Quantity)", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@Code", int.Parse(textBoxFoCode.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxFoName.Text);
            cmd.Parameters.AddWithValue("@Type", comboBoxFtype.Text);
            cmd.Parameters.AddWithValue("@RID", textBoxReId.Text);
            cmd.Parameters.AddWithValue("@Price", textBoxFoPrice.Text);
            cmd.Parameters.AddWithValue("@Rating", textBoxFoRating.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBoxFoQuantity.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxFoCode.Text = "";
            textBoxFoName.Text = "";
            comboBoxFtype.Text = "";
            textBoxReId.Text = "";
            textBoxFoPrice.Text = "";
            textBoxFoRating.Text = "";
            textBoxFoQuantity.Text = "";
            MessageBox.Show("Successfully Inserted");
            BindDataFoodItem();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage();
            this.Hide();
            l1.Show();
        }

        private void buttonFoRemove_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("DELETE from FoodItem WHERE fcode=@COde", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@Code", int.Parse(textBoxFoCode.Text));
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxFoCode.Text = "";
            textBoxFoName.Text = "";
            comboBoxFtype.Text = "";
            textBoxReId.Text = "";
            textBoxFoPrice.Text = "";
            textBoxFoRating.Text = "";
            textBoxFoQuantity.Text = "";
            MessageBox.Show("Successfully Deleted");
            BindDataFoodItem();
        }

        private void buttonFoUpdate_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("UPDATE FoodItem SET fname=@Name, ftype=@Type, rid=@RID, fprice=@Price, frating=@Rating, fquantity=@Quantity WHERE fcode=@Code", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@Code", int.Parse(textBoxFoCode.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxFoName.Text);
            cmd.Parameters.AddWithValue("@Type", comboBoxFtype.Text);
            cmd.Parameters.AddWithValue("@RID", textBoxReId.Text);
            cmd.Parameters.AddWithValue("@Price", textBoxFoPrice.Text);
            cmd.Parameters.AddWithValue("@Rating", textBoxFoRating.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBoxFoQuantity.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxFoCode.Text = "";
            textBoxFoName.Text = "";
            comboBoxFtype.Text = "";
            textBoxReId.Text = "";
            textBoxFoPrice.Text = "";
            textBoxFoRating.Text = "";
            textBoxFoQuantity.Text = "";
            MessageBox.Show("Successfully Updated");
            BindDataFoodItem();
        }

        private void buttonShowFoodItem_Click(object sender, EventArgs e)
        {
            BindDataFoodItem();
        }

        private void buttonShowFoodQuantity_Click(object sender, EventArgs e)
        {
            BindDataFoodQuantity();
        }

        private void buttonFoQAdd_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("UPDATE FoodItem SET fquantity=@Quantity WHERE fcode=@Code AND rid=@RID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@Code", int.Parse(textBoxFoQCode.Text));
            cmd.Parameters.AddWithValue("@RID", textBoxFoQReId.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBoxFoQQuantity.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxFoCode.Text = "";
            textBoxFoName.Text = "";
            comboBoxFtype.Text = "";
            textBoxReId.Text = "";
            textBoxFoPrice.Text = "";
            textBoxFoRating.Text = "";
            textBoxFoQuantity.Text = "";
            MessageBox.Show("Successfully Updated");
            BindDataFoodQuantity();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderList", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewOrder.DataSource = dt;
        }
    }
}
