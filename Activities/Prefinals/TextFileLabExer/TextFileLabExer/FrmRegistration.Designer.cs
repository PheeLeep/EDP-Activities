namespace TextFileLabExer
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            txtStudNo = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            cbPrograms = new ComboBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label6 = new Label();
            txtMI = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cbGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            label9 = new Label();
            txtContactNo = new TextBox();
            label10 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 84);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // txtStudNo
            // 
            txtStudNo.Location = new Point(136, 81);
            txtStudNo.Name = "txtStudNo";
            txtStudNo.Size = new Size(205, 27);
            txtStudNo.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(136, 124);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(205, 27);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 127);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(136, 168);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(115, 27);
            txtAge.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 171);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 5;
            label4.Text = "Age";
            // 
            // cbPrograms
            // 
            cbPrograms.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Items.AddRange(new object[] { "BS Information Technology", "Bachelor of Multimedia Arts", "BS Computer Engineering", "BS Computer Science" });
            cbPrograms.Location = new Point(453, 81);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(322, 28);
            cbPrograms.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 84);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 8;
            label5.Text = "Program";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(453, 124);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(205, 27);
            txtFirstName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 127);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 9;
            label6.Text = "First Name";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(711, 124);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(64, 27);
            txtMI.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(673, 127);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 11;
            label7.Text = "M.I.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 171);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 14;
            label8.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(453, 168);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(205, 28);
            cbGender.TabIndex = 13;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(136, 211);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(205, 27);
            dtpBirthday.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 216);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 16;
            label9.Text = "Birthday";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(453, 213);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(205, 27);
            txtContactNo.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(360, 216);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 17;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(310, 284);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(175, 44);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 360);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtpBirthday);
            Controls.Add(label8);
            Controls.Add(cbGender);
            Controls.Add(txtMI);
            Controls.Add(label7);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbPrograms);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtStudNo);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudNo;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private ComboBox cbPrograms;
        private Label label5;
        private TextBox txtFirstName;
        private Label label6;
        private TextBox txtMI;
        private Label label7;
        private Label label8;
        private ComboBox cbGender;
        private DateTimePicker dtpBirthday;
        private Label label9;
        private TextBox txtContactNo;
        private Label label10;
        private Button btnRegister;
    }
}