using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Paintproject
{
    public partial class Paintform : Form
    {
        private Bitmap Img;
        private Graphics g;
        private Image ImageFile;
        private int StartX;
        private int StartY;
        private int EndX;
        private int EndY;
        private Pen pencel;
        private bool Flag;
        Point LastPoint = Point.Empty;
        bool IsMouseDwon = new Boolean();


        public Paintform()
        {
            InitializeComponent();
        }
     

        private void Paintform_Load(object sender, EventArgs e)
        {
            clearPictureBox();
            pencel = new Pen(ColorBox.BackColor, getWidth(Pen_Size));
            PictureView.Text = PictureView.Items[0].ToString();
            DrawStyle.Text = DrawStyle.Items[0].ToString();
            for (int i = 2; i < 30; i+=2)
            {
                Pen_Size.Items.Add(i);
            }
            Pen_Size.Text = Pen_Size.Items[0].ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearPictureBox();
        }

        // clear picture box//

        private void clearPictureBox()
        {
            Img = new Bitmap(PaintBox.Width, PaintBox.Height);
            g = Graphics.FromImage(Img);
            g.Clear(backColors.BackColor);
            PaintBox.Image = Img;
        }
         
        // open image files//
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile.FileName = string.Empty;
           OpenFile.Filter = "קבצי תמונה(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (OpenFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ImageFile = Image.FromFile(OpenFile.FileName);
                Img = (Bitmap)ImageFile;
                g = Graphics.FromImage(Img);
                PaintBox.Image = Img;
            }
        }
        // save image files//
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaintBox.Image.Save(Application.StartupPath + "\\1.jpg",ImageFormat.Jpeg);
        }
        //save image file to location in computer//
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile.Filter = "Jpeg image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            ImageFormat ImageF = ImageFormat.Png;
            if (SaveFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                switch (SaveFile.FilterIndex)
                {
                    case 1:
                        ImageF = ImageFormat.Jpeg;
                        break;
                    case 2:
                        ImageF = ImageFormat.Bmp;
                        break;
                    case 3:
                        ImageF = ImageFormat.Gif;
                        break;
                }
                PaintBox.Image.Save(SaveFile.FileName, ImageF);
            }

        }
        //exit from application//
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (DrawStyle.Text=="חופשי")
            {
                LastPoint = Point_Initialization(Img, e.X, e.Y);
                IsMouseDwon = true;


            }
        }

        private Point Point_Initialization(Bitmap Img, int p1, int p2)
        {
            int heightB = Img.Height;
            int heightP = Img.Height;
            int widthB = Img.Width;
            int widthP = Img.Width;
            double Xratio = (double)widthB / (double)widthP;
            double Yratio = (double)heightB / (double)heightP;
            Point point = new Point();
            if (PaintBox.SizeMode==PictureBoxSizeMode.StretchImage)
            {
                point.X = (int)(p1 * Xratio);
                point.Y = (int)(p2 * Yratio);
            }
            else if (PaintBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                double rat = Xratio;
                bool x_filed = true;
                if (rat<Yratio)
                {
                    rat = Yratio;
                    x_filed = false;
                    
                }
                if (x_filed)
                {
                    heightB = (int)(heightB / rat);
                    int Board_Height = (heightP - heightB) / 2;
                    point.X = (int)(p1 * rat);
                    point.Y = (int)((p2 - Board_Height) * rat);

                }
                else
                {
                    widthB = (int)(widthB / rat);
                    int Board_Width = (widthP - widthP) / 2;
                    point.X = (int)((p1 - Board_Width) * rat);
                    point.Y = (int)(p2 * rat);
                }
            }
            else
            {
                point.X = p1;
                point.Y = p2;
            }
            return point;
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDwon == true)  //  if mouse is clicked///
            {
                if (LastPoint!=null) 
                {
                    g.DrawLine(pencel, LastPoint, Point_Initialization(Img, e.X, e.Y));
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    PaintBox.Invalidate();  //  refresh picturebox//
                    LastPoint = Point_Initialization(Img, e.X, e.Y); //update last point position//
                }
            }
        }

        private void Pen_Size_TextChanged(object sender, EventArgs e)
        {
            pencel.Width = getWidth(Pen_Size);
        }

        private float getWidth(ComboBox Pen_Size)
        {
            float Size;
            try
            {
                float.TryParse(Pen_Size.Text.ToString(), out Size);
            }
            catch(Exception)
            {
                Size = 2;
                Pen_Size.Text = Pen_Size.Items[0].ToString();
             }
            return Size;
        }

        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (DrawStyle.Text=="חופשי")
            {
                IsMouseDwon = false;
                LastPoint = Point.Empty;
            }
        }

        private void PaintBox_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = Point_Initialization(Img, e.X, e.Y);
            if (Flag == false)
            {
                StartX = point.X;    //first click we get the 2 start points//
                StartY = point.Y;
                Flag = true;
            }
            else
            {
                EndX = point.X;      // second click we get the end points (flag=false)//
                EndY = point.Y;
                switch (DrawStyle.Text)
                {
                    case "קו":
                        g.DrawLine(pencel, StartX, StartY, EndX, EndY);
                        break;
                    case "אליפסה":
                        g.DrawEllipse(pencel, StartX, StartY, EndX - StartX, EndY - StartY);
                        break;
                }
                PaintBox.Refresh();
                Flag = false;
            }
        }

        private void ColorBox_Click(object sender, EventArgs e)
        {
            if (ColorSelect.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ColorBox.BackColor = ColorSelect.Color;
                pencel.Color = ColorSelect.Color;
            }
        }

        private void backColors_Click(object sender, EventArgs e)
        {
            if (ColorSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PaintBox.BackColor = ColorSelect.Color;
                g.Clear(ColorSelect.Color);
                PaintBox.Refresh();
            }
        }

        private void PictureView_TextChanged(object sender, EventArgs e)
        {
            switch (PictureView.Text)
            {
                case "Zoom":
                    PaintBox.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case"Strech":
                    PaintBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Normal":
                    PaintBox.SizeMode = PictureBoxSizeMode.Normal;
                    break;
            }
            PaintBox.Refresh();
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            PaintBox.Height += 50;
            PaintBox.Width += 50;
        }

        private void Zoomout_Click(object sender, EventArgs e)
        {
            PaintBox.Height -= 50;
            PaintBox.Width -= 50;
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (!RotatePanel.Visible)
            {
                RotatePanel.Visible = true;
            }
            else
            {
                RotatePanel.Visible = false;
            }
        }

        private void Rotate90_Click(object sender, EventArgs e)
        {
            PaintBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Img = new Bitmap(PaintBox.Image);
            g = Graphics.FromImage(Img);
            PaintBox.Image = Img;
            PaintBox.Refresh();
            RotatePanel.Visible = false;
        }

        private void Rotate180_Click(object sender, EventArgs e)
        {
            PaintBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            Img = new Bitmap(PaintBox.Image);
            g = Graphics.FromImage(Img);
            PaintBox.Image = Img;
            PaintBox.Refresh();
            RotatePanel.Visible = false;
        }

        private void Rotate270_Click(object sender, EventArgs e)
        {
            PaintBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Img = new Bitmap(PaintBox.Image);
            g = Graphics.FromImage(Img);
            PaintBox.Image = Img;
            PaintBox.Refresh();
            RotatePanel.Visible = false;
        }

        private void Flipx_Click(object sender, EventArgs e)
        {
            PaintBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Img = new Bitmap(PaintBox.Image);
            g = Graphics.FromImage(Img);
            PaintBox.Image = Img;
            PaintBox.Refresh();
            RotatePanel.Visible = false;
        }

        private void FlipY_Click(object sender, EventArgs e)
        {
            PaintBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Img = new Bitmap(PaintBox.Image);
            g = Graphics.FromImage(Img);
            PaintBox.Image = Img;
            PaintBox.Refresh();
            RotatePanel.Visible = false;
        }

        private void Paintform_Resize(object sender, EventArgs e)
        {
            PaintBox.Width = this.Width - 2 * PaintBox.Left;
            PaintBox.Height = this.Height - 2 * PaintBox.Top;
            PaintBox.Refresh();
        }

       
    }
}
