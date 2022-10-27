using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class TextureBrushForm : Form
    {
        System.Drawing.Image imageSelected;
        public int xAxis = 1;  //if radioButton checked, becomes -1, flip
        public int yAxis = 1;    //y checked, y flip, if both checked, both -1, flip on both axis
        public int xyAxis = 1;
        
        

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
                    String imageLocation1 = ofd.FileName;
                    
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            xyAxis *= -1;
        }
    }
}
