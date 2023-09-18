namespace QueuingCashier
{
    partial class CashierWindowQueueForm
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
            RefreshButton = new Button();
            NextButton = new Button();
            ListCashierQueue = new ListBox();
            SuspendLayout();
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RefreshButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshButton.Location = new Point(12, 363);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(96, 40);
            RefreshButton.TabIndex = 1;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // NextButton
            // 
            NextButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.Location = new Point(114, 363);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(93, 40);
            NextButton.TabIndex = 2;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // ListCashierQueue
            // 
            ListCashierQueue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListCashierQueue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListCashierQueue.FormattingEnabled = true;
            ListCashierQueue.ItemHeight = 21;
            ListCashierQueue.Location = new Point(12, 12);
            ListCashierQueue.Name = "ListCashierQueue";
            ListCashierQueue.Size = new Size(365, 340);
            ListCashierQueue.TabIndex = 3;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 415);
            ControlBox = false;
            Controls.Add(ListCashierQueue);
            Controls.Add(NextButton);
            Controls.Add(RefreshButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CashierWindowQueueForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button RefreshButton;
        private Button NextButton;
        private ListBox ListCashierQueue;
    }
}