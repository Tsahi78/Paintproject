namespace Paintproject
{
    partial class Paintform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Fileoptions = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rotate = new System.Windows.Forms.Button();
            this.Zoomout = new System.Windows.Forms.Button();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.PictureView = new System.Windows.Forms.ComboBox();
            this.PicView = new System.Windows.Forms.Label();
            this.backColors = new System.Windows.Forms.PictureBox();
            this.backColor = new System.Windows.Forms.Label();
            this.Pen_Size = new System.Windows.Forms.ComboBox();
            this.PenSize = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.Color = new System.Windows.Forms.Label();
            this.DrawStail = new System.Windows.Forms.Label();
            this.DrawStyle = new System.Windows.Forms.ComboBox();
            this.RotatePanel = new System.Windows.Forms.Panel();
            this.FlipY = new System.Windows.Forms.Button();
            this.Flipx = new System.Windows.Forms.Button();
            this.Rotate270 = new System.Windows.Forms.Button();
            this.Rotate180 = new System.Windows.Forms.Button();
            this.Rotate90 = new System.Windows.Forms.Button();
            this.PaintBox = new System.Windows.Forms.PictureBox();
            this.ColorSelect = new System.Windows.Forms.ColorDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            this.RotatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fileoptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Fileoptions
            // 
            this.Fileoptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.Fileoptions.Name = "Fileoptions";
            this.Fileoptions.Size = new System.Drawing.Size(37, 20);
            this.Fileoptions.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.newToolStripMenuItem.Text = "new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.saveAsToolStripMenuItem.Text = "save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rotate);
            this.panel1.Controls.Add(this.Zoomout);
            this.panel1.Controls.Add(this.ZoomIn);
            this.panel1.Controls.Add(this.PictureView);
            this.panel1.Controls.Add(this.PicView);
            this.panel1.Controls.Add(this.backColors);
            this.panel1.Controls.Add(this.backColor);
            this.panel1.Controls.Add(this.Pen_Size);
            this.panel1.Controls.Add(this.PenSize);
            this.panel1.Controls.Add(this.ColorBox);
            this.panel1.Controls.Add(this.Color);
            this.panel1.Controls.Add(this.DrawStail);
            this.panel1.Controls.Add(this.DrawStyle);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 60);
            this.panel1.TabIndex = 2;
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(925, 26);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(75, 23);
            this.Rotate.TabIndex = 12;
            this.Rotate.Text = "סיבוב";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // Zoomout
            // 
            this.Zoomout.Location = new System.Drawing.Point(828, 26);
            this.Zoomout.Name = "Zoomout";
            this.Zoomout.Size = new System.Drawing.Size(75, 23);
            this.Zoomout.TabIndex = 11;
            this.Zoomout.Text = "הקטנה";
            this.Zoomout.UseVisualStyleBackColor = true;
            this.Zoomout.Click += new System.EventHandler(this.Zoomout_Click);
            // 
            // ZoomIn
            // 
            this.ZoomIn.Location = new System.Drawing.Point(729, 26);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(75, 23);
            this.ZoomIn.TabIndex = 10;
            this.ZoomIn.Text = "הגדלה";
            this.ZoomIn.UseVisualStyleBackColor = true;
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // PictureView
            // 
            this.PictureView.FormattingEnabled = true;
            this.PictureView.Items.AddRange(new object[] {
            "Zoom",
            "Strech",
            "Normal"});
            this.PictureView.Location = new System.Drawing.Point(566, 36);
            this.PictureView.Name = "PictureView";
            this.PictureView.Size = new System.Drawing.Size(121, 21);
            this.PictureView.TabIndex = 9;
            this.PictureView.TextChanged += new System.EventHandler(this.PictureView_TextChanged);
            // 
            // PicView
            // 
            this.PicView.AutoSize = true;
            this.PicView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PicView.Location = new System.Drawing.Point(582, 13);
            this.PicView.Name = "PicView";
            this.PicView.Size = new System.Drawing.Size(105, 20);
            this.PicView.TabIndex = 8;
            this.PicView.Text = "תצוגת תמונה";
            // 
            // backColors
            // 
            this.backColors.BackColor = System.Drawing.Color.White;
            this.backColors.Location = new System.Drawing.Point(434, 36);
            this.backColors.Name = "backColors";
            this.backColors.Size = new System.Drawing.Size(100, 20);
            this.backColors.TabIndex = 7;
            this.backColors.TabStop = false;
            this.backColors.Click += new System.EventHandler(this.backColors_Click);
            // 
            // backColor
            // 
            this.backColor.AutoSize = true;
            this.backColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backColor.Location = new System.Drawing.Point(447, 12);
            this.backColor.Name = "backColor";
            this.backColor.Size = new System.Drawing.Size(76, 20);
            this.backColor.TabIndex = 6;
            this.backColor.Text = "צבע רקע";
            // 
            // Pen_Size
            // 
            this.Pen_Size.FormattingEnabled = true;
            this.Pen_Size.Location = new System.Drawing.Point(271, 35);
            this.Pen_Size.Name = "Pen_Size";
            this.Pen_Size.Size = new System.Drawing.Size(121, 21);
            this.Pen_Size.TabIndex = 5;
            this.Pen_Size.TextChanged += new System.EventHandler(this.Pen_Size_TextChanged);
            // 
            // PenSize
            // 
            this.PenSize.AutoSize = true;
            this.PenSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PenSize.Location = new System.Drawing.Point(283, 12);
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(91, 20);
            this.PenSize.TabIndex = 4;
            this.PenSize.Text = "עובי עפרון";
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorBox.Location = new System.Drawing.Point(142, 36);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(100, 20);
            this.ColorBox.TabIndex = 3;
            this.ColorBox.TabStop = false;
            this.ColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Color.Location = new System.Drawing.Point(181, 13);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(40, 20);
            this.Color.TabIndex = 2;
            this.Color.Text = "צבע";
            // 
            // DrawStail
            // 
            this.DrawStail.AutoSize = true;
            this.DrawStail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DrawStail.Location = new System.Drawing.Point(12, 13);
            this.DrawStail.Name = "DrawStail";
            this.DrawStail.Size = new System.Drawing.Size(85, 20);
            this.DrawStail.TabIndex = 1;
            this.DrawStail.Text = "סגנון ציור";
            // 
            // DrawStyle
            // 
            this.DrawStyle.FormattingEnabled = true;
            this.DrawStyle.Items.AddRange(new object[] {
            "חופשי",
            "קו",
            "אליפסה"});
            this.DrawStyle.Location = new System.Drawing.Point(3, 36);
            this.DrawStyle.Name = "DrawStyle";
            this.DrawStyle.Size = new System.Drawing.Size(121, 21);
            this.DrawStyle.TabIndex = 0;
            // 
            // RotatePanel
            // 
            this.RotatePanel.Controls.Add(this.FlipY);
            this.RotatePanel.Controls.Add(this.Flipx);
            this.RotatePanel.Controls.Add(this.Rotate270);
            this.RotatePanel.Controls.Add(this.Rotate180);
            this.RotatePanel.Controls.Add(this.Rotate90);
            this.RotatePanel.Location = new System.Drawing.Point(911, 93);
            this.RotatePanel.Name = "RotatePanel";
            this.RotatePanel.Size = new System.Drawing.Size(107, 170);
            this.RotatePanel.TabIndex = 3;
            this.RotatePanel.Visible = false;
            // 
            // FlipY
            // 
            this.FlipY.Location = new System.Drawing.Point(18, 130);
            this.FlipY.Name = "FlipY";
            this.FlipY.Size = new System.Drawing.Size(75, 23);
            this.FlipY.TabIndex = 4;
            this.FlipY.Text = "Y ציר";
            this.FlipY.UseVisualStyleBackColor = true;
            this.FlipY.Click += new System.EventHandler(this.FlipY_Click);
            // 
            // Flipx
            // 
            this.Flipx.Location = new System.Drawing.Point(18, 101);
            this.Flipx.Name = "Flipx";
            this.Flipx.Size = new System.Drawing.Size(75, 23);
            this.Flipx.TabIndex = 3;
            this.Flipx.Text = "X ציר";
            this.Flipx.UseVisualStyleBackColor = true;
            this.Flipx.Click += new System.EventHandler(this.Flipx_Click);
            // 
            // Rotate270
            // 
            this.Rotate270.Location = new System.Drawing.Point(18, 72);
            this.Rotate270.Name = "Rotate270";
            this.Rotate270.Size = new System.Drawing.Size(75, 23);
            this.Rotate270.TabIndex = 2;
            this.Rotate270.Text = "270";
            this.Rotate270.UseVisualStyleBackColor = true;
            this.Rotate270.Click += new System.EventHandler(this.Rotate270_Click);
            // 
            // Rotate180
            // 
            this.Rotate180.Location = new System.Drawing.Point(18, 43);
            this.Rotate180.Name = "Rotate180";
            this.Rotate180.Size = new System.Drawing.Size(75, 23);
            this.Rotate180.TabIndex = 1;
            this.Rotate180.Text = "180";
            this.Rotate180.UseVisualStyleBackColor = true;
            this.Rotate180.Click += new System.EventHandler(this.Rotate180_Click);
            // 
            // Rotate90
            // 
            this.Rotate90.Location = new System.Drawing.Point(18, 14);
            this.Rotate90.Name = "Rotate90";
            this.Rotate90.Size = new System.Drawing.Size(75, 23);
            this.Rotate90.TabIndex = 0;
            this.Rotate90.Text = "90";
            this.Rotate90.UseVisualStyleBackColor = true;
            this.Rotate90.Click += new System.EventHandler(this.Rotate90_Click);
            // 
            // PaintBox
            // 
            this.PaintBox.BackColor = System.Drawing.Color.White;
            this.PaintBox.Location = new System.Drawing.Point(43, 107);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(835, 419);
            this.PaintBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaintBox.TabIndex = 4;
            this.PaintBox.TabStop = false;
            this.PaintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseClick);
            this.PaintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.PaintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.PaintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // Paintform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.PaintBox);
            this.Controls.Add(this.RotatePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paintform";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paintform_Load);
            this.Resize += new System.EventHandler(this.Paintform_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            this.RotatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Fileoptions;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DrawStail;
        private System.Windows.Forms.ComboBox DrawStyle;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button Zoomout;
        private System.Windows.Forms.Button ZoomIn;
        private System.Windows.Forms.ComboBox PictureView;
        private System.Windows.Forms.Label PicView;
        private System.Windows.Forms.PictureBox backColors;
        private System.Windows.Forms.Label backColor;
        private System.Windows.Forms.ComboBox Pen_Size;
        private System.Windows.Forms.Label PenSize;
        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Panel RotatePanel;
        private System.Windows.Forms.Button FlipY;
        private System.Windows.Forms.Button Flipx;
        private System.Windows.Forms.Button Rotate270;
        private System.Windows.Forms.Button Rotate180;
        private System.Windows.Forms.Button Rotate90;
        private System.Windows.Forms.PictureBox PaintBox;
        private System.Windows.Forms.ColorDialog ColorSelect;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}

