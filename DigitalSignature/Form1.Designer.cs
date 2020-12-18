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
        private void InitializeComponent() {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDFPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsePDFPath = new System.Windows.Forms.Button();
            this.btnSignPDF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDigitalSign = new System.Windows.Forms.TextBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
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
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(301, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Digital Signing";
            // 
            // txtPDFPath
            // 
            this.txtPDFPath.Location = new System.Drawing.Point(117, 149);
            this.txtPDFPath.Name = "txtPDFPath";
            this.txtPDFPath.Size = new System.Drawing.Size(184, 23);
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
            this.btnBrowsePDFPath.Location = new System.Drawing.Point(307, 149);
            this.btnBrowsePDFPath.Name = "btnBrowsePDFPath";
            this.btnBrowsePDFPath.Size = new System.Drawing.Size(31, 23);
            this.btnBrowsePDFPath.TabIndex = 3;
            this.btnBrowsePDFPath.Text = "...";
            this.btnBrowsePDFPath.UseVisualStyleBackColor = true;
            this.btnBrowsePDFPath.Click += new System.EventHandler(this.btnBrowsePDFPath_Click);
            // 
            // btnSignPDF
            // 
            this.btnSignPDF.Location = new System.Drawing.Point(149, 296);
            this.btnSignPDF.Name = "btnSignPDF";
            this.btnSignPDF.Size = new System.Drawing.Size(75, 23);
            this.btnSignPDF.TabIndex = 4;
            this.btnSignPDF.Text = "Sign";
            this.btnSignPDF.UseVisualStyleBackColor = true;
            this.btnSignPDF.Click += new System.EventHandler(this.btnSignPDF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "PDF Digital Sign:";
            // 
            // txtDigitalSign
            // 
            this.txtDigitalSign.Location = new System.Drawing.Point(117, 203);
            this.txtDigitalSign.Name = "txtDigitalSign";
            this.txtDigitalSign.Size = new System.Drawing.Size(184, 23);
            this.txtDigitalSign.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sign";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Verify";
            // 
            // btnValidateBrowsePDFPath
            // 
            this.btnValidateBrowsePDFPath.Location = new System.Drawing.Point(718, 149);
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
            this.label9.Location = new System.Drawing.Point(393, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "PDF Location:";
            // 
            // txtValidatePDFPath
            // 
            this.txtValidatePDFPath.Location = new System.Drawing.Point(528, 149);
            this.txtValidatePDFPath.Name = "txtValidatePDFPath";
            this.txtValidatePDFPath.Size = new System.Drawing.Size(184, 23);
            this.txtValidatePDFPath.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Public key:";
            // 
            // txtValidatePublicKey
            // 
            this.txtValidatePublicKey.Location = new System.Drawing.Point(528, 206);
            this.txtValidatePublicKey.Name = "txtValidatePublicKey";
            this.txtValidatePublicKey.Size = new System.Drawing.Size(184, 23);
            this.txtValidatePublicKey.TabIndex = 18;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(574, 296);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 20;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtValidateDigitalSign
            // 
            this.txtValidateDigitalSign.Location = new System.Drawing.Point(528, 252);
            this.txtValidateDigitalSign.Name = "txtValidateDigitalSign";
            this.txtValidateDigitalSign.Size = new System.Drawing.Size(184, 23);
            this.txtValidateDigitalSign.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "PDF Digital Sign:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "PublicKey";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(117, 252);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(184, 23);
            this.txtPublicKey.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPublicKey);
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
            this.Controls.Add(this.txtDigitalSign);
            this.Controls.Add(this.btnSignPDF);
            this.Controls.Add(this.btnBrowsePDFPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPDFPath);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnBrowsePDFPath;
        private System.Windows.Forms.Button btnSignPDF;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnValidateBrowsePDFPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtDigitalSign;
        private System.Windows.Forms.TextBox txtPDFPath;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtValidateDigitalSign;
        private System.Windows.Forms.TextBox txtValidatePDFPath;
        private System.Windows.Forms.TextBox txtValidatePublicKey;

        #endregion
    }
}

