namespace DBProgAct {
    partial class FrmClubRegistration {
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            programsComboBox = new ComboBox();
            label6 = new Label();
            genderComboBox = new ComboBox();
            middleNameTextBox = new TextBox();
            label5 = new Label();
            firstNameTextBox = new TextBox();
            label4 = new Label();
            ageTextBox = new TextBox();
            label3 = new Label();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            studIDTextBox = new TextBox();
            groupBox2 = new GroupBox();
            refreshButton = new Button();
            clubMembersDGV = new DataGridView();
            RegisterButton = new Button();
            updateButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clubMembersDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(programsComboBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(genderComboBox);
            groupBox1.Controls.Add(middleNameTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(firstNameTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ageTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lastNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(studIDTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 229);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 22);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 14;
            label7.Text = "Program:";
            // 
            // programsComboBox
            // 
            programsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            programsComboBox.FormattingEnabled = true;
            programsComboBox.Items.AddRange(new object[] { "BS in Information Technology", "Bachelor in Multimedia Arts", "BS in Computer Engineering", "BS in Computer Science", "BS in Business Administration" });
            programsComboBox.Location = new Point(452, 45);
            programsComboBox.Name = "programsComboBox";
            programsComboBox.Size = new Size(211, 28);
            programsComboBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 148);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 12;
            label6.Text = "Gender:";
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(235, 171);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(211, 28);
            genderComboBox.TabIndex = 11;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(452, 107);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(211, 27);
            middleNameTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 84);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 9;
            label5.Text = "Middle Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(235, 107);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(211, 27);
            firstNameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 84);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 7;
            label4.Text = "First Name:";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(18, 171);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(211, 27);
            ageTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 148);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Age:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(18, 107);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(211, 27);
            lastNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "Last Name:";
            // 
            // studIDTextBox
            // 
            studIDTextBox.Location = new Point(18, 46);
            studIDTextBox.Name = "studIDTextBox";
            studIDTextBox.Size = new Size(211, 27);
            studIDTextBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(refreshButton);
            groupBox2.Controls.Add(clubMembersDGV);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(812, 222);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "List of Club Members";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(689, 23);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(117, 46);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // clubMembersDGV
            // 
            clubMembersDGV.AllowUserToDeleteRows = false;
            clubMembersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clubMembersDGV.Dock = DockStyle.Left;
            clubMembersDGV.Location = new Point(3, 23);
            clubMembersDGV.Name = "clubMembersDGV";
            clubMembersDGV.ReadOnly = true;
            clubMembersDGV.RowHeadersWidth = 51;
            clubMembersDGV.RowTemplate.Height = 29;
            clubMembersDGV.Size = new Size(677, 196);
            clubMembersDGV.TabIndex = 0;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(701, 30);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(126, 46);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(701, 82);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(126, 46);
            updateButton.TabIndex = 3;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // FrmClubRegistration
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(836, 481);
            Controls.Add(updateButton);
            Controls.Add(RegisterButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClubRegistration";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clubMembersDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox ageTextBox;
        private Label label3;
        private TextBox lastNameTextBox;
        private Label label2;
        private TextBox studIDTextBox;
        private TextBox firstNameTextBox;
        private Label label4;
        private TextBox middleNameTextBox;
        private Label label5;
        private ComboBox genderComboBox;
        private Label label6;
        private Label label7;
        private ComboBox programsComboBox;
        private GroupBox groupBox2;
        private DataGridView clubMembersDGV;
        private Button RegisterButton;
        private Button updateButton;
        private Button refreshButton;
    }
}
