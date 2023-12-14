namespace DBProgAct {
    partial class FrmUpdateMember {
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
            updateButton = new Button();
            label7 = new Label();
            programsComboBox = new ComboBox();
            label6 = new Label();
            genderComboBox = new ComboBox();
            middleNameTextBox = new TextBox();
            label5 = new Label();
            firstNameTextBox = new TextBox();
            label4 = new Label();
            ageTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            studentIDComboBox = new ComboBox();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Location = new Point(70, 458);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(126, 46);
            updateButton.TabIndex = 17;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 383);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 28;
            label7.Text = "Program:";
            // 
            // programsComboBox
            // 
            programsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            programsComboBox.FormattingEnabled = true;
            programsComboBox.Items.AddRange(new object[] { "BS in Information Technology", "Bachelor in Multimedia Arts", "BS in Computer Engineering", "BS in Computer Science", "BS in Business Administration" });
            programsComboBox.Location = new Point(12, 406);
            programsComboBox.Name = "programsComboBox";
            programsComboBox.Size = new Size(235, 28);
            programsComboBox.TabIndex = 27;
            programsComboBox.SelectedIndexChanged += ObjectValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 318);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 26;
            label6.Text = "Gender:";
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(12, 341);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(235, 28);
            genderComboBox.TabIndex = 25;
            genderComboBox.SelectedIndexChanged += ObjectValueChanged;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(12, 220);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(235, 27);
            middleNameTextBox.TabIndex = 24;
            middleNameTextBox.TextChanged += ObjectValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 23;
            label5.Text = "Middle Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 160);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(235, 27);
            firstNameTextBox.TabIndex = 22;
            firstNameTextBox.TextChanged += ObjectValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 21;
            label4.Text = "First Name:";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(12, 278);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(235, 27);
            ageTextBox.TabIndex = 20;
            ageTextBox.TextChanged += ObjectValueChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(12, 96);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(235, 27);
            lastNameTextBox.TabIndex = 19;
            lastNameTextBox.TextChanged += ObjectValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 18;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 15;
            label1.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 254);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 29;
            label3.Text = "Age:";
            // 
            // studentIDComboBox
            // 
            studentIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            studentIDComboBox.FormattingEnabled = true;
            studentIDComboBox.Location = new Point(12, 36);
            studentIDComboBox.Name = "studentIDComboBox";
            studentIDComboBox.Size = new Size(235, 28);
            studentIDComboBox.TabIndex = 30;
            studentIDComboBox.SelectedIndexChanged += studentIDComboBox_SelectedIndexChanged;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 525);
            Controls.Add(studentIDComboBox);
            Controls.Add(label3);
            Controls.Add(updateButton);
            Controls.Add(label7);
            Controls.Add(programsComboBox);
            Controls.Add(label6);
            Controls.Add(genderComboBox);
            Controls.Add(middleNameTextBox);
            Controls.Add(label5);
            Controls.Add(firstNameTextBox);
            Controls.Add(label4);
            Controls.Add(ageTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateButton;
        private Label label7;
        private ComboBox programsComboBox;
        private Label label6;
        private ComboBox genderComboBox;
        private TextBox middleNameTextBox;
        private Label label5;
        private TextBox firstNameTextBox;
        private Label label4;
        private TextBox ageTextBox;
        private TextBox lastNameTextBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox studentIDComboBox;
    }
}