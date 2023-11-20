namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            txtFirstNum = new TextBox();
            opComboBox = new ComboBox();
            txtSecNum = new TextBox();
            panel1 = new Panel();
            lblAnswer = new Label();
            label2 = new Label();
            btnCompute = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtFirstNum
            // 
            txtFirstNum.Location = new Point(24, 64);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(305, 30);
            txtFirstNum.TabIndex = 1;
            txtFirstNum.Text = "0";
            txtFirstNum.TextAlign = HorizontalAlignment.Right;
            // 
            // opComboBox
            // 
            opComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            opComboBox.FormattingEnabled = true;
            opComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            opComboBox.Location = new Point(148, 106);
            opComboBox.Name = "opComboBox";
            opComboBox.Size = new Size(58, 30);
            opComboBox.TabIndex = 2;
            // 
            // txtSecNum
            // 
            txtSecNum.Location = new Point(26, 146);
            txtSecNum.Name = "txtSecNum";
            txtSecNum.Size = new Size(305, 30);
            txtSecNum.TabIndex = 3;
            txtSecNum.Text = "0";
            txtSecNum.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAnswer);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Lime;
            panel1.Location = new Point(26, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 111);
            panel1.TabIndex = 4;
            // 
            // lblAnswer
            // 
            lblAnswer.Dock = DockStyle.Fill;
            lblAnswer.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer.Location = new Point(0, 32);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(303, 79);
            lblAnswer.TabIndex = 2;
            lblAnswer.Text = "0";
            lblAnswer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(303, 32);
            label2.TabIndex = 1;
            label2.Text = "Total:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompute.Location = new Point(112, 335);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(127, 36);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(348, 395);
            Controls.Add(btnCompute);
            Controls.Add(panel1);
            Controls.Add(txtSecNum);
            Controls.Add(opComboBox);
            Controls.Add(txtFirstNum);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmBasicCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBasicCalculator";
            Load += FrmBasicCalculator_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstNum;
        private ComboBox opComboBox;
        private TextBox txtSecNum;
        private Panel panel1;
        private Label label2;
        private Label lblAnswer;
        private Button btnCompute;
    }
}