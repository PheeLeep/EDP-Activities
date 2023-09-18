namespace QueuingCashier
{
    partial class QueuingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            QueueLabel = new Label();
            label1 = new Label();
            label3 = new Label();
            CashierButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(QueueLabel);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(CashierButton);
            splitContainer1.Size = new Size(505, 205);
            splitContainer1.SplitterDistance = 338;
            splitContainer1.TabIndex = 0;
            // 
            // QueueLabel
            // 
            QueueLabel.Dock = DockStyle.Fill;
            QueueLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            QueueLabel.Location = new Point(0, 40);
            QueueLabel.Name = "QueueLabel";
            QueueLabel.Size = new Size(338, 165);
            QueueLabel.TabIndex = 1;
            QueueLabel.Text = "---";
            QueueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(338, 40);
            label1.TabIndex = 0;
            label1.Text = "Position in Queue:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(16, 149);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 1;
            label3.Text = "* Click to get a number";
            // 
            // CashierButton
            // 
            CashierButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CashierButton.Location = new Point(15, 17);
            CashierButton.Name = "CashierButton";
            CashierButton.Size = new Size(136, 124);
            CashierButton.TabIndex = 0;
            CashierButton.Text = "Cashier";
            CashierButton.UseVisualStyleBackColor = true;
            CashierButton.Click += CashierButton_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 205);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QueuingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueuingForm";
            FormClosing += QueuingForm_FormClosing;
            Load += QueuingForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label QueueLabel;
        private Label label1;
        private Button CashierButton;
        private Label label3;
    }
}