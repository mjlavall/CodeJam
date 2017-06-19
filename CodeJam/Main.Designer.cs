namespace CodeJam
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.ofdButton = new System.Windows.Forms.Button();
            this.ofdTextBox = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // ofdButton
            // 
            this.ofdButton.Location = new System.Drawing.Point(197, 8);
            this.ofdButton.Name = "ofdButton";
            this.ofdButton.Size = new System.Drawing.Size(75, 23);
            this.ofdButton.TabIndex = 1;
            this.ofdButton.Text = "Select";
            this.ofdButton.UseVisualStyleBackColor = true;
            this.ofdButton.Click += new System.EventHandler(this.ofdButton_Click);
            // 
            // ofdTextBox
            // 
            this.ofdTextBox.Location = new System.Drawing.Point(50, 10);
            this.ofdTextBox.Name = "ofdTextBox";
            this.ofdTextBox.Size = new System.Drawing.Size(141, 20);
            this.ofdTextBox.TabIndex = 2;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(16, 77);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(256, 63);
            this.solveButton.TabIndex = 3;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(16, 147);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(16, 58);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.ofdTextBox);
            this.Controls.Add(this.ofdButton);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "CodeJam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ofdButton;
        private System.Windows.Forms.TextBox ofdTextBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

