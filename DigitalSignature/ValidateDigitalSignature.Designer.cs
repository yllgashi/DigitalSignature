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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateDigitalSignature));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDigitalSignature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGetKeysFromFile = new System.Windows.Forms.PictureBox();
            this.buttonValidate = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonGoBack = new System.Windows.Forms.PictureBox();
            this.buttonOpenFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGetKeysFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonValidate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenFile)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(13, 184);
            this.textBoxFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(304, 26);
            this.textBoxFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Signed file path";
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(13, 245);
            this.textBoxPublicKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(304, 26);
            this.textBoxPublicKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Public Key";
            // 
            // textBoxDigitalSignature
            // 
            this.textBoxDigitalSignature.Location = new System.Drawing.Point(13, 312);
            this.textBoxDigitalSignature.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDigitalSignature.Name = "textBoxDigitalSignature";
            this.textBoxDigitalSignature.Size = new System.Drawing.Size(304, 26);
            this.textBoxDigitalSignature.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digital Signature";
            // 
            // buttonGetKeysFromFile
            // 
            this.buttonGetKeysFromFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonGetKeysFromFile.Image")));
            this.buttonGetKeysFromFile.Location = new System.Drawing.Point(137, 387);
            this.buttonGetKeysFromFile.Name = "buttonGetKeysFromFile";
            this.buttonGetKeysFromFile.Size = new System.Drawing.Size(52, 50);
            this.buttonGetKeysFromFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonGetKeysFromFile.TabIndex = 6;
            this.buttonGetKeysFromFile.TabStop = false;
            this.buttonGetKeysFromFile.Click += new System.EventHandler(this.buttonGetKeysFromFile_Click);
            this.buttonGetKeysFromFile.MouseHover += new System.EventHandler(this.buttonGetKeysFromFile_MouseHover);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Image = ((System.Drawing.Image)(resources.GetObject("buttonValidate.Image")));
            this.buttonValidate.Location = new System.Drawing.Point(258, 387);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(59, 50);
            this.buttonValidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonValidate.TabIndex = 7;
            this.buttonValidate.TabStop = false;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            this.buttonValidate.MouseHover += new System.EventHandler(this.buttonValidate_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(0, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 127);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(269, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(256, 23);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(179, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoBack.Image")));
            this.buttonGoBack.Location = new System.Drawing.Point(16, 387);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(48, 50);
            this.buttonGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonGoBack.TabIndex = 9;
            this.buttonGoBack.TabStop = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            this.buttonGoBack.MouseHover += new System.EventHandler(this.buttonGoBack_MouseHover);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(324, 184);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(35, 26);
            this.buttonOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonOpenFile.TabIndex = 10;
            this.buttonOpenFile.TabStop = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.buttonOpenFile.MouseHover += new System.EventHandler(this.buttonOpenFile_MouseHover);
            // 
            // ValidateDigitalSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 452);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonGetKeysFromFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDigitalSignature);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxFile);
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ValidateDigitalSignature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Signature";
            ((System.ComponentModel.ISupportInitialize)(this.buttonGetKeysFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonValidate)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxDigitalSignature;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxPublicKey;

        #endregion

        private System.Windows.Forms.PictureBox buttonGetKeysFromFile;
        private System.Windows.Forms.PictureBox buttonValidate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox buttonGoBack;
        private System.Windows.Forms.PictureBox buttonOpenFile;
    }
}