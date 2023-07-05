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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPageEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage();
            this.Hide();
            l1.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
           /* Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT aid,aname,email FROM Admin", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewAdmin.DataSource = dt;*/
        }

        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Admin(aid, aname, password, email) VALUES (@ID,@Name,@Password,@Email)", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxAid.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxAname.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxApassword.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxAemail.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxAid.Text = "";
            textBoxAname.Text = "";
            textBoxApassword.Text = "";
            textBoxAemail.Text = "";
            MessageBox.Show("Successfully Inserted");
            BindDataAdmin();
        }

        void BindDataAdmin()
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT aid,aname,email FROM Admin", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewAdmin.DataSource = dt;
        }

        void BindDataManager()
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT mid,mname,memail FROM Manager", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewManager.DataSource = dt;
        }

        void BindDataRestaurant()
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Restaurant", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewRestaurant.DataSource = dt;
        }

        void BindDataEmployee()
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", Connection.sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.sqlCon.Close();
            dataGridViewEmployee.DataSource = dt;
        }

        private void buttonShowAdminData_Click(object sender, EventArgs e)
        {
            BindDataAdmin();
        }

        private void buttonShowManagerData_Click(object sender, EventArgs e)
        {
            BindDataManager();
        }

        private void buttonRemoveAdmin_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("DELETE from Admin where aid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxAid.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxAname.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxApassword.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxAemail.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxAid.Text = "";
            textBoxAname.Text = "";
            textBoxApassword.Text = "";
            textBoxAemail.Text = "";
            MessageBox.Show("Successfully Removed");
            BindDataAdmin();
        }

        private void buttonUpdateAdmin_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Admin SET aname=@Name, password=@Password, email=@Email WHERE aid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxAid.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxAname.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxApassword.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxAemail.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxAid.Text = "";
            textBoxAname.Text = "";
            textBoxApassword.Text = "";
            textBoxAemail.Text = "";
            MessageBox.Show("Successfully Updated");
            BindDataAdmin();
        }

        private void buttonShowRestaurant_Click(object sender, EventArgs e)
        {
            BindDataRestaurant();
        }

        private void buttonReAdd_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Restaurant(rid, rname, rating) VALUES (@ID,@Name,@Rating)", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxReId.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxReName.Text);
            cmd.Parameters.AddWithValue("@Rating", textBoxReRating.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxReId.Text = "";
            textBoxReName.Text = "";
            textBoxReRating.Text = "";
            MessageBox.Show("Successfully Inserted");
            BindDataRestaurant();
        }

        private void buttonReRemove_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("DELETE from Restaurant where rid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxReId.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxAname.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxApassword.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxAemail.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxReId.Text = "";
            textBoxReName.Text = "";
            textBoxReRating.Text = "";
            MessageBox.Show("Successfully Removed");
            BindDataRestaurant();
        }

        private void buttonReUpdate_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Restaurant SET rname=@Name, rating=@Rating WHERE rid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxReId.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxReName.Text);
            cmd.Parameters.AddWithValue("@Rating", textBoxReRating.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxReId.Text = "";
            textBoxReName.Text = "";
            textBoxReRating.Text = "";
            MessageBox.Show("Successfully Updated");
            BindDataRestaurant();
        }

        private void buttonShowEmployee_Click(object sender, EventArgs e)
        {
            BindDataEmployee();
        }

        private void buttonEmAdd_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Employee(eid, ename, age, phone, Type, address, salary, dob) VALUES (@ID,@Name,@Age,@Phone,@Type,@Address,@Salary,@Dob)", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxEmId.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxEmName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBoxEmAge.Text));
            cmd.Parameters.AddWithValue("@Phone", textBoxEmPhone.Text);
            cmd.Parameters.AddWithValue("@Type", textBoxEmType.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxEmAddress.Text);
            cmd.Parameters.AddWithValue("@Salary", int.Parse(textBoxEmSalary.Text));
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Value.Date);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxEmId.Text = "";
            textBoxEmName.Text = "";
            textBoxEmAge.Text = "";
            textBoxEmPhone.Text = "";
            textBoxEmType.Text = "";
            textBoxEmAddress.Text = "";
            textBoxEmSalary.Text = "";
            dateTimePicker1.Text = null;
            MessageBox.Show("Successfully Inserted");
            BindDataEmployee();
        }

        private void buttonEmRemove_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("DELETE from Employee where eid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxEmId.Text));
            /*cmd.Parameters.AddWithValue("@Name", textBoxEmName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBoxEmAge.Text));
            cmd.Parameters.AddWithValue("@Phone", textBoxEmPhone.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxEmMail.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxEmAddress.Text);
            cmd.Parameters.AddWithValue("@Salary", int.Parse(textBoxEmSalary.Text));
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Value.Date);*/
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxEmId.Text = "";
            textBoxEmName.Text = "";
            textBoxEmAge.Text = "";
            textBoxEmPhone.Text = "";
            textBoxEmType.Text = "";
            textBoxEmAddress.Text = "";
            textBoxEmSalary.Text = "";
            dateTimePicker1.Text = null;
            MessageBox.Show("Successfully Removed");
            BindDataEmployee();
        }

        private void buttonEmUpdate_Click(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Employee SET ename=@Name, age=@Age, phone=@Phone, Type=@Type, address=@Address, salary=@Salary, dob=@Dob where eid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxEmId.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxEmName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBoxEmAge.Text));
            cmd.Parameters.AddWithValue("@Phone", textBoxEmPhone.Text);
            cmd.Parameters.AddWithValue("@Type", textBoxEmType.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxEmAddress.Text);
            cmd.Parameters.AddWithValue("@Salary", int.Parse(textBoxEmSalary.Text));
            cmd.Parameters.AddWithValue("@Dob", dateTimePicker1.Value.Date);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxEmId.Text = "";
            textBoxEmName.Text = "";
            textBoxEmAge.Text = "";
            textBoxEmPhone.Text = "";
            textBoxEmType.Text = "";
            textBoxEmAddress.Text = "";
            textBoxEmSalary.Text = "";
            dateTimePicker1.Text = null;
            MessageBox.Show("Successfully Updated");
            BindDataEmployee();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonShowManagerData_Click_1(object sender, EventArgs e)
        {
            BindDataManager();
        }

        private void buttonAddManager_Click_1(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Manager(mid, mname, mpassword, memail) VALUES (@ID,@Name,@Password,@Email)", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxMid.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxMname.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxMpassword.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxMemail.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxMid.Text = "";
            textBoxMname.Text = "";
            textBoxMpassword.Text = "";
            textBoxMemail.Text = "";
            MessageBox.Show("Successfully Inserted");
            BindDataManager();
        }

        private void buttonRemoveManager_Click_1(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("DELETE from Manager where mid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxMid.Text));
            //cmd.Parameters.AddWithValue("@Name", textBoxAname.Text);
            //cmd.Parameters.AddWithValue("@Password", textBoxApassword.Text);
            // cmd.Parameters.AddWithValue("@Email", textBoxAemail.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxMid.Text = "";
            textBoxMname.Text = "";
            textBoxMpassword.Text = "";
            textBoxMemail.Text = "";
            MessageBox.Show("Successfully Removed");
            BindDataManager();
        }

        private void buttonUpdateManager_Click_1(object sender, EventArgs e)
        {
            Connection.sqlCon.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Manager SET mname=@Name, mpassword=@Password, memail=@Email WHERE mid=@ID", Connection.sqlCon);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBoxMid.Text));
            cmd.Parameters.AddWithValue("@Name", textBoxMname.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxMpassword.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxMemail.Text);
            cmd.ExecuteNonQuery();
            Connection.sqlCon.Close();
            textBoxMid.Text = "";
            textBoxMname.Text = "";
            textBoxMpassword.Text = "";
            textBoxMemail.Text = "";
            MessageBox.Show("Successfully Updated");
            BindDataManager();
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
