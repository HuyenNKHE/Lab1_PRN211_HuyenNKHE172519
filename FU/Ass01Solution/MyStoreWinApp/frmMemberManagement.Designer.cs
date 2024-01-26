namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lblMemberID = new System.Windows.Forms.Label();
            lblMemberName = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblCountry = new System.Windows.Forms.Label();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            btnNew = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            cmbSearch = new System.Windows.Forms.ComboBox();
            txtSearch = new System.Windows.Forms.TextBox();
            lblFilter = new System.Windows.Forms.Label();
            cmbFilter = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            lblSort = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Location = new System.Drawing.Point(84, 50);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new System.Drawing.Size(84, 20);
            lblMemberID.TabIndex = 0;
            lblMemberID.Text = "Member ID";
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Location = new System.Drawing.Point(59, 104);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new System.Drawing.Size(109, 20);
            lblMemberName.TabIndex = 0;
            lblMemberName.Text = "Member Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(84, 163);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(46, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(450, 50);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(34, 20);
            lblCity.TabIndex = 0;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new System.Drawing.Point(450, 104);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new System.Drawing.Size(60, 20);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(174, 47);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(232, 27);
            txtMemberID.TabIndex = 0;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(174, 97);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(232, 27);
            txtMemberName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(174, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(232, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(526, 43);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(232, 27);
            txtCity.TabIndex = 0;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(526, 97);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(232, 27);
            txtCountry.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(244, 219);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(462, 219);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(655, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new System.Drawing.Point(84, 270);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(73, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search By";
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "ID", "Name", "Email", "City", "Country" });
            cmbSearch.Location = new System.Drawing.Point(174, 264);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new System.Drawing.Size(232, 28);
            cmbSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(409, 263);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(193, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Tag = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new System.Drawing.Point(627, 267);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new System.Drawing.Size(42, 20);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filter";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "City", "Country" });
            cmbFilter.Location = new System.Drawing.Point(675, 262);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new System.Drawing.Size(227, 28);
            cmbFilter.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "All", "Ha Noi", "Dulangan", "los", "Neochorion", "Cho-airong", "Passos", "Piraquara", "Hanoi", "Silvares", "Ban Phan Don", "Yong-dong" });
            comboBox3.Location = new System.Drawing.Point(908, 263);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(205, 28);
            comboBox3.TabIndex = 0;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new System.Drawing.Point(866, 310);
            lblSort.Name = "lblSort";
            lblSort.Size = new System.Drawing.Size(36, 20);
            lblSort.TabIndex = 0;
            lblSort.Text = "Sort";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 345);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1101, 365);
            dataGridView1.TabIndex = 8;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1125, 722);
            Controls.Add(dataGridView1);
            Controls.Add(lblSort);
            Controls.Add(comboBox3);
            Controls.Add(cmbFilter);
            Controls.Add(lblFilter);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lblCountry);
            Controls.Add(lblCity);
            Controls.Add(lblEmail);
            Controls.Add(lblMemberName);
            Controls.Add(lblMemberID);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.Label lblMemberName;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.TextBox txtMemberID;
        public System.Windows.Forms.TextBox txtMemberName;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.TextBox txtCountry;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label lblFilter;
        public System.Windows.Forms.ComboBox cmbFilter;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
    }
}