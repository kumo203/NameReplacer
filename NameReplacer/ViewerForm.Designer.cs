namespace NameReplacer
{
    partial class ViewerForm
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
            this.lineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.oldLineTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newLineTextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.findWhatTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lineTextBox
            // 
            this.lineTextBox.Location = new System.Drawing.Point(44, 30);
            this.lineTextBox.Name = "lineTextBox";
            this.lineTextBox.ReadOnly = true;
            this.lineTextBox.Size = new System.Drawing.Size(53, 19);
            this.lineTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // fileNameLinkLabel
            // 
            this.fileNameLinkLabel.AutoSize = true;
            this.fileNameLinkLabel.Location = new System.Drawing.Point(12, 15);
            this.fileNameLinkLabel.Name = "fileNameLinkLabel";
            this.fileNameLinkLabel.Size = new System.Drawing.Size(53, 12);
            this.fileNameLinkLabel.TabIndex = 2;
            this.fileNameLinkLabel.TabStop = true;
            this.fileNameLinkLabel.Text = "FileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Line";
            // 
            // oldLineTextBox
            // 
            this.oldLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldLineTextBox.Location = new System.Drawing.Point(14, 73);
            this.oldLineTextBox.Name = "oldLineTextBox";
            this.oldLineTextBox.ReadOnly = true;
            this.oldLineTextBox.Size = new System.Drawing.Size(958, 19);
            this.oldLineTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Old";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "New";
            // 
            // newLineTextBox
            // 
            this.newLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newLineTextBox.Location = new System.Drawing.Point(14, 110);
            this.newLineTextBox.Name = "newLineTextBox";
            this.newLineTextBox.ReadOnly = true;
            this.newLineTextBox.Size = new System.Drawing.Size(958, 19);
            this.newLineTextBox.TabIndex = 7;
            // 
            // continueButton
            // 
            this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.continueButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.continueButton.Location = new System.Drawing.Point(14, 146);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(724, 23);
            this.continueButton.TabIndex = 8;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopButton.Location = new System.Drawing.Point(812, 146);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // findWhatTextBox
            // 
            this.findWhatTextBox.Location = new System.Drawing.Point(191, 30);
            this.findWhatTextBox.Name = "findWhatTextBox";
            this.findWhatTextBox.ReadOnly = true;
            this.findWhatTextBox.Size = new System.Drawing.Size(137, 19);
            this.findWhatTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Find What";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Replace With";
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.Location = new System.Drawing.Point(436, 30);
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.ReadOnly = true;
            this.replaceWithTextBox.Size = new System.Drawing.Size(137, 19);
            this.replaceWithTextBox.TabIndex = 12;
            // 
            // ViewerForm
            // 
            this.AcceptButton = this.continueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.stopButton;
            this.ClientSize = new System.Drawing.Size(984, 185);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.replaceWithTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findWhatTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.newLineTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldLineTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineTextBox);
            this.Name = "ViewerForm";
            this.Text = "ViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lineTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel fileNameLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldLineTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newLineTextBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox findWhatTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox replaceWithTextBox;
    }
}