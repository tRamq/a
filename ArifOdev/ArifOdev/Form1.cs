using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ArifOdev
{
    public partial class Form1 : Form
    {
        bool cizifaktifmi = false;
        Shape[] sekil;
        Shape aktifsekil = null;
        Shape seciliSekil = null;
        int secilensekil = 0;
        int sekilsayisi = 0;
        int maxsekilsayisi = 100;
        Bitmap bm;
        Color SecilenRenk;
        public Form1()
        {
            sekil = new Shape[maxsekilsayisi];
            SecilenRenk = Color.Red;
            secilensekil = 1;
            InitializeComponent();
            panelRed.BackColor = Color.Orange;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
            panelkare.BackColor = Color.Orange;
            paneldaire.BackColor = Color.Lime;
            panelucgen.BackColor = Color.Lime;
            panelaltigen.BackColor = Color.Lime;
            bm=new Bitmap(Panel.Width, Panel.Height);
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            cizifaktifmi = false;

            if (sekilsayisi != maxsekilsayisi)
            {
                sekil[sekilsayisi] = aktifsekil;
                sekilsayisi++;
            }
            Panel.Invalidate();
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (cizifaktifmi)
            {
                aktifsekil.BitisAta(e.X, e.Y);
                Panel.Invalidate();
            }
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (secim==1)
            {
                foreach (var siradaki in sekil)
                {
                    if (siradaki == null)
                        continue;
                    if (siradaki.Icindemi(e.X, e.Y)==true)
                    {
                        seciliSekil = siradaki;
                        aktifsekil = seciliSekil;
                        siradaki.Sekilrengi = SecilenRenk;
                        Panel.Refresh();
                        secim = 0;
                        panelsec.BackColor = Color.Pink;
                        break; 
                    }
                }
            }
            int sira = 0;
            if (secim == 2)
            {
                foreach (Shape item in sekil)
                { 
                    if (item.Icindemi(e.X,e.Y)==false)
                    {
                           seciliSekil = item;
                            aktifsekil = seciliSekil;
                            sekil[sira] = null;
                            Panel.Refresh();
                            secim = 0;
                            panelcop.BackColor = Color.Pink;
                            break;
                    }
                } sira++;
            }
            if (!cizifaktifmi)
            {
                if (secilensekil == 1)
                {
                    aktifsekil = new Kare();
                    cizifaktifmi = true;
                }
                else if(secilensekil==2)
                {
                    aktifsekil = new Daire();
                    cizifaktifmi = true;
                }
                else if(secilensekil==3)
                {
                    aktifsekil = new Ucgen();
                    
                    cizifaktifmi = true;
                }
                else if(secilensekil==4)
                {
                    aktifsekil = new Altigen();
                    cizifaktifmi = true;
                }
                aktifsekil.x = e.X;
                aktifsekil.y = e.Y;
                aktifsekil.Sekilrengi = SecilenRenk;
            }
            Panel.Invalidate();
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics cizim = e.Graphics;
            if (aktifsekil != null)
            {
                aktifsekil.Sekilrengi = SecilenRenk;
                aktifsekil.Ciz(cizim);
            }
            for (int i = 0; i < sekilsayisi; i++)
            {
                if (sekil[i]!=null)
                {
                    sekil[i].Ciz(cizim);
                }
            }
            if (seciliSekil != null)
            {
                seciliSekil.SinirCiz(cizim);
            } 
        }
        private void Kare_Click(object sender, EventArgs e)
        {
            secilensekil = 1;
            paneldaire.BackColor = Color.Lime;
            panelkare.BackColor = Color.Orange;
            panelucgen.BackColor = Color.Lime;
            panelaltigen.BackColor = Color.Lime;
        }
        private void Elips_Click(object sender, EventArgs e)
        {
            secilensekil = 2;
            paneldaire.BackColor = Color.Orange;
            panelkare.BackColor = Color.Lime;
            panelucgen.BackColor = Color.Lime;
            panelaltigen.BackColor = Color.Lime;
        }
        private void ucgen_Click(object sender, EventArgs e)
        {
            secilensekil = 3;
            paneldaire.BackColor = Color.Lime;
            panelkare.BackColor = Color.Lime;
            panelucgen.BackColor = Color.Orange;
            panelaltigen.BackColor = Color.Lime;
        }
        private void Red_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Red;
            panelRed.BackColor = Color.Orange;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
            
        }
        private void Blue_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Blue;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Orange;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Green;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Orange;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
          

        }
        private void white_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.DarkSlateGray;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Orange;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
           
        }
        private void yellow_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Yellow;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Orange;
           
        }
        private void purple_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Purple;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Orange;
            panelyellow.BackColor = Color.Lime;
           
        }
        private void darkred_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.DarkRed;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Orange;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
         
        }
        private void black_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Black;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Orange;
            paneldarkorange.BackColor = Color.Lime;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
          
        }
        private void darkorange_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Navy;
            panelRed.BackColor = Color.Lime;
            panelblue.BackColor = Color.Lime;
            panelgreen.BackColor = Color.Lime;
            paneldarkgray.BackColor = Color.Lime;
            panelblack.BackColor = Color.Lime;
            paneldarkorange.BackColor = Color.Orange;
            paneldarkred.BackColor = Color.Lime;
            panelpurple.BackColor = Color.Lime;
            panelyellow.BackColor = Color.Lime;
            
        }
        int secim;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelsec.BackColor = Color.Orange;
            panelcop.BackColor = Color.Lime;
            secim = 1;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }
        private void pictureBoxkaydet_Click(object sender, EventArgs e)
        {
          
            Graphics setPaint = Graphics.FromImage(bm);
            Rectangle rect = Panel.RectangleToScreen(Panel.ClientRectangle);
            setPaint.CopyFromScreen(rect.Location, Point.Empty, Panel.Size);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Txt files| *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    if (save.FileName.Contains(".txt"))
                    {
                        bm.Save(save.FileName, ImageFormat.Jpeg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File save error : " + ex.Message);
                }
            }
        }
        private void pictureBoxcop_Click_1(object sender, EventArgs e)
        {
            panelsec.BackColor = Color.Lime;
            panelcop.BackColor = Color.Orange;
            secim = 2;
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            secilensekil = 4;
            paneldaire.BackColor = Color.Lime;
            panelkare.BackColor = Color.Lime;
            panelucgen.BackColor = Color.Lime;
            panelaltigen.BackColor = Color.Orange;
        }
    }
}
