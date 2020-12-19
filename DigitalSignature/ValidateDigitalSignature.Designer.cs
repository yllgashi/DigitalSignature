using System.ComponentModel;

namespace DigitalSignature {
    partial class ValidateDigitalSignature {
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDigitalSignature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonGetKeysFromFile = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(318, 35);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(90, 26);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(21, 39);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(273, 20);
            this.textBoxFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "File";
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(21, 90);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(273, 20);
            this.textBoxPublicKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Public Key";
            // 
            // textBoxDigitalSignature
            // 
            this.textBoxDigitalSignature.Location = new System.Drawing.Point(21, 144);
            this.textBoxDigitalSignature.Name = "textBoxDigitalSignature";
            this.textBoxDigitalSignature.Size = new System.Drawing.Size(273, 20);
            this.textBoxDigitalSignature.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digital Signature";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(21, 217);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(133, 34);
            this.buttonGoBack.TabIndex = 3;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonGetKeysFromFile
            // 
            this.buttonGetKeysFromFile.Location = new System.Drawing.Point(160, 217);
            this.buttonGetKeysFromFile.Name = "buttonGetKeysFromFile";
            this.buttonGetKeysFromFile.Size = new System.Drawing.Size(134, 34);
            this.buttonGetKeysFromFile.TabIndex = 4;
            this.buttonGetKeysFromFile.Text = "Get Keys from file";
            this.buttonGetKeysFromFile.UseVisualStyleBackColor = true;
            this.buttonGetKeysFromFile.Click += new System.EventHandler(this.buttonGetKeysFromFile_Click);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(300, 217);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(133, 34);
            this.buttonValidate.TabIndex = 5;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // ValidateDigitalSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 277);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonGetKeysFromFile);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDigitalSignature);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "ValidateDigitalSignature";
            this.Text = "ValidateDigitalSignature";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonGetKeysFromFile;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxDigitalSignature;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxPublicKey;

        #endregion
    }
}