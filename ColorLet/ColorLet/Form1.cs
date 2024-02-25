using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorLet.Resizing;

namespace ColorLet
{
    struct Pipette
    {
        public bool pipetteActive;
        public bool pipetteFrom;
        public bool pippeteTo;
        public void Initialize()
        {
            pipetteActive = false;
            pipetteFrom = true;
            pippeteTo = false;
        }
    }
    struct ColorLabel
    {
        public int fsz;
        public int sz;
        public Label lbl;
        public int prevpicWmsz;
        public ColorLabel(int fontsize, int labelsize, PictureBox pic)
        {
            fsz = fontsize;
            sz = labelsize;
            prevpicWmsz = pic.Size.Width;
            lbl = new Label();
            Setup_lbl(pic);
        }
        private void Setup_lbl(PictureBox pic) 
        {
            lbl.AutoSize = false;
            lbl.Size = new Size(sz, sz);
            lbl.Font = new Font("Microsoft Sans Serif", fsz);
            lbl.Visible = false;
            pic.Controls.Add(lbl);
        }
        public void Resize(PictureBox pic) 
        {
            double ratio = (double)prevpicWmsz / pic.Size.Width;
            fsz = (int)(fsz / ratio);
            sz = (int)(sz / ratio);
            prevpicWmsz = pic.Size.Width;
            lbl.Size = new Size(sz, sz);
            lbl.Font = new Font("Microsoft Sans Serif", fsz);
        }
    }
    public partial class Form1 : Form
    {
        private ColorLabel colorLabel;
        private Pipette pipetteData;
        private Bitmap B2;
        int colorLabelOffset = 1;
        Resizer resizer;
        //List<Control> start = new List<Control>();
        public Form1()
        {
            InitializeComponent();
            lbl_DescriptionFrom.ForeColor = Color.White;
            lbl_DescriptionTo.ForeColor = Color.White;
            lbl_DescriptionPipette.ForeColor = Color.White;
            resizer = new Resizer(this);
            this.BackColor = Color.FromArgb(30,30,30);
            pipetteData.Initialize();
            colorLabel = new ColorLabel(8,30,pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!pipetteData.pipetteActive)
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Image | *.png; .jpg";
                fd.FileOk += fd_FileOK;
                fd.ShowDialog();
            }
        }

        private void fd_FileOK(object sender, CancelEventArgs e)
        {
            OpenFileDialog open = sender as OpenFileDialog;
            Bitmap b1 = new Bitmap(open.FileName);
            B2 = new Bitmap(b1, new Size(pictureBox1.Size.Width, pictureBox1.Size.Height));
            pictureBox1.Image = B2;
        }

