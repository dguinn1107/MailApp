namespace MailApp
{
    partial class Form1
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
            this.bodyTxtBox = new System.Windows.Forms.RichTextBox();
            this.toTxtBox = new System.Windows.Forms.RichTextBox();
            this.subjectTxtBox = new System.Windows.Forms.RichTextBox();
            this.ccTxtBox = new System.Windows.Forms.RichTextBox();
            this.sendMail = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendSMSbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyTxtBox
            // 
            this.bodyTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bodyTxtBox.Location = new System.Drawing.Point(12, 232);
            this.bodyTxtBox.Name = "bodyTxtBox";
            this.bodyTxtBox.Size = new System.Drawing.Size(609, 247);
            this.bodyTxtBox.TabIndex = 0;
            this.bodyTxtBox.Text = "";
            // 
            // toTxtBox
            // 
            this.toTxtBox.Location = new System.Drawing.Point(44, 12);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.Size = new System.Drawing.Size(239, 43);
            this.toTxtBox.TabIndex = 2;
            this.toTxtBox.Text = "";
            // 
            // subjectTxtBox
            // 
            this.subjectTxtBox.Location = new System.Drawing.Point(12, 157);
            this.subjectTxtBox.Name = "subjectTxtBox";
            this.subjectTxtBox.Size = new System.Drawing.Size(228, 42);
            this.subjectTxtBox.TabIndex = 4;
            this.subjectTxtBox.Text = "";
            // 
            // ccTxtBox
            // 
            this.ccTxtBox.Location = new System.Drawing.Point(44, 61);
            this.ccTxtBox.Name = "ccTxtBox";
            this.ccTxtBox.Size = new System.Drawing.Size(239, 45);
            this.ccTxtBox.TabIndex = 5;
            this.ccTxtBox.Text = "";
            // 
            // sendMail
            // 
            this.sendMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sendMail.Location = new System.Drawing.Point(32, 21);
            this.sendMail.Name = "sendMail";
            this.sendMail.Size = new System.Drawing.Size(79, 27);
            this.sendMail.TabIndex = 6;
            this.sendMail.Text = "EMAIL";
            this.sendMail.UseVisualStyleBackColor = true;
            this.sendMail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(32, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Body";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.sendSMSbutton);
            this.groupBox1.Controls.Add(this.sendMail);
            this.groupBox1.Location = new System.Drawing.Point(639, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 164);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // sendSMSbutton
            // 
            this.sendSMSbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sendSMSbutton.Location = new System.Drawing.Point(32, 65);
            this.sendSMSbutton.Name = "sendSMSbutton";
            this.sendSMSbutton.Size = new System.Drawing.Size(79, 27);
            this.sendSMSbutton.TabIndex = 13;
            this.sendSMSbutton.Text = "SMS";
            this.sendSMSbutton.UseVisualStyleBackColor = true;
            this.sendSMSbutton.Click += new System.EventHandler(this.sendSMSButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ccTxtBox);
            this.Controls.Add(this.subjectTxtBox);
            this.Controls.Add(this.toTxtBox);
            this.Controls.Add(this.bodyTxtBox);
            this.Name = "Form1";
            this.Text = "Faulkner Mail";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox bodyTxtBox;
        private System.Windows.Forms.RichTextBox toTxtBox;
        private System.Windows.Forms.RichTextBox subjectTxtBox;
        private System.Windows.Forms.RichTextBox ccTxtBox;
        private System.Windows.Forms.Button sendMail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendSMSbutton;
    }
}

