using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorLet.Resizing
{
    public class Resizer
    {
        public Form form;
        public List<(string, Rectangle)> originalSizes;
        public Rectangle originalForm;

        public Resizer(Form form)
        {
            this.form = form;
            originalSizes = new List<(string, Rectangle)>();
            originalForm = new Rectangle(form.Location.X, form.Location.Y, form.Size.Width, form.Size.Height);
            AddControls();

        }
        private void AddControls()
        {
            void Add(Control c)
            {
                originalSizes.Add((c.Name, new Rectangle(c.Location.X, c.Location.Y, c.Size.Width, c.Size.Height)));
            }
            if(form != null)
            {
                foreach(Control c in form.Controls)
                {
                    if(c is Panel panel) 
                    {
                        Add(c);
                        foreach (Control cp in panel.Controls)
                        {
                            Add(cp);
                        }
                    }
                    else
                    {
                        Add(c);
                    }
                }
            }
        }
        public void Resize()
        {
            void Operate(Control c, double Wrat, double Hrat)
            {
                var originalSize = originalSizes.Find(item => item.Item1 == c.Name).Item2;

                int newX = (int)(originalSize.X / Wrat);
                int newY = (int)(originalSize.Y / Hrat);
                int newWidth = (int)(originalSize.Width / Wrat);
                int newHeight = (int)(originalSize.Height / Hrat);

                c.Location = new Point(newX, newY);
                c.Size = new Size(newWidth, newHeight);
            }
            double Wratio = (double)originalForm.Width / form.ClientRectangle.Width;
            double Hratio = (double)originalForm.Height / form.ClientRectangle.Height;

            foreach (Control c in form.Controls)
            {
                // Special handling for PictureBox
                if(c is Panel panel)
                {
                    Operate(c,Wratio,Hratio);
                    if (panel.Controls.Count > 0)
                    {
                        foreach(Control cp in panel.Controls)
                        {
                            Operate(cp, Wratio, Hratio);
                        }
                    }
                }
                //else if(c is Label lbl)
                //{
                //    string fn = lbl.Font.Name;
                //    float fsz = (float)lbl.Font.Size / (float)Wratio;
                //    lbl.Font = new Font(fn, fsz);
                //    Operate(c, Wratio, Hratio);
                //}
                else
                {
                    Operate(c, Wratio, Hratio);
                }
            }
        }

    }
}
