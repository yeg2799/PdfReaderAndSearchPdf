namespace PdfKontrol
{
    partial class Ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana));
            this.BtnArama = new System.Windows.Forms.Button();
            this.Tarihtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenislikTxt = new System.Windows.Forms.TextBox();
            this.UzunlukTxt = new System.Windows.Forms.TextBox();
            this.KaliteTxt = new System.Windows.Forms.TextBox();
            this.SaticiFirmaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDosyaSec = new System.Windows.Forms.Button();
            this.PdfGosterici = new AxAcroPDFLib.AxAcroPDF();
            this.label6 = new System.Windows.Forms.Label();
            this.KonumTxt = new System.Windows.Forms.TextBox();
            this.KaydedilecekYer = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PdfGosterici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnArama
            // 
            this.BtnArama.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnArama.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnArama.ForeColor = System.Drawing.Color.Red;
            this.BtnArama.Location = new System.Drawing.Point(25, 393);
            this.BtnArama.Name = "BtnArama";
            this.BtnArama.Size = new System.Drawing.Size(223, 135);
            this.BtnArama.TabIndex = 0;
            this.BtnArama.Text = "Sertifika Arama";
            this.BtnArama.UseVisualStyleBackColor = false;
            this.BtnArama.Click += new System.EventHandler(this.BtnArama_Click);
            // 
            // Tarihtxt
            // 
            this.Tarihtxt.Enabled = false;
            this.Tarihtxt.Location = new System.Drawing.Point(692, 85);
            this.Tarihtxt.Name = "Tarihtxt";
            this.Tarihtxt.Size = new System.Drawing.Size(128, 20);
            this.Tarihtxt.TabIndex = 6;
            this.Tarihtxt.TextChanged += new System.EventHandler(this.Tarihtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(699, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Serifika Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(562, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Genişlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(405, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Uzunluk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Kalite";
            // 
            // GenislikTxt
            // 
            this.GenislikTxt.Enabled = false;
            this.GenislikTxt.Location = new System.Drawing.Point(538, 85);
            this.GenislikTxt.Name = "GenislikTxt";
            this.GenislikTxt.Size = new System.Drawing.Size(124, 20);
            this.GenislikTxt.TabIndex = 5;
            this.GenislikTxt.TextChanged += new System.EventHandler(this.GenislikTxt_TextChanged);
            // 
            // UzunlukTxt
            // 
            this.UzunlukTxt.Enabled = false;
            this.UzunlukTxt.Location = new System.Drawing.Point(385, 85);
            this.UzunlukTxt.Name = "UzunlukTxt";
            this.UzunlukTxt.Size = new System.Drawing.Size(121, 20);
            this.UzunlukTxt.TabIndex = 4;
            this.UzunlukTxt.TextChanged += new System.EventHandler(this.UzunlukTxt_TextChanged);
            // 
            // KaliteTxt
            // 
            this.KaliteTxt.Enabled = false;
            this.KaliteTxt.Location = new System.Drawing.Point(234, 85);
            this.KaliteTxt.Name = "KaliteTxt";
            this.KaliteTxt.Size = new System.Drawing.Size(121, 20);
            this.KaliteTxt.TabIndex = 3;
            this.KaliteTxt.TextChanged += new System.EventHandler(this.KaliteTxt_TextChanged);
            // 
            // SaticiFirmaTxt
            // 
            this.SaticiFirmaTxt.Enabled = false;
            this.SaticiFirmaTxt.Location = new System.Drawing.Point(838, 85);
            this.SaticiFirmaTxt.Name = "SaticiFirmaTxt";
            this.SaticiFirmaTxt.Size = new System.Drawing.Size(128, 20);
            this.SaticiFirmaTxt.TabIndex = 7;
            this.SaticiFirmaTxt.TextChanged += new System.EventHandler(this.SaticiFirmaTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(856, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Satıcı Firma";
            // 
            // BtnDosyaSec
            // 
            this.BtnDosyaSec.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDosyaSec.Location = new System.Drawing.Point(25, 142);
            this.BtnDosyaSec.Name = "BtnDosyaSec";
            this.BtnDosyaSec.Size = new System.Drawing.Size(234, 85);
            this.BtnDosyaSec.TabIndex = 1;
            this.BtnDosyaSec.Text = "Dosyayı Seçiniz";
            this.BtnDosyaSec.UseVisualStyleBackColor = true;
            this.BtnDosyaSec.Click += new System.EventHandler(this.BtnDosyaSec_Click);
            // 
            // PdfGosterici
            // 
            this.PdfGosterici.Enabled = true;
            this.PdfGosterici.Location = new System.Drawing.Point(275, 142);
            this.PdfGosterici.Name = "PdfGosterici";
            this.PdfGosterici.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PdfGosterici.OcxState")));
            this.PdfGosterici.Size = new System.Drawing.Size(691, 386);
            this.PdfGosterici.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Dosyayı Kaydetmek İstediğiniz Konum";
            // 
            // KonumTxt
            // 
            this.KonumTxt.Enabled = false;
            this.KonumTxt.Location = new System.Drawing.Point(24, 355);
            this.KonumTxt.Name = "KonumTxt";
            this.KonumTxt.Size = new System.Drawing.Size(224, 20);
            this.KonumTxt.TabIndex = 55;
            // 
            // KaydedilecekYer
            // 
            this.KaydedilecekYer.Enabled = false;
            this.KaydedilecekYer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydedilecekYer.Location = new System.Drawing.Point(24, 231);
            this.KaydedilecekYer.Name = "KaydedilecekYer";
            this.KaydedilecekYer.Size = new System.Drawing.Size(235, 90);
            this.KaydedilecekYer.TabIndex = 2;
            this.KaydedilecekYer.Text = "Dosyayı nereye kaydedeceğini seç";
            this.KaydedilecekYer.UseVisualStyleBackColor = true;
            this.KaydedilecekYer.Click += new System.EventHandler(this.KaydedilecekYer_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Enabled = false;
            this.BtnKaydet.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(27, 52);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(192, 75);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(849, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(905, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 559);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KonumTxt);
            this.Controls.Add(this.KaydedilecekYer);
            this.Controls.Add(this.PdfGosterici);
            this.Controls.Add(this.BtnDosyaSec);
            this.Controls.Add(this.SaticiFirmaTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tarihtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenislikTxt);
            this.Controls.Add(this.UzunlukTxt);
            this.Controls.Add(this.KaliteTxt);
            this.Controls.Add(this.BtnArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.PdfGosterici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnArama;
        private System.Windows.Forms.TextBox Tarihtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GenislikTxt;
        private System.Windows.Forms.TextBox UzunlukTxt;
        private System.Windows.Forms.TextBox KaliteTxt;
        private System.Windows.Forms.TextBox SaticiFirmaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDosyaSec;
        private AxAcroPDFLib.AxAcroPDF PdfGosterici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KonumTxt;
        private System.Windows.Forms.Button KaydedilecekYer;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

