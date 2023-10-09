namespace OrganizationProfile {
    partial class frmConfirmation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSubmit = new Button();
            lblStudentNo = new Label();
            lblName = new Label();
            lblProgram = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblGender = new Label();
            lblContactNo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 111);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "Program:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 153);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 194);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 4;
            label5.Text = "Birthday:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 235);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 275);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(160, 356);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(154, 48);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(160, 34);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(33, 25);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "---";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(160, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(33, 25);
            lblName.TabIndex = 1;
            lblName.Text = "---";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(160, 111);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(33, 25);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "---";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(160, 153);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(33, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "---";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(160, 194);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(33, 25);
            lblBirthday.TabIndex = 4;
            lblBirthday.Text = "---";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(160, 235);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(33, 25);
            lblGender.TabIndex = 5;
            lblGender.Text = "---";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(160, 275);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(33, 25);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "---";
            // 
            // frmConfirmation
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(473, 433);
            Controls.Add(btnSubmit);
            Controls.Add(lblContactNo);
            Controls.Add(label7);
            Controls.Add(lblGender);
            Controls.Add(label6);
            Controls.Add(lblBirthday);
            Controls.Add(label5);
            Controls.Add(lblAge);
            Controls.Add(label4);
            Controls.Add(lblProgram);
            Controls.Add(label3);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(lblStudentNo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfirmation";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmConfirmation";
            Load += frmConfirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSubmit;
        private Label lblStudentNo;
        private Label lblName;
        private Label lblProgram;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblContactNo;
    }
}