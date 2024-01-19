namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbPrice = new Label();
            lbCarName = new Label();
            lbReleaseYear = new Label();
            lbManufacturer = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(45, 63);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(372, 63);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "Price";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(42, 107);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Car Name";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(372, 107);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(78, 15);
            lbReleaseYear.TabIndex = 3;
            lbReleaseYear.Text = "Released Year";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(42, 156);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 4;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(127, 60);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(209, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(127, 104);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(209, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(127, 153);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(209, 23);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(456, 60);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(188, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(456, 104);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(188, 23);
            txtReleaseYear.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(127, 193);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(78, 25);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(324, 193);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(505, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(42, 224);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(657, 126);
            dgvCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(320, 368);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 409);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbManufacturer);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbCarName);
            Controls.Add(lbPrice);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbPrice;
        private Label lbCarName;
        private Label lbReleaseYear;
        private Label lbManufacturer;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}