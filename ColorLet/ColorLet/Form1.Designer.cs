namespace ColorLet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Change = new System.Windows.Forms.Button();
            this.lbl_ColorFrom = new System.Windows.Forms.Label();
            this.lbl_ColorTo = new System.Windows.Forms.Label();
            this.lbl_DescriptionFrom = new System.Windows.Forms.Label();
            this.lbl_DescriptionTo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_Pipette = new System.Windows.Forms.PictureBox();
            this.pan_Pippete = new System.Windows.Forms.Panel();
            this.lbl_DescriptionPipette = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pipette)).BeginInit();
            this.pan_Pippete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Change.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Change.Location = new System.Drawing.Point(16, 603);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(483, 143);
            this.btn_Change.TabIndex = 1;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // lbl_ColorFrom
            // 
            this.lbl_ColorFrom.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_ColorFrom.Location = new System.Drawing.Point(760, 659);
            this.lbl_ColorFrom.Name = "lbl_ColorFrom";
            this.lbl_ColorFrom.Size = new System.Drawing.Size(80, 80);
            this.lbl_ColorFrom.TabIndex = 2;
            this.lbl_ColorFrom.Click += new System.EventHandler(this.lbl_ColorFrom_Click);
            // 
            // lbl_ColorTo
            // 
            this.lbl_ColorTo.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_ColorTo.Location = new System.Drawing.Point(932, 659);
            this.lbl_ColorTo.Name = "lbl_ColorTo";
            this.lbl_ColorTo.Size = new System.Drawing.Size(80, 80);
            this.lbl_ColorTo.TabIndex = 3;
            this.lbl_ColorTo.Click += new System.EventHandler(this.lbl_ColorTo_Click);
            // 
            // lbl_DescriptionFrom
            // 
            this.lbl_DescriptionFrom.AutoSize = true;
            this.lbl_DescriptionFrom.Location = new System.Drawing.Point(760, 618);
            this.lbl_DescriptionFrom.Name = "lbl_DescriptionFrom";
            this.lbl_DescriptionFrom.Size = new System.Drawing.Size(80, 32);
            this.lbl_DescriptionFrom.TabIndex = 4;
            this.lbl_DescriptionFrom.Text = "From";
            // 
            // lbl_DescriptionTo
            // 
            this.lbl_DescriptionTo.AutoSize = true;
            this.lbl_DescriptionTo.Location = new System.Drawing.Point(932, 618);
            this.lbl_DescriptionTo.Name = "lbl_DescriptionTo";
            this.lbl_DescriptionTo.Size = new System.Drawing.Size(48, 32);
            this.lbl_DescriptionTo.TabIndex = 5;
            this.lbl_DescriptionTo.Text = "To";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(866, 680);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pic_Pipette
            // 
            this.pic_Pipette.Image = ((System.Drawing.Image)(resources.GetObject("pic_Pipette.Image")));
            this.pic_Pipette.Location = new System.Drawing.Point(10, 10);
            this.pic_Pipette.Name = "pic_Pipette";
            this.pic_Pipette.Size = new System.Drawing.Size(60, 60);
            this.pic_Pipette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Pipette.TabIndex = 7;
            this.pic_Pipette.TabStop = false;
            this.pic_Pipette.Click += new System.EventHandler(this.pic_Pipette_Click);
            // 
            // pan_Pippete
            // 
            this.pan_Pippete.BackColor = System.Drawing.Color.DarkRed;
            this.pan_Pippete.Controls.Add(this.pic_Pipette);
            this.pan_Pippete.Location = new System.Drawing.Point(654, 659);
            this.pan_Pippete.Name = "pan_Pippete";
            this.pan_Pippete.Size = new System.Drawing.Size(80, 80);
            this.pan_Pippete.TabIndex = 8;
            // 
            // lbl_DescriptionPipette
            // 
            this.lbl_DescriptionPipette.AutoSize = true;
            this.lbl_DescriptionPipette.Location = new System.Drawing.Point(648, 618);
            this.lbl_DescriptionPipette.Name = "lbl_DescriptionPipette";
            this.lbl_DescriptionPipette.Size = new System.Drawing.Size(105, 32);
            this.lbl_DescriptionPipette.TabIndex = 9;
            this.lbl_DescriptionPipette.Text = "Pipette";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(506, 603);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(124, 143);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 756);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_DescriptionPipette);
            this.Controls.Add(this.pan_Pippete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_DescriptionTo);
            this.Controls.Add(this.lbl_DescriptionFrom);
            this.Controls.Add(this.lbl_ColorTo);
            this.Controls.Add(this.lbl_ColorFrom);
            this.Controls.Add(this.btn_Change);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pipette)).EndInit();
            this.pan_Pippete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label lbl_ColorFrom;
        private System.Windows.Forms.Label lbl_ColorTo;
        private System.Windows.Forms.Label lbl_DescriptionFrom;
        private System.Windows.Forms.Label lbl_DescriptionTo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_Pipette;
        private System.Windows.Forms.Panel pan_Pippete;
        private System.Windows.Forms.Label lbl_DescriptionPipette;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

