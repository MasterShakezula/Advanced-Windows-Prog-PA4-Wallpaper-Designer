using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft //hello
{
    public partial class TextureBrushForm : Form
    {
        public System.Drawing.Image imageSelected;
        
        public WrapMode wrapMode = WrapMode.Tile; // default
        public  String imageLocation1;




        public TextureBrushForm()
        {
            InitializeComponent();
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
                    imageLocation1 = ofd.FileName;
                    
                }  
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            wrapMode = WrapMode.TileFlipY;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            wrapMode = WrapMode.TileFlipX;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            wrapMode = WrapMode.TileFlipXY;
        }
    }
}
