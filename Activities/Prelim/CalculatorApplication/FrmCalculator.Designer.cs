namespace CalculatorApplication {
    partial class FrmCalculator {
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
            groupBox1 = new GroupBox();
            ClearButton = new Button();
            CalculateButton = new Button();
            OperatorComboBox = new ComboBox();
            FirstNumTextBox = new TextBox();
            SecNumTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            SummaryLabel = new Label();
            AnswerLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(CalculateButton);
            groupBox1.Controls.Add(OperatorComboBox);
            groupBox1.Controls.Add(FirstNumTextBox);
            groupBox1.Controls.Add(SecNumTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter the following:";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(186, 190);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(114, 40);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(306, 190);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(146, 40);
            CalculateButton.TabIndex = 5;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // OperatorComboBox
            // 
            OperatorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OperatorComboBox.FormattingEnabled = true;
            OperatorComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            OperatorComboBox.Location = new Point(232, 134);
            OperatorComboBox.Name = "OperatorComboBox";
            OperatorComboBox.Size = new Size(70, 31);
            OperatorComboBox.TabIndex = 4;
            // 
            // FirstNumTextBox
            // 
            FirstNumTextBox.Location = new Point(232, 42);
            FirstNumTextBox.Name = "FirstNumTextBox";
            FirstNumTextBox.Size = new Size(220, 31);
            FirstNumTextBox.TabIndex = 3;
            FirstNumTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SecNumTextBox
            // 
            SecNumTextBox.Location = new Point(232, 79);
            SecNumTextBox.Name = "SecNumTextBox";
            SecNumTextBox.Size = new Size(220, 31);
            SecNumTextBox.TabIndex = 3;
            SecNumTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 137);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "Operator:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 1;
            label2.Text = "Second Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 0;
            label1.Text = "First Number:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SummaryLabel);
            groupBox2.Controls.Add(AnswerLabel);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 142);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Answer";
            // 
            // SummaryLabel
            // 
            SummaryLabel.AutoSize = true;
            SummaryLabel.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SummaryLabel.Location = new Point(36, 54);
            SummaryLabel.Name = "SummaryLabel";
            SummaryLabel.Size = new Size(36, 20);
            SummaryLabel.TabIndex = 1;
            SummaryLabel.Text = "---";
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.Location = new Point(73, 83);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(43, 23);
            AnswerLabel.TabIndex = 0;
            AnswerLabel.Text = "---";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 399);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCalculator";
            Load += FrmCalculator_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox FirstNumTextBox;
        private TextBox SecNumTextBox;
        private ComboBox OperatorComboBox;
        private Button CalculateButton;
        private Button ClearButton;
        private Label AnswerLabel;
        private Label SummaryLabel;
    }
}