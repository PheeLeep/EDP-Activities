namespace QueuingCashier {
    partial class CashierWindowQueueForm {
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
            RefreshButton = new Button();
            NextButton = new Button();
            ListCashierQueue = new ListBox();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshButton.Location = new Point(21, 15);
            RefreshButton.Margin = new Padding(3, 4, 3, 4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(110, 53);
            RefreshButton.TabIndex = 1;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // NextButton
            // 
            NextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.Location = new Point(148, 15);
            NextButton.Margin = new Padding(3, 4, 3, 4);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(106, 53);
            NextButton.TabIndex = 2;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // ListCashierQueue
            // 
            ListCashierQueue.Dock = DockStyle.Fill;
            ListCashierQueue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListCashierQueue.FormattingEnabled = true;
            ListCashierQueue.ItemHeight = 28;
            ListCashierQueue.Location = new Point(0, 0);
            ListCashierQueue.Margin = new Padding(3, 4, 3, 4);
            ListCashierQueue.Name = "ListCashierQueue";
            ListCashierQueue.Size = new Size(445, 415);
            ListCashierQueue.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ListCashierQueue);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(RefreshButton);
            splitContainer1.Panel2.Controls.Add(NextButton);
            splitContainer1.Size = new Size(445, 510);
            splitContainer1.SplitterDistance = 415;
            splitContainer1.TabIndex = 4;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 510);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CashierWindowQueueForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button RefreshButton;
        private Button NextButton;
        private ListBox ListCashierQueue;
        private SplitContainer splitContainer1;
    }
}