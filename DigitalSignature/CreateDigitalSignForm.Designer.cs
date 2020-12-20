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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDigitalSignForm));
            this.textBoxSelectFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDigitalSignature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSelectFile = new System.Windows.Forms.PictureBox();
            this.buttonSaveToFile = new System.Windows.Forms.PictureBox();
            this.buttonGenerateDigitalSignature = new System.Windows.Forms.PictureBox();
            this.buttonGoBack = new System.Windows.Forms.PictureBox();
            this.comboBoxHash = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonSelectFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonSaveToFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonGenerateDigitalSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonGoBack)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSelectFile
            // 
            this.textBoxSelectFile.Location = new System.Drawing.Point(16, 175);
            this.textBoxSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSelectFile.Name = "textBoxSelectFile";
            this.textBoxSelectFile.Size = new System.Drawing.Size(304, 26);
            this.textBoxSelectFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File path";
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(16, 238);
            this.textBoxPublicKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.ReadOnly = true;
            this.textBoxPublicKey.Size = new System.Drawing.Size(304, 26);
            this.textBoxPublicKey.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pubilc Key";
            // 
            // textBoxDigitalSignature
            // 
            this.textBoxDigitalSignature.Location = new System.Drawing.Point(16, 298);
            this.textBoxDigitalSignature.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDigitalSignature.Name = "textBoxDigitalSignature";
            this.textBoxDigitalSignature.ReadOnly = true;
            this.textBoxDigitalSignature.Size = new System.Drawing.Size(304, 26);
            this.textBoxDigitalSignature.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Digital Signature";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (129)))), ((int) (((byte) (110)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 127);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Image = ((System.Drawing.Image) (resources.GetObject("buttonSelectFile.Image")));
            this.buttonSelectFile.Location = new System.Drawing.Point(327, 175);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(33, 26);
            this.buttonSelectFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSelectFile.TabIndex = 7;
            this.buttonSelectFile.TabStop = false;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            this.buttonSelectFile.MouseHover += new System.EventHandler(this.buttonSelectFile_MouseHover);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Image = ((System.Drawing.Image) (resources.GetObject("buttonSaveToFile.Image")));
            this.buttonSaveToFile.Location = new System.Drawing.Point(144, 416);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(49, 50);
            this.buttonSaveToFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSaveToFile.TabIndex = 8;
            this.buttonSaveToFile.TabStop = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            this.buttonSaveToFile.MouseHover += new System.EventHandler(this.buttonSaveToFile_MouseHover);
            // 
            // buttonGenerateDigitalSignature
            // 
            this.buttonGenerateDigitalSignature.Image = ((System.Drawing.Image) (resources.GetObject("buttonGenerateDigitalSignature.Image")));
            this.buttonGenerateDigitalSignature.Location = new System.Drawing.Point(270, 416);
            this.buttonGenerateDigitalSignature.Name = "buttonGenerateDigitalSignature";
            this.buttonGenerateDigitalSignature.Size = new System.Drawing.Size(50, 50);
            this.buttonGenerateDigitalSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonGenerateDigitalSignature.TabIndex = 9;
            this.buttonGenerateDigitalSignature.TabStop = false;
            this.buttonGenerateDigitalSignature.Click += new System.EventHandler(this.buttonGenerateDigitalSignature_Click);
            this.buttonGenerateDigitalSignature.MouseHover += new System.EventHandler(this.buttonGenerateDigitalSignature_MouseHover);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Image = ((System.Drawing.Image) (resources.GetObject("buttonGoBack.Image")));
            this.buttonGoBack.Location = new System.Drawing.Point(16, 416);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(52, 50);
            this.buttonGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonGoBack.TabIndex = 10;
            this.buttonGoBack.TabStop = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            this.buttonGoBack.MouseHover += new System.EventHandler(this.buttonGoBack_MouseHover);
            // 
            // comboBoxHash
            // 
            this.comboBoxHash.FormattingEnabled = true;
            this.comboBoxHash.Location = new System.Drawing.Point(16, 358);
            this.comboBoxHash.Name = "comboBoxHash";
            this.comboBoxHash.Size = new System.Drawing.Size(304, 26);
            this.comboBoxHash.TabIndex = 11;
            this.comboBoxHash.SelectedIndexChanged += new System.EventHandler(this.comboBoxHash_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hash Function";
            // 
            // CreateDigitalSignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 512);
            this.Controls.Add(this.comboBoxHash);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonGenerateDigitalSignature);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDigitalSignature);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxSelectFile);
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateDigitalSignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Signature";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonSelectFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonSaveToFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonGenerateDigitalSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.buttonGoBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox buttonGenerateDigitalSignature;
        private System.Windows.Forms.PictureBox buttonGoBack;
        private System.Windows.Forms.PictureBox buttonSaveToFile;
        private System.Windows.Forms.PictureBox buttonSelectFile;
        private System.Windows.Forms.ComboBox comboBoxHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxDigitalSignature;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TextBox textBoxSelectFile;

        #endregion
    }
}