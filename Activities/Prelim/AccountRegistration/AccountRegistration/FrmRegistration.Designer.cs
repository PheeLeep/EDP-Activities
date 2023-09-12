namespace AccountRegistration
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
            StudentNoTextBox = new TextBox();
            label2 = new Label();
            ProgramComboBox = new ComboBox();
            label3 = new Label();
            FirstNameTextBox = new TextBox();
            label4 = new Label();
            MiddleNameTextBox = new TextBox();
            label5 = new Label();
            LastNameTextBox = new TextBox();
            ContactNumberTextBox = new TextBox();
            label6 = new Label();
            AgeTextBox = new TextBox();
            label7 = new Label();
            AddressTextBox = new TextBox();
            label8 = new Label();
            NextButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // StudentNoTextBox
            // 
            StudentNoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentNoTextBox.Location = new Point(20, 41);
            StudentNoTextBox.Name = "StudentNoTextBox";
            StudentNoTextBox.Size = new Size(184, 29);
            StudentNoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 13);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 2;
            label2.Text = "Program:";
            // 
            // ProgramComboBox
            // 
            ProgramComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProgramComboBox.FormattingEnabled = true;
            ProgramComboBox.Items.AddRange(new object[] { "BS in Information Technology", "BS in Multimedia Arts", "BS in Computer Science", "BS in Computer Engineering", "BS in Tourism Management" });
            ProgramComboBox.Location = new Point(210, 40);
            ProgramComboBox.Name = "ProgramComboBox";
            ProgramComboBox.Size = new Size(379, 29);
            ProgramComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 0;
            label3.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(20, 100);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(184, 29);
            FirstNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 73);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 0;
            label4.Text = "Middle Name:";
            // 
            // MiddleNameTextBox
            // 
            MiddleNameTextBox.Location = new Point(210, 100);
            MiddleNameTextBox.Name = "MiddleNameTextBox";
            MiddleNameTextBox.Size = new Size(184, 29);
            MiddleNameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 73);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 0;
            label5.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(400, 100);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(184, 29);
            LastNameTextBox.TabIndex = 1;
            // 
            // ContactNumberTextBox
            // 
            ContactNumberTextBox.Location = new Point(210, 168);
            ContactNumberTextBox.Name = "ContactNumberTextBox";
            ContactNumberTextBox.Size = new Size(184, 29);
            ContactNumberTextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 141);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 4;
            label6.Text = "Contact No.:";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(20, 168);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(184, 29);
            AgeTextBox.TabIndex = 7;
            AgeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 141);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 5;
            label7.Text = "Age:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(20, 237);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(575, 196);
            AddressTextBox.TabIndex = 9;
            AddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 210);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 8;
            label8.Text = "Address:";
            // 
            // NextButton
            // 
            NextButton.Anchor = AnchorStyles.Top;
            NextButton.Location = new Point(248, 442);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(113, 41);
            NextButton.TabIndex = 10;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 495);
            Controls.Add(NextButton);
            Controls.Add(AddressTextBox);
            Controls.Add(label8);
            Controls.Add(ContactNumberTextBox);
            Controls.Add(label6);
            Controls.Add(AgeTextBox);
            Controls.Add(label7);
            Controls.Add(ProgramComboBox);
            Controls.Add(label2);
            Controls.Add(LastNameTextBox);
            Controls.Add(label5);
            Controls.Add(MiddleNameTextBox);
            Controls.Add(label4);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label3);
            Controls.Add(StudentNoTextBox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StudentNoTextBox;
        private Label label2;
        private ComboBox ProgramComboBox;
        private Label label3;
        private TextBox FirstNameTextBox;
        private Label label4;
        private TextBox MiddleNameTextBox;
        private Label label5;
        private TextBox LastNameTextBox;
        private TextBox ContactNumberTextBox;
        private Label label6;
        private TextBox AgeTextBox;
        private Label label7;
        private TextBox AddressTextBox;
        private Label label8;
        private Button NextButton;
    }
}