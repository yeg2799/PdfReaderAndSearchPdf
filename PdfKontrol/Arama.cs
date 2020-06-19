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
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }
        String Dosya = "", GostermeAdresi = "";
        

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ana ana = new Ana();
            ana.Show();
            this.Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Green;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
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
            pictureBox1.BackColor = Color.Gray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            Dosya = Aratxt.Text;
            DirectoryInfo di = new DirectoryInfo(@"C:\\Users\Emre\Desktop");
            FileInfo[] files = di.GetFiles(Aratxt.Text + "*.pdf", SearchOption.AllDirectories);
            listBox1.Items.Clear();
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.Name + "                                         Dosya Yolu:" + fi.FullName);
              

            }
        }
    }
}
