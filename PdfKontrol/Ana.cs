using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfKontrol
{
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }
        string kaynakDosya = "", kaynakDosyaIsmi = "", hedefKlasor = "", dosyaadi = "";
        //Uzunluktxt inin texti değişince Genisliktxt yi aktif ediyor
        private void UzunlukTxt_TextChanged(object sender, EventArgs e)
        {
            GenislikTxt.Enabled = true;
           
        }
        //GenislikTxt inin texti değişince Tarihtxt yi aktif ediyor
        private void GenislikTxt_TextChanged(object sender, EventArgs e)
        {
            Tarihtxt.Enabled = true;
            
        }
        //TarihTxt inin texti değişince Saticifirmatxt yi aktif ediyor
        private void Tarihtxt_TextChanged(object sender, EventArgs e)
        {
            SaticiFirmaTxt.Enabled = true;
        }
        //Saticifirmatxt inin texti değişince btnkaydeti aktif ediyor
        private void SaticiFirmaTxt_TextChanged(object sender, EventArgs e)
        {
            BtnKaydet.Enabled = true;
        }
        //Aldığımız pdf i istediğimiz dosyaya istediğimiz isimle kayıt etme
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (hedefKlasor != "" && kaynakDosya != "")
            {
                if (File.Exists(hedefKlasor + "\\" + kaynakDosyaIsmi))
                {
                    MessageBox.Show("Belirtilen klasörde " + kaynakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dosyaadi = KaliteTxt.Text + UzunlukTxt.Text + GenislikTxt.Text + Tarihtxt.Text +SaticiFirmaTxt.Text ;
                    File.Copy(kaynakDosya, hedefKlasor + "\\" + dosyaadi + ".pdf");
                    MessageBox.Show("Dosya Kopyalama İşlemi Başarılı", "Dosya Kopyalandı...");
                }
            }
        }

        private void Arama(object sender, EventArgs e)
        {
            Arama arama = new Arama();
            arama.Show();
            this.Hide();
        }
        //picturebox 1 e tıklanınca programı kapatır
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            Arama arama = new Arama();
            arama.Show();
            this.Hide();
        }
        //programı küçük boyuta getirir
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Gray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }


        //KaliteTxt inin texti değişince uzunluktxt yi aktif ediyor
        private void KaliteTxt_TextChanged(object sender, EventArgs e)
        {
            UzunlukTxt.Enabled = true;
            
        }

        //Kaydedilecek Dosyanın Yerini Seçiyoruz
        private void KaydedilecekYer_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                KonumTxt.Text = hedefKlasor;
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            KaliteTxt.Enabled = true;
           
            

        }
        //Kaydedilecek Yeri Ve Dosyayı Seçtikten Sonra Dosyayı Kaydetmek için seçtiğimiz klasöre kopyalıyor 
        private void BtnDosyaSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Kopyalanacak Dosyayı Seçiniz...";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kaynakDosyaIsmi = openFileDialog1.SafeFileName.ToString();
                kaynakDosya = openFileDialog1.FileName.ToString();
                PdfGosterici.LoadFile(openFileDialog1.FileName);

            }
            else
            {
                MessageBox.Show("Dosya Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            KaydedilecekYer.Enabled = true;
        }
    }
}
