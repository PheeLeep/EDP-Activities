﻿namespace QueuingCashierTP {
    partial class NowServingForm {
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
            QueueLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // QueueLabel
            // 
            QueueLabel.Dock = DockStyle.Fill;
            QueueLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            QueueLabel.Location = new Point(0, 53);
            QueueLabel.Name = "QueueLabel";
            QueueLabel.Size = new Size(377, 135);
            QueueLabel.TabIndex = 3;
            QueueLabel.Text = "---";
            QueueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 53);
            label1.TabIndex = 2;
            label1.Text = "* Now Serving:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NowServingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 188);
            ControlBox = false;
            Controls.Add(QueueLabel);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NowServingForm";
            Text = "Now Serving";
            Load += NowServingForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label QueueLabel;
        private Label label1;
    }
}