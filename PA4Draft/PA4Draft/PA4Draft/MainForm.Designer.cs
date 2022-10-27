﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace PA4Draft
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addASignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSignatureAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirroring = new System.Windows.Forms.ToolStripDropDownButton();
            this.defaultMirroring = new System.Windows.Forms.ToolStripMenuItem();
            this.xAxisMirroring = new System.Windows.Forms.ToolStripMenuItem();
            this.yAxisMirroring = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.brushButtons = new System.Windows.Forms.ToolStripDropDownButton();
            this.solidBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveAsImage = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tileDesign = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeList = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.addShapeButton = new System.Windows.Forms.Button();
            this.repsPerRow = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repsPerColumn = new System.Windows.Forms.NumericUpDown();
            this.shapeType = new System.Windows.Forms.ComboBox();
            this.preview = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileDesign)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repsPerRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsPerColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.mirroring,
            this.deleteButton,
            this.brushButtons,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1240, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addASignatureToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.saveSignatureAsToolStripMenuItem,
            this.removeSignatureToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 28);
            this.toolStripDropDownButton1.Text = "Signature";
            // 
            // addASignatureToolStripMenuItem
            // 
            this.addASignatureToolStripMenuItem.Name = "addASignatureToolStripMenuItem";
            this.addASignatureToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.addASignatureToolStripMenuItem.Text = "Add/update signature";
            this.addASignatureToolStripMenuItem.Click += new System.EventHandler(this.AddSignature_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.viewToolStripMenuItem.Text = "View signature";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.ViewSignature_Click);
            // 
            // saveSignatureAsToolStripMenuItem
            // 
            this.saveSignatureAsToolStripMenuItem.Name = "saveSignatureAsToolStripMenuItem";
            this.saveSignatureAsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.saveSignatureAsToolStripMenuItem.Text = "Save signature as...";
            this.saveSignatureAsToolStripMenuItem.Click += new System.EventHandler(this.saveSignatureAsToolStripMenuItem_Click);
            // 
            // removeSignatureToolStripMenuItem
            // 
            this.removeSignatureToolStripMenuItem.Name = "removeSignatureToolStripMenuItem";
            this.removeSignatureToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.removeSignatureToolStripMenuItem.Text = "Remove signature";
            this.removeSignatureToolStripMenuItem.Click += new System.EventHandler(this.RemoveSignature_Click);
            // 
            // mirroring
            // 
            this.mirroring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mirroring.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultMirroring,
            this.xAxisMirroring,
            this.yAxisMirroring});
            this.mirroring.Image = ((System.Drawing.Image)(resources.GetObject("mirroring.Image")));
            this.mirroring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mirroring.Name = "mirroring";
            this.mirroring.Size = new System.Drawing.Size(38, 28);
            this.mirroring.Text = "Tile Mirroring Style";
            // 
            // defaultMirroring
            // 
            this.defaultMirroring.Checked = true;
            this.defaultMirroring.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultMirroring.Name = "defaultMirroring";
            this.defaultMirroring.Size = new System.Drawing.Size(241, 26);
            this.defaultMirroring.Text = "Default (No Mirroring)";
            this.defaultMirroring.Click += new System.EventHandler(this.Default_Click);
            // 
            // xAxisMirroring
            // 
            this.xAxisMirroring.Name = "xAxisMirroring";
            this.xAxisMirroring.Size = new System.Drawing.Size(241, 26);
            this.xAxisMirroring.Text = "X-Axis";
            this.xAxisMirroring.Click += new System.EventHandler(this.XAxis_Click);
            // 
            // yAxisMirroring
            // 
            this.yAxisMirroring.Name = "yAxisMirroring";
            this.yAxisMirroring.Size = new System.Drawing.Size(241, 26);
            this.yAxisMirroring.Text = "Y-Axis";
            this.yAxisMirroring.Click += new System.EventHandler(this.YAxis_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Enabled = false;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(29, 28);
            this.deleteButton.Text = "Delete selected shape";
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // brushButtons
            // 
            this.brushButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidBrushToolStripMenuItem,
            this.textureBrushToolStripMenuItem,
            this.hatchBrushToolStripMenuItem,
            this.linearGradientBrushToolStripMenuItem});
            this.brushButtons.Enabled = false;
            this.brushButtons.Image = ((System.Drawing.Image)(resources.GetObject("brushButtons.Image")));
            this.brushButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushButtons.Name = "brushButtons";
            this.brushButtons.Size = new System.Drawing.Size(38, 28);
            this.brushButtons.Text = "Brush a shape";
            // 
            // solidBrushToolStripMenuItem
            // 
            this.solidBrushToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("solidBrushToolStripMenuItem.Image")));
            this.solidBrushToolStripMenuItem.Name = "solidBrushToolStripMenuItem";
            this.solidBrushToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.solidBrushToolStripMenuItem.Text = "Solid Brush";
            this.solidBrushToolStripMenuItem.Click += new System.EventHandler(this.SolidBrush_Click);
            // 
            // textureBrushToolStripMenuItem
            // 
            this.textureBrushToolStripMenuItem.Name = "textureBrushToolStripMenuItem";
            this.textureBrushToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.textureBrushToolStripMenuItem.Text = "Texture Brush";
            this.textureBrushToolStripMenuItem.Click += new System.EventHandler(this.TextureBrush_Click);
            // 
            // hatchBrushToolStripMenuItem
            // 
            this.hatchBrushToolStripMenuItem.Name = "hatchBrushToolStripMenuItem";
            this.hatchBrushToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.hatchBrushToolStripMenuItem.Text = "Hatch Brush";
            this.hatchBrushToolStripMenuItem.Click += new System.EventHandler(this.HatchBrush_Click);
            // 
            // linearGradientBrushToolStripMenuItem
            // 
            this.linearGradientBrushToolStripMenuItem.Name = "linearGradientBrushToolStripMenuItem";
            this.linearGradientBrushToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.linearGradientBrushToolStripMenuItem.Text = "Linear Gradient Brush";
            this.linearGradientBrushToolStripMenuItem.Click += new System.EventHandler(this.LinearGradient_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.Save_Click);
            // 
            // saveAsImage
            // 
            this.saveAsImage.Filter = "Image Files (.jpg,.png)|*.jpg;*.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tile Pattern";
            // 
            // tileDesign
            // 
            this.tileDesign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileDesign.ErrorImage = null;
            this.tileDesign.Location = new System.Drawing.Point(41, 76);
            this.tileDesign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileDesign.Name = "tileDesign";
            this.tileDesign.Size = new System.Drawing.Size(683, 630);
            this.tileDesign.TabIndex = 4;
            this.tileDesign.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "List of Shapes";
            // 
            // shapeList
            // 
            this.shapeList.FormattingEnabled = true;
            this.shapeList.HorizontalScrollbar = true;
            this.shapeList.ItemHeight = 16;
            this.shapeList.Location = new System.Drawing.Point(756, 76);
            this.shapeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(413, 212);
            this.shapeList.TabIndex = 6;
            this.shapeList.SelectedIndexChanged += new System.EventHandler(this.ShapeList_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 717);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1240, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(243, 20);
            this.toolStripStatusLabel1.Text = "Add a new shape to the tile pattern";
            // 
            // addShapeButton
            // 
            this.addShapeButton.Enabled = false;
            this.addShapeButton.Location = new System.Drawing.Point(997, 311);
            this.addShapeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(173, 28);
            this.addShapeButton.TabIndex = 8;
            this.addShapeButton.Text = "Add New Shape to Tile";
            this.addShapeButton.UseVisualStyleBackColor = true;
            this.addShapeButton.Click += new System.EventHandler(this.AddShapeClick);
            // 
            // repsPerRow
            // 
            this.repsPerRow.Location = new System.Drawing.Point(756, 438);
            this.repsPerRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repsPerRow.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.repsPerRow.Name = "repsPerRow";
            this.repsPerRow.Size = new System.Drawing.Size(66, 22);
            this.repsPerRow.TabIndex = 9;
            this.repsPerRow.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Tiles Per Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 475);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Tiles Per Column";
            // 
            // repsPerColumn
            // 
            this.repsPerColumn.Location = new System.Drawing.Point(756, 494);
            this.repsPerColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repsPerColumn.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.repsPerColumn.Name = "repsPerColumn";
            this.repsPerColumn.Size = new System.Drawing.Size(66, 22);
            this.repsPerColumn.TabIndex = 12;
            this.repsPerColumn.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // shapeType
            // 
            this.shapeType.FormattingEnabled = true;
            this.shapeType.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle"});
            this.shapeType.Location = new System.Drawing.Point(756, 314);
            this.shapeType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shapeType.Name = "shapeType";
            this.shapeType.Size = new System.Drawing.Size(160, 24);
            this.shapeType.TabIndex = 14;
            this.shapeType.Text = "Choose Shape Type";
            this.shapeType.SelectedIndexChanged += new System.EventHandler(this.shapeType_SelectedIndexChanged);
            // 
            // preview
            // 
            this.preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("preview.BackgroundImage")));
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.preview.Location = new System.Drawing.Point(1037, 418);
            this.preview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(133, 123);
            this.preview.TabIndex = 15;
            this.preview.Text = "Preview";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 602);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Wallpaper Height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(756, 622);
            this.heightInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightInput.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.heightInput.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(66, 22);
            this.heightInput.TabIndex = 18;
            this.heightInput.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 535);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Wallpaper Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(756, 555);
            this.widthInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthInput.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(66, 22);
            this.widthInput.TabIndex = 16;
            this.widthInput.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // up
            // 
            this.up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("up.BackgroundImage")));
            this.up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.up.Enabled = false;
            this.up.Location = new System.Drawing.Point(1179, 162);
            this.up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(29, 22);
            this.up.TabIndex = 20;
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.Up_Click);
            // 
            // down
            // 
            this.down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("down.BackgroundImage")));
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.down.Enabled = false;
            this.down.Location = new System.Drawing.Point(1179, 188);
            this.down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(29, 22);
            this.down.TabIndex = 21;
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.Down_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 743);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.shapeType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repsPerColumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repsPerRow);
            this.Controls.Add(this.addShapeButton);
            this.Controls.Add(this.shapeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tileDesign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Wallpaper Design";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileDesign)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repsPerRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsPerColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MirrorStyle mirrorStyle;
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object
        bool isMouseDown = new Boolean();//this is used to evaluate whether our mousebutton is down or not
        List<Shape> shapes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addASignatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private Bitmap signature;
        private System.Windows.Forms.SaveFileDialog saveAsImage;
        private System.Windows.Forms.ToolStripMenuItem saveSignatureAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSignatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton mirroring;
        private System.Windows.Forms.ToolStripMenuItem defaultMirroring;
        private System.Windows.Forms.ToolStripMenuItem xAxisMirroring;
        private System.Windows.Forms.ToolStripMenuItem yAxisMirroring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tileDesign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox shapeList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button addShapeButton;
        private System.Windows.Forms.NumericUpDown repsPerRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown repsPerColumn;
        private System.Windows.Forms.ComboBox shapeType;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripDropDownButton brushButtons;
        private System.Windows.Forms.ToolStripMenuItem solidBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textureBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearGradientBrushToolStripMenuItem;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
    }
}

