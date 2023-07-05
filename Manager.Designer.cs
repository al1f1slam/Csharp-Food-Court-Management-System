
namespace Food_Court_Management_System
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonShowFoodItem = new System.Windows.Forms.Button();
            this.comboBoxFtype = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxReId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonFoUpdate = new System.Windows.Forms.Button();
            this.buttonFoRemove = new System.Windows.Forms.Button();
            this.buttonFoAdd = new System.Windows.Forms.Button();
            this.dataGridViewFoodItem = new System.Windows.Forms.DataGridView();
            this.textBoxFoQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFoRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFoPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFoName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFoCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonShowFoodQuantity = new System.Windows.Forms.Button();
            this.buttonFoQAdd = new System.Windows.Forms.Button();
            this.dataGridViewFoodQuantity = new System.Windows.Forms.DataGridView();
            this.textBoxFoQQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFoQReId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFoQCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodItem)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodQuantity)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 89);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(157, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 526);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.buttonShowFoodItem);
            this.tabPage1.Controls.Add(this.comboBoxFtype);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBoxReId);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.buttonFoUpdate);
            this.tabPage1.Controls.Add(this.buttonFoRemove);
            this.tabPage1.Controls.Add(this.buttonFoAdd);
            this.tabPage1.Controls.Add(this.dataGridViewFoodItem);
            this.tabPage1.Controls.Add(this.textBoxFoQuantity);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxFoRating);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxFoPrice);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxFoName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxFoCode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Food Item";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonShowFoodItem
            // 
            this.buttonShowFoodItem.Location = new System.Drawing.Point(505, 120);
            this.buttonShowFoodItem.Name = "buttonShowFoodItem";
            this.buttonShowFoodItem.Size = new System.Drawing.Size(106, 41);
            this.buttonShowFoodItem.TabIndex = 41;
            this.buttonShowFoodItem.Text = "Show Data";
            this.buttonShowFoodItem.UseVisualStyleBackColor = true;
            this.buttonShowFoodItem.Click += new System.EventHandler(this.buttonShowFoodItem_Click);
            // 
            // comboBoxFtype
            // 
            this.comboBoxFtype.FormattingEnabled = true;
            this.comboBoxFtype.Items.AddRange(new object[] {
            "Main Dish",
            "Appetizer",
            "Water and Beverage"});
            this.comboBoxFtype.Location = new System.Drawing.Point(138, 257);
            this.comboBoxFtype.Name = "comboBoxFtype";
            this.comboBoxFtype.Size = new System.Drawing.Size(136, 23);
            this.comboBoxFtype.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Food Type";
            // 
            // textBoxReId
            // 
            this.textBoxReId.Location = new System.Drawing.Point(138, 298);
            this.textBoxReId.Name = "textBoxReId";
            this.textBoxReId.Size = new System.Drawing.Size(136, 23);
            this.textBoxReId.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Restaurant ID";
            // 
            // buttonFoUpdate
            // 
            this.buttonFoUpdate.Location = new System.Drawing.Point(643, 413);
            this.buttonFoUpdate.Name = "buttonFoUpdate";
            this.buttonFoUpdate.Size = new System.Drawing.Size(106, 41);
            this.buttonFoUpdate.TabIndex = 29;
            this.buttonFoUpdate.Text = "Update";
            this.buttonFoUpdate.UseVisualStyleBackColor = true;
            this.buttonFoUpdate.Click += new System.EventHandler(this.buttonFoUpdate_Click);
            // 
            // buttonFoRemove
            // 
            this.buttonFoRemove.Location = new System.Drawing.Point(505, 413);
            this.buttonFoRemove.Name = "buttonFoRemove";
            this.buttonFoRemove.Size = new System.Drawing.Size(106, 41);
            this.buttonFoRemove.TabIndex = 28;
            this.buttonFoRemove.Text = "Remove";
            this.buttonFoRemove.UseVisualStyleBackColor = true;
            this.buttonFoRemove.Click += new System.EventHandler(this.buttonFoRemove_Click);
            // 
            // buttonFoAdd
            // 
            this.buttonFoAdd.Location = new System.Drawing.Point(365, 413);
            this.buttonFoAdd.Name = "buttonFoAdd";
            this.buttonFoAdd.Size = new System.Drawing.Size(106, 41);
            this.buttonFoAdd.TabIndex = 27;
            this.buttonFoAdd.Text = "Add";
            this.buttonFoAdd.UseVisualStyleBackColor = true;
            this.buttonFoAdd.Click += new System.EventHandler(this.buttonFoAdd_Click);
            // 
            // dataGridViewFoodItem
            // 
            this.dataGridViewFoodItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFoodItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodItem.Location = new System.Drawing.Point(340, 178);
            this.dataGridViewFoodItem.Name = "dataGridViewFoodItem";
            this.dataGridViewFoodItem.RowTemplate.Height = 25;
            this.dataGridViewFoodItem.Size = new System.Drawing.Size(409, 220);
            this.dataGridViewFoodItem.TabIndex = 26;
            // 
            // textBoxFoQuantity
            // 
            this.textBoxFoQuantity.Location = new System.Drawing.Point(138, 437);
            this.textBoxFoQuantity.Name = "textBoxFoQuantity";
            this.textBoxFoQuantity.Size = new System.Drawing.Size(136, 23);
            this.textBoxFoQuantity.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Quantity";
            // 
            // textBoxFoRating
            // 
            this.textBoxFoRating.Location = new System.Drawing.Point(138, 393);
            this.textBoxFoRating.Name = "textBoxFoRating";
            this.textBoxFoRating.Size = new System.Drawing.Size(136, 23);
            this.textBoxFoRating.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Food Rating";
            // 
            // textBoxFoPrice
            // 
            this.textBoxFoPrice.Location = new System.Drawing.Point(138, 348);
            this.textBoxFoPrice.Name = "textBoxFoPrice";
            this.textBoxFoPrice.Size = new System.Drawing.Size(136, 23);
            this.textBoxFoPrice.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Food Price";
            // 
            // textBoxFoName
            // 
            this.textBoxFoName.Location = new System.Drawing.Point(138, 213);
            this.textBoxFoName.Name = "textBoxFoName";
            this.textBoxFoName.Size = new System.Drawing.Size(136, 23);
            this.textBoxFoName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Food Name";
            // 
            // textBoxFoCode
            // 
            this.textBoxFoCode.Location = new System.Drawing.Point(138, 165);
            this.textBoxFoCode.Name = "textBoxFoCode";
            this.textBoxFoCode.Size = new System.Drawing.Size(136, 23);
            this.textBoxFoCode.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Food Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(230, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 45);
            this.label8.TabIndex = 15;
            this.label8.Text = "Food Item Management";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.buttonShowFoodQuantity);
            this.tabPage2.Controls.Add(this.buttonFoQAdd);
            this.tabPage2.Controls.Add(this.dataGridViewFoodQuantity);
            this.tabPage2.Controls.Add(this.textBoxFoQQuantity);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBoxFoQReId);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxFoQCode);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Food Quantity";
            // 
            // buttonShowFoodQuantity
            // 
            this.buttonShowFoodQuantity.Location = new System.Drawing.Point(485, 98);
            this.buttonShowFoodQuantity.Name = "buttonShowFoodQuantity";
            this.buttonShowFoodQuantity.Size = new System.Drawing.Size(106, 41);
            this.buttonShowFoodQuantity.TabIndex = 42;
            this.buttonShowFoodQuantity.Text = "Show Data";
            this.buttonShowFoodQuantity.UseVisualStyleBackColor = true;
            this.buttonShowFoodQuantity.Click += new System.EventHandler(this.buttonShowFoodQuantity_Click);
            // 
            // buttonFoQAdd
            // 
            this.buttonFoQAdd.Location = new System.Drawing.Point(485, 367);
            this.buttonFoQAdd.Name = "buttonFoQAdd";
            this.buttonFoQAdd.Size = new System.Drawing.Size(106, 41);
            this.buttonFoQAdd.TabIndex = 29;
            this.buttonFoQAdd.Text = "Update";
            this.buttonFoQAdd.UseVisualStyleBackColor = true;
            this.buttonFoQAdd.Click += new System.EventHandler(this.buttonFoQAdd_Click);
            // 
            // dataGridViewFoodQuantity
            // 
            this.dataGridViewFoodQuantity.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFoodQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodQuantity.Location = new System.Drawing.Point(337, 145);
            this.dataGridViewFoodQuantity.Name = "dataGridViewFoodQuantity";
            this.dataGridViewFoodQuantity.RowTemplate.Height = 25;
            this.dataGridViewFoodQuantity.Size = new System.Drawing.Size(409, 206);
            this.dataGridViewFoodQuantity.TabIndex = 27;
            // 
            // textBoxFoQQuantity
            // 
            this.textBoxFoQQuantity.Location = new System.Drawing.Point(146, 250);
            this.textBoxFoQQuantity.Name = "textBoxFoQQuantity";
            this.textBoxFoQQuantity.Size = new System.Drawing.Size(153, 23);
            this.textBoxFoQQuantity.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Quantity";
            // 
            // textBoxFoQReId
            // 
            this.textBoxFoQReId.Location = new System.Drawing.Point(146, 198);
            this.textBoxFoQReId.Name = "textBoxFoQReId";
            this.textBoxFoQReId.Size = new System.Drawing.Size(153, 23);
            this.textBoxFoQReId.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Restaurant ID";
            // 
            // textBoxFoQCode
            // 
            this.textBoxFoQCode.Location = new System.Drawing.Point(146, 142);
            this.textBoxFoQCode.Name = "textBoxFoQCode";
            this.textBoxFoQCode.Size = new System.Drawing.Size(153, 23);
            this.textBoxFoQCode.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Food Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(209, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Food Quantity Management";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(24, 456);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 41);
            this.buttonLogout.TabIndex = 32;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage3.Controls.Add(this.buttonUpdateOrder);
            this.tabPage3.Controls.Add(this.dataGridViewOrder);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Order List";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 25;
            this.dataGridViewOrder.Size = new System.Drawing.Size(756, 385);
            this.dataGridViewOrder.TabIndex = 28;
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(373, 420);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(106, 41);
            this.buttonUpdateOrder.TabIndex = 30;
            this.buttonUpdateOrder.Text = "Update";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodItem)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodQuantity)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewFoodItem;
        private System.Windows.Forms.TextBox textBoxFoQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFoRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFoPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFoName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFoCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFoAdd;
        private System.Windows.Forms.Button buttonFoUpdate;
        private System.Windows.Forms.Button buttonFoRemove;
        private System.Windows.Forms.TextBox textBoxReId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonFoQAdd;
        private System.Windows.Forms.DataGridView dataGridViewFoodQuantity;
        private System.Windows.Forms.TextBox textBoxFoQQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFoQReId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFoQCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxFtype;
        private System.Windows.Forms.Button buttonShowFoodItem;
        private System.Windows.Forms.Button buttonShowFoodQuantity;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
    }
}