using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class TextureBrushForm : Form
    {
        System.Drawing.Image imageSelected;
        int xAxis = 1;  //if radioButton checked, becomes -1, flip
        int yAxis = 1;    //both checked, both -1, flip on both axis
        public TextureBrushForm()
        {
            InitializeComponent();
            PictureBox pictureBox = new PictureBox();          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void imageSelect_Click(object sender, EventArgs e) 
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open Images";
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageSelected = new Bitmap(ofd.FileName);
                    if(xAxis == 1)
                    {
                        imageSelected.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    }
                    if (yAxis == -1)
                    {
                        imageSelected.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    }
                    if (xAxis == -1 && yAxis == -1)
                    {
                        imageSelected.RotateFlip(RotateFlipType.RotateNoneFlipXY);
                    }
                    TextureBrush tBrush = new TextureBrush(imageSelected);
                    tBrush.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                }                                              
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            xAxis *= -1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            yAxis *= -1;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
