using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBtoGrayScale
{
    public partial class Form3 : Form
    {
        Bitmap kaynak, islem;
        public Form3()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName);
            }
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = (renkliRenk.R + renkliRenk.G + renkliRenk.B) / 3;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void bt709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32(renkliRenk.R*0.2125 + renkliRenk.G*0.7154 + renkliRenk.B*0.072);
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = Convert.ToInt32(renkliRenk.R * 0.3 + renkliRenk.G * 0.59 + renkliRenk.B * 0.11);
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int s = Math.Max(renkliRenk.R, renkliRenk.G);
                    int i = Math.Max(renkliRenk.B, s);
                    int n = Math.Min(renkliRenk.R, renkliRenk.G);
                    int m = Math.Min(renkliRenk.B, n);
                    int gri = (i + m) / 2;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK) ;
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