        private void lbl_ColorFrom_Click(object sender, EventArgs e)
        {
            if (pan_Pippete.BackColor == Color.DarkRed)
            {
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Label l = sender as Label;
                    l.BackColor = cd.Color;
                }
            }
            else if (pan_Pippete.BackColor == Color.Green)
            {
                pipetteData.pipetteFrom = true;
                pipetteData.pippeteTo = false;
            }
            else return;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            Bitmap B3 = new Bitmap(B2.Width, B2.Height);
            for (int x = 0; x < B2.Width; x++)
            {
                for(int y = 0; y < B2.Height; y++)
                {
                    Color pixelColor = B2.GetPixel(x, y);
                    if (pixelColor == lbl_ColorFrom.BackColor) B3.SetPixel(x, y, lbl_ColorTo.BackColor);
                    else B3.SetPixel(x, y, pixelColor);
                }
            }
            B2 = B3;
            pictureBox1.Image = B3;
            //B3.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\a.png");
        }

        private void pic_Pipette_Click(object sender, EventArgs e)
        {
            void changeState()
            {
                if (pan_Pippete.BackColor == Color.DarkRed && pictureBox1.Image != null)
                {
                    pan_Pippete.BackColor = Color.Green;
                    pipetteData.pipetteActive = true;
                }
                else if(pan_Pippete.BackColor == Color.Green)
                {
                    pipetteData.pipetteActive = false;
                    pan_Pippete.BackColor = Color.DarkRed;
                }
                else return;
            }
            changeState();
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pipetteData.pipetteActive && pipetteData.pipetteFrom)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color clickedColor = bmp.GetPixel(e.X, e.Y);
                lbl_ColorFrom.BackColor = clickedColor;
                pipetteData.pipetteActive = false;
                pan_Pippete.BackColor = Color.DarkRed;
                // Do something with the clicked color
                //ShowColorInfo(clickedColor);
            }
            else if (pipetteData.pipetteActive && pipetteData.pippeteTo)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color clickedColor = bmp.GetPixel(e.X, e.Y);
                lbl_ColorTo.BackColor = clickedColor;
                pipetteData.pipetteActive = false;
                pan_Pippete.BackColor = Color.DarkRed;
            }
            else return;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            pipetteData.pipetteActive = false;
            //picturebox
            pictureBox1.Image = null;
            //Labels
            lbl_ColorFrom.BackColor = Color.DarkGray;
            lbl_ColorTo.BackColor = Color.DarkGray;
            //Panel pipette
            pan_Pippete.BackColor = Color.DarkRed;
            
        }

        private void lbl_ColorTo_Click(object sender, EventArgs e)
        {
            if (pan_Pippete.BackColor == Color.DarkRed)
            {
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Label l = sender as Label;
                    l.BackColor = cd.Color;
                }
            }
            else if (pan_Pippete.BackColor == Color.Green)
            {
                pipetteData.pipetteFrom = false;
                pipetteData.pippeteTo = true;
            }
            else return;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Color ForeColorAdjuuster(Color col)
            {
                // use the limunance formula 0.299 * R + 0.587 * G + 0.114 * B, where R,
                double luminance = 0.299 * col.R + 0.587 * col.G + 0.114 * col.B;
                return luminance > 128 ? Color.Black : Color.White;

            }
            if (pictureBox1.Image != null && pipetteData.pipetteActive)
            {
                // Get the mouse cursor position in screen coordinates
                Point screenPoint = Control.MousePosition;

                // Convert screen coordinates to client coordinates of the PictureBox
                Point clientPoint = pictureBox1.PointToClient(screenPoint);

                // Check if the mouse is within the bounds of the PictureBox
                if (clientPoint.X >= 0 && clientPoint.X < pictureBox1.Width &&
                    clientPoint.Y >= 0 && clientPoint.Y < pictureBox1.Height)
                {
                    // Get the color of the pixel at the mouse cursor position
                    Color pixelColor = B2.GetPixel(clientPoint.X, clientPoint.Y);

                    // Set the background color of the label to the pixel color
                    colorLabel.lbl.Visible = true;
                    colorLabel.lbl.Location = new Point(clientPoint.X + colorLabelOffset, clientPoint.Y - colorLabel.lbl.Height - colorLabelOffset);
                    colorLabel.lbl.BackColor = pixelColor;
                    colorLabel.lbl.ForeColor = ForeColorAdjuuster(pixelColor); 
                    colorLabel.lbl.Text = $"X: {clientPoint.X}{System.Environment.NewLine}Y: {clientPoint.Y}";
                    

                    colorLabel.lbl.Visible = true;
                }
                else
                {
                    colorLabel.lbl.Visible = false;
                }
            }
            else
            {
                colorLabel.lbl.Visible = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (resizer != null)
            {
                resizer.Resize();
                if (pictureBox1.Image != null)
                {
                    Bitmap b1 = new Bitmap(pictureBox1.Image);
                    B2 = new Bitmap(b1,pictureBox1.Size.Width, pictureBox1.Size.Height);
                    pictureBox1.Image = B2;
                    colorLabel.Resize(pictureBox1);
                }
            }
        }
    }
}
