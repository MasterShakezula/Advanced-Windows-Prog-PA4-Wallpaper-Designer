using System.Drawing;

namespace PA4Draft
{
    partial class PickHatchBrush
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ForegroundColor = new System.Windows.Forms.Button();
            this.BackgroundColor = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(105, 375);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(112, 35);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(333, 375);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 35);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(105, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 164);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ForegroundColor
            // 
            this.ForegroundColor.Location = new System.Drawing.Point(333, 285);
            this.ForegroundColor.Name = "ForegroundColor";
            this.ForegroundColor.Size = new System.Drawing.Size(158, 41);
            this.ForegroundColor.TabIndex = 7;
            this.ForegroundColor.Text = "Foreground Color";
            this.ForegroundColor.UseVisualStyleBackColor = true;
            this.ForegroundColor.Click += new System.EventHandler(this.ForegroundColorChange);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.Location = new System.Drawing.Point(105, 285);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(167, 51);
            this.BackgroundColor.TabIndex = 8;
            this.BackgroundColor.Text = "Background Color";
            this.BackgroundColor.UseVisualStyleBackColor = true;
            this.BackgroundColor.Click += new System.EventHandler(this.BackgroundColorChange);
            // 
            // PickHatchBrush
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(574, 429);
            this.Controls.Add(this.BackgroundColor);
            this.Controls.Add(this.ForegroundColor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PickHatchBrush";
            this.Text = "Pick Hatch Brush";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        internal Color pickedColor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ForegroundColor;
        private System.Windows.Forms.Button BackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}