namespace AutomobileWinApp
{
    partial class frmCarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 46);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Car ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Car Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 127);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Manufacturer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 164);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 201);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(181, 43);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(248, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(181, 84);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(248, 23);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(181, 161);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(248, 23);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(181, 201);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(248, 23);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(181, 124);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(248, 23);
            cboManufacturer.TabIndex = 9;
            cboManufacturer.Text = "Items:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(181, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(354, 258);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 360);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private Button btnCancel;
    }
}
