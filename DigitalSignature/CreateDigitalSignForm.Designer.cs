using System.ComponentModel;

namespace DigitalSignature {
    partial class CreateDigitalSignForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBoxSelectFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDigitalSignature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGenerateDigitalSignature = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBoxSelectFile
            // 
            this.textBoxSelectFile.Location = new System.Drawing.Point(30, 37);
            this.textBoxSelectFile.Name = "textBoxSelectFile";
            this.textBoxSelectFile.Size = new System.Drawing.Size(292, 20);
            this.textBoxSelectFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected File";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(348, 35);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(30, 83);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.ReadOnly = true;
            this.textBoxPublicKey.Size = new System.Drawing.Size(292, 20);
            this.textBoxPublicKey.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pubilc Key";
            // 
            // textBoxDigitalSignature
            // 
            this.textBoxDigitalSignature.Location = new System.Drawing.Point(30, 138);
            this.textBoxDigitalSignature.Name = "textBoxDigitalSignature";
            this.textBoxDigitalSignature.ReadOnly = true;
            this.textBoxDigitalSignature.Size = new System.Drawing.Size(292, 20);
            this.textBoxDigitalSignature.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Digital Signature";
            // 
            // buttonGenerateDigitalSignature
            // 
            this.buttonGenerateDigitalSignature.Location = new System.Drawing.Point(142, 193);
            this.buttonGenerateDigitalSignature.Name = "buttonGenerateDigitalSignature";
            this.buttonGenerateDigitalSignature.Size = new System.Drawing.Size(145, 33);
            this.buttonGenerateDigitalSignature.TabIndex = 3;
            this.buttonGenerateDigitalSignature.Text = "Generate Digital Signature";
            this.buttonGenerateDigitalSignature.UseVisualStyleBackColor = true;
            this.buttonGenerateDigitalSignature.Click += new System.EventHandler(this.buttonGenerateDigitalSignature_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(293, 193);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(130, 33);
            this.buttonSaveToFile.TabIndex = 4;
            this.buttonSaveToFile.Text = "Save To File";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(12, 193);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(124, 33);
            this.buttonGoBack.TabIndex = 5;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // CreateDigitalSignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 256);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonGenerateDigitalSignature);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDigitalSignature);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxSelectFile);
            this.Name = "CreateDigitalSignForm";
            this.Text = "CreateDigitalSignForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonGenerateDigitalSignature;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxDigitalSignature;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TextBox textBoxSelectFile;

        #endregion
    }
}