using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EasyTrade.Tools.Painting
{
    public class FormColor
    {
        private Form form;
        private Panel panel;
        private Color picForeColor = Color.White;
        private Color picBackColor;

        public FormColor(Form form, Color picForeColor)
        {
            this.form = form;
            this.picForeColor = picForeColor;
            panel = form.Controls.OfType<Panel>().First();
            picBackColor = form.BackColor;
        }
        public void ChangeFormBackcolor(Color newColor)
        {
            form.BackColor = newColor;
        }
        public void ChangeColor_PanPick(Color newForeColor, Color newBackColor)
        {
            void Change(ref PictureBox pb, Color from, Color toForeColor, Color toBackColor)
            {
                Bitmap bmp = new Bitmap(pb.Image);
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        if (pixelColor == from)
                        {
                            // Check if the pixel color is equal to the current ForeColor,
                            // if yes, set it to the new ForeColor; otherwise, set it to the new BackColor.
                            bmp.SetPixel(x, y, (from == picForeColor) ? toForeColor : toBackColor);
                        }
                    }
                }
                pb.Image = bmp;
            }


            // Change panel color
            if (panel != null)
            {
                panel.BackColor = newBackColor;
                foreach (Control cp in panel.Controls)
                {
                    if (cp is PictureBox pictureBox)
                    {
                        // Change forecolor and backcolor
                        Change(ref pictureBox, picForeColor, newForeColor, newBackColor);
                    }
                }
                picBackColor = newBackColor;
                picForeColor = newForeColor;
            }
            
        }


    }
}
