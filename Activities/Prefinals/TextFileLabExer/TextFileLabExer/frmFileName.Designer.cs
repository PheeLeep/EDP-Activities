namespace TextFileLabExer
{
    partial class frmFileName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(17, 60);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(276, 29);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOkay.Location = new Point(100, 104);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(104, 36);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // frmFileName
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(310, 178);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFileName";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}