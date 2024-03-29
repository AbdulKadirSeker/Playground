﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTrade.Tools.Resizing;
using EasyTrade.Tools.Painting;

namespace EasyTrade
{
    public partial class Form1 : Form
    {
        public Resizer resizer;
        public FormColor fc;
        
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(750, 500);
            //this.BackColor = Color.MintCream;
            //fc = new FormColor(this, Color.White);
            //fc.ChangeFormBackcolor(Color.FromArgb(30, 30, 30));
            //fc.ChangeColor_PanPick(Color.LightBlue,Color.Maroon);
            resizer = new Resizer(this);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show($"{this.Controls.Count}");
            if (resizer != null)
            {
                resizer.Resize();
            }
        }
    }
}
