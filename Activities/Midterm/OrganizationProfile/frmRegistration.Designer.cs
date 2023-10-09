namespace OrganizationProfile {
    partial class frmRegistration {
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
            txtStudentNo = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtMiddleInitial = new TextBox();
            label5 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            txtContactNo = new TextBox();
            label7 = new Label();
            cbPrograms = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            label10 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(164, 38);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 78);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(29, 106);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(214, 31);
            txtStudentNo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 150);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 1;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(29, 178);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(214, 31);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(249, 178);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(214, 31);
            txtFirstName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 150);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(469, 178);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(97, 31);
            txtMiddleInitial.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 150);
            label5.Name = "label5";
            label5.Size = new Size(37, 25);
            label5.TabIndex = 5;
            label5.Text = "M.I";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(469, 254);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(97, 31);
            txtAge.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 226);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 7;
            label6.Text = "Age";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(29, 329);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(214, 31);
            txtContactNo.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 301);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 9;
            label7.Text = "Contact No.";
            // 
            // cbPrograms
            // 
            cbPrograms.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(249, 104);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(317, 33);
            cbPrograms.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 78);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 12;
            label8.Text = "Programs";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 226);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 14;
            label9.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(29, 254);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(214, 33);
            cbGender.TabIndex = 13;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Format = DateTimePickerFormat.Short;
            datePickerBirthday.Location = new Point(249, 254);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(214, 31);
            datePickerBirthday.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(249, 226);
            label10.Name = "label10";
            label10.Size = new Size(77, 25);
            label10.TabIndex = 9;
            label10.Text = "Birthday";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(219, 394);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(180, 45);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(592, 465);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(label9);
            Controls.Add(cbGender);
            Controls.Add(label8);
            Controls.Add(cbPrograms);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtAge);
            Controls.Add(label6);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtStudentNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentNo;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtMiddleInitial;
        private Label label5;
        private TextBox txtAge;
        private Label label6;
        private TextBox txtContactNo;
        private Label label7;
        private ComboBox cbPrograms;
        private Label label8;
        private Label label9;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private Label label10;
        private Button btnRegister;
    }
}