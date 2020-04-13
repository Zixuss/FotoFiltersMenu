using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilterLibrary;
using ElisLibrary;
using EmilLibrary;
using GabrielLibrary;
using OlleLibrary;


namespace FotoFiltersMenu
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        //Spara den nuvarande bilden i det format du vill ha det i Jpeg eller Png
        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Png Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();


                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.PicBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.PicBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        //Öppna Bilden och gör den modifierbar
        private void öppnaBildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenIMG.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(OpenIMG.FileName);
                PicBox.Image = bitmap;
            }
        }

        //Stäng programmet
        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sätt bilden till originalbilden och därmed resetta 
        private void undoAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(OpenIMG.FileName);
            PicBox.Image = bitmap;
        }

        //Kalla på RGGBBR som ändrar färgerna med varandra och använd den
        private void rGGBBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElisLibrary.Filters.RGGBBR(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på den gråa modifikationen och använd den
        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElisLibrary.Filters.Gray(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på den röda modifikationen och använd den
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElisLibrary.Filters.Red(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på den gröna modifikationen och använd den
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElisLibrary.Filters.Green(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på den blåa modifikationen och använd den
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElisLibrary.Filters.Blue(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på den inverterande modifikationen och använd den
        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElisLibrary.Filters.Invert(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på Martinsbrus modifikationen och använd den
        private void martinMiniBrusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterLibrary.Filters.MiniNoise(bitmap, 50);
            PicBox.Image = bitmap;
        }

        //Kalla på Gabriels Monochrome (svart vita) modifikationen och använd den
        private void gabrielMonochromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GabrielLibrary.Filter.Monochrome(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på EmilsBrus modifikationen och använd den
        private void emilBrusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmilLibrary.Filters.Blur(bitmap, 1);
            PicBox.Image = bitmap;
        }

        //Kalla på EmilsGrain modifikationen och använd den
        private void emilGrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmilLibrary.Filters.Grain(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på Gabriels Absoluta färg modifikationen och använd den
        private void gabrielAbsoluteColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GabrielLibrary.Filter.AbsoluteColor(bitmap);
            PicBox.Image = bitmap;
        }

        //Kalla på EmilsBrightness modifikationen och använd den
        private void emilBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmilLibrary.Filters.Brightness(bitmap, 10);
            PicBox.Image = bitmap;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Det här programmet tillåter dig att lägga in en bild och modifiera den på några olika sätt.", "Om Detta Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }


    }
}
