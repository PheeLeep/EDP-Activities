namespace TextFileLabExer
{
    partial class FrmLab1
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
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(55, 43);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(335, 126);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top;
            btnCreate.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(128, 232);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(181, 59);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(438, 352);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLab1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCreate;
    }
}