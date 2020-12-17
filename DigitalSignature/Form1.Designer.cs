namespace DigitalSignature
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDFPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsePDFPath = new System.Windows.Forms.Button();
            this.btnSignPDF = new System.Windows.Forms.Button();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDigitalSign = new System.Windows.Forms.TextBox();
            this.txtHASH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnValidateBrowsePDFPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValidatePDFPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValidatePublicKey = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtValidateDigitalSign = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(881, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Digital Signing";
            // 
            // txtPDFPath
            // 
            this.txtPDFPath.Location = new System.Drawing.Point(117, 149);
            this.txtPDFPath.Name = "txtPDFPath";
            this.txtPDFPath.Size = new System.Drawing.Size(332, 23);
            this.txtPDFPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PDF Location:";
            // 
            // btnBrowsePDFPath
            // 
            this.btnBrowsePDFPath.Location = new System.Drawing.Point(455, 149);
            this.btnBrowsePDFPath.Name = "btnBrowsePDFPath";
            this.btnBrowsePDFPath.Size = new System.Drawing.Size(31, 23);
            this.btnBrowsePDFPath.TabIndex = 3;
            this.btnBrowsePDFPath.Text = "...";
            this.btnBrowsePDFPath.UseVisualStyleBackColor = true;
            this.btnBrowsePDFPath.Click += new System.EventHandler(this.btnBrowsePDFPath_Click);
            // 
            // btnSignPDF
            // 
            this.btnSignPDF.Location = new System.Drawing.Point(206, 417);
            this.btnSignPDF.Name = "btnSignPDF";
            this.btnSignPDF.Size = new System.Drawing.Size(75, 23);
            this.btnSignPDF.TabIndex = 4;
            this.btnSignPDF.Text = "Sign";
            this.btnSignPDF.UseVisualStyleBackColor = true;
            this.btnSignPDF.Click += new System.EventHandler(this.btnSignPDF_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(117, 207);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(332, 23);
            this.txtPublicKey.TabIndex = 5;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(117, 260);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(332, 23);
            this.txtPrivateKey.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Public key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "PDF Digital Sign:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "PDF HASH:";
            // 
            // txtDigitalSign
            // 
            this.txtDigitalSign.Location = new System.Drawing.Point(117, 363);
            this.txtDigitalSign.Name = "txtDigitalSign";
            this.txtDigitalSign.ReadOnly = true;
            this.txtDigitalSign.Size = new System.Drawing.Size(332, 23);
            this.txtDigitalSign.TabIndex = 10;
            // 
            // txtHASH
            // 
            this.txtHASH.Location = new System.Drawing.Point(117, 310);
            this.txtHASH.Name = "txtHASH";
            this.txtHASH.ReadOnly = true;
            this.txtHASH.Size = new System.Drawing.Size(332, 23);
            this.txtHASH.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sign";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Verify";
            // 
            // btnValidateBrowsePDFPath
            // 
            this.btnValidateBrowsePDFPath.Location = new System.Drawing.Point(837, 149);
            this.btnValidateBrowsePDFPath.Name = "btnValidateBrowsePDFPath";
            this.btnValidateBrowsePDFPath.Size = new System.Drawing.Size(31, 23);
            this.btnValidateBrowsePDFPath.TabIndex = 17;
            this.btnValidateBrowsePDFPath.Text = "...";
            this.btnValidateBrowsePDFPath.UseVisualStyleBackColor = true;
            this.btnValidateBrowsePDFPath.Click += new System.EventHandler(this.btnValidateBrowsePDFPath_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "PDF Location:";
            // 
            // txtValidatePDFPath
            // 
            this.txtValidatePDFPath.Location = new System.Drawing.Point(606, 149);
            this.txtValidatePDFPath.Name = "txtValidatePDFPath";
            this.txtValidatePDFPath.Size = new System.Drawing.Size(225, 23);
            this.txtValidatePDFPath.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Public key:";
            // 
            // txtValidatePublicKey
            // 
            this.txtValidatePublicKey.Location = new System.Drawing.Point(606, 207);
            this.txtValidatePublicKey.Name = "txtValidatePublicKey";
            this.txtValidatePublicKey.Size = new System.Drawing.Size(225, 23);
            this.txtValidatePublicKey.TabIndex = 18;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(665, 417);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 20;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtValidateDigitalSign
            // 
            this.txtValidateDigitalSign.Location = new System.Drawing.Point(606, 260);
            this.txtValidateDigitalSign.Name = "txtValidateDigitalSign";
            this.txtValidateDigitalSign.Size = new System.Drawing.Size(225, 23);
            this.txtValidateDigitalSign.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "PDF Digital Sign:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 489);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValidateDigitalSign);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValidatePublicKey);
            this.Controls.Add(this.btnValidateBrowsePDFPath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValidatePDFPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDigitalSign);
            this.Controls.Add(this.txtHASH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.btnSignPDF);
            this.Controls.Add(this.btnBrowsePDFPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPDFPath);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDFPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowsePDFPath;
        private System.Windows.Forms.Button btnSignPDF;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDigitalSign;
        private System.Windows.Forms.TextBox txtHASH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnValidateBrowsePDFPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValidatePDFPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValidatePublicKey;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtValidateDigitalSign;
        private System.Windows.Forms.Label label11;
    }
}

