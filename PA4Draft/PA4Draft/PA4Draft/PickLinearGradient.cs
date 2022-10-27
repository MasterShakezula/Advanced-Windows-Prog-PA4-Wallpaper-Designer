using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    
    
    public partial class PickLinearGradient : Form
    {
        public Color startingColors, endingColors;
        public int size, angle;

        public PickLinearGradient()
        {
            startingColors = new Color();
            endingColors = new Color();
            
            InitializeComponent();
            NumericUpDown numericUpDown1 = this.numericUpDown1;
            size = (int)numericUpDown1.Value;
            //pickedColor = SystemColors.ButtonFace;
        }

        private void startingColorChange(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                startingColors = colorDialog1.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = (int)numericUpDown1.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void horizontal_Checked(object sender, EventArgs e)
        {
            angle = 180;
        }

        private void vertical_Checked(object sender, EventArgs e)
        {
            angle = 90;
        }

        private void diagonal_CheckedChanged(object sender, EventArgs e)
        {
            angle = 45;
        }

        private void endingColorChange(object sender, EventArgs e)
        {
            DialogResult d = colorDialog2.ShowDialog();
            if (d == DialogResult.OK)
               endingColors = colorDialog2.Color;
        }
    }
}
