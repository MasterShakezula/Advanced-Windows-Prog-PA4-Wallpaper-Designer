using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class PickHatchBrush : Form
    {
        public PickHatchBrush()
        {
            InitializeComponent();
            foreach (string styleName in Enum.GetNames(typeof(HatchStyle)))
            {
                this.listBox1.Items.Add(styleName);
            }
            
            pickedColor = SystemColors.ButtonFace;
            
        }

        private void Color_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor = colorDialog1.Color;
            //pickedColor = Color.FromArgb((byte)opacity.Value,pickedColor.R,pickedColor.G,pickedColor.B);
            //color.BackColor = pickedColor;
        }

        private void ForegroundColorChange(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor = colorDialog1.Color;

            pickedColor = Color.FromArgb((byte) pickedColor.R, pickedColor.G, pickedColor.B);
            //color.BackColor = pickedColor;
        }

        private void BackgroundColorChange(object sender, EventArgs e)
        {

        }
    }
}
