namespace CustomExceptionFrm {
    partial class frmAddProduct {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 91);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 256);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 2;
            label3.Text = "Qty.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 206);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 3;
            label4.Text = "Exp. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 256);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 4;
            label5.Text = "Sell Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 169);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            label6.Text = "Mfg. Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 128);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 6;
            label7.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 57);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 7;
            label8.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(145, 88);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(301, 31);
            txtProductName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(96, 253);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(98, 31);
            txtQuantity.TabIndex = 9;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(321, 253);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(125, 31);
            txtSellPrice.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(145, 125);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(301, 33);
            cbCategory.TabIndex = 11;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Format = DateTimePickerFormat.Short;
            dtPickerMfgDate.Location = new Point(145, 164);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(301, 31);
            dtPickerMfgDate.TabIndex = 12;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Format = DateTimePickerFormat.Short;
            dtPickerExpDate.Location = new Point(145, 201);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(301, 31);
            dtPickerExpDate.TabIndex = 13;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(473, 91);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(337, 286);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(279, 336);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(167, 41);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.AllowUserToAddRows = false;
            gridViewProductList.AllowUserToDeleteRows = false;
            gridViewProductList.AllowUserToResizeRows = false;
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Dock = DockStyle.Bottom;
            gridViewProductList.Location = new Point(0, 402);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowHeadersWidth = 51;
            gridViewProductList.RowTemplate.Height = 29;
            gridViewProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewProductList.Size = new Size(822, 255);
            gridViewProductList.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTxtDescription);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnAddProduct);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtPickerExpDate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtPickerMfgDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSellPrice);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(txtQuantity);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 402);
            panel1.TabIndex = 17;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(822, 657);
            Controls.Add(panel1);
            Controls.Add(gridViewProductList);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private RichTextBox richTxtDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
        private Panel panel1;
    }
}