namespace EasyTrade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Search = new System.Windows.Forms.PictureBox();
            this.pic_Portfolio = new System.Windows.Forms.PictureBox();
            this.pic_Orders = new System.Windows.Forms.PictureBox();
            this.pic_Transactions = new System.Windows.Forms.PictureBox();
            this.pic_Settings = new System.Windows.Forms.PictureBox();
            this.pic_WatchList = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Portfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WatchList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pic_WatchList);
            this.panel1.Controls.Add(this.pic_Settings);
            this.panel1.Controls.Add(this.pic_Transactions);
            this.panel1.Controls.Add(this.pic_Orders);
            this.panel1.Controls.Add(this.pic_Portfolio);
            this.panel1.Controls.Add(this.pic_Search);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 1098);
            this.panel1.TabIndex = 0;
            // 
            // pic_Search
            // 
            this.pic_Search.BackColor = System.Drawing.Color.White;
            this.pic_Search.Location = new System.Drawing.Point(3, 0);
            this.pic_Search.Name = "pic_Search";
            this.pic_Search.Size = new System.Drawing.Size(276, 186);
            this.pic_Search.TabIndex = 0;
            this.pic_Search.TabStop = false;
            // 
            // pic_Portfolio
            // 
            this.pic_Portfolio.BackColor = System.Drawing.Color.DimGray;
            this.pic_Portfolio.Location = new System.Drawing.Point(3, 178);
            this.pic_Portfolio.Name = "pic_Portfolio";
            this.pic_Portfolio.Size = new System.Drawing.Size(276, 186);
            this.pic_Portfolio.TabIndex = 1;
            this.pic_Portfolio.TabStop = false;
            // 
            // pic_Orders
            // 
            this.pic_Orders.BackColor = System.Drawing.Color.DarkGray;
            this.pic_Orders.Location = new System.Drawing.Point(3, 359);
            this.pic_Orders.Name = "pic_Orders";
            this.pic_Orders.Size = new System.Drawing.Size(276, 186);
            this.pic_Orders.TabIndex = 2;
            this.pic_Orders.TabStop = false;
            // 
            // pic_Transactions
            // 
            this.pic_Transactions.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_Transactions.Location = new System.Drawing.Point(3, 541);
            this.pic_Transactions.Name = "pic_Transactions";
            this.pic_Transactions.Size = new System.Drawing.Size(276, 186);
            this.pic_Transactions.TabIndex = 3;
            this.pic_Transactions.TabStop = false;
            // 
            // pic_Settings
            // 
            this.pic_Settings.BackColor = System.Drawing.Color.Maroon;
            this.pic_Settings.Location = new System.Drawing.Point(3, 724);
            this.pic_Settings.Name = "pic_Settings";
            this.pic_Settings.Size = new System.Drawing.Size(276, 186);
            this.pic_Settings.TabIndex = 4;
            this.pic_Settings.TabStop = false;
            // 
            // pic_WatchList
            // 
            this.pic_WatchList.BackColor = System.Drawing.Color.Red;
            this.pic_WatchList.Location = new System.Drawing.Point(3, 905);
            this.pic_WatchList.Name = "pic_WatchList";
            this.pic_WatchList.Size = new System.Drawing.Size(276, 186);
            this.pic_WatchList.TabIndex = 5;
            this.pic_WatchList.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1468, 1090);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Portfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WatchList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_WatchList;
        private System.Windows.Forms.PictureBox pic_Settings;
        private System.Windows.Forms.PictureBox pic_Transactions;
        private System.Windows.Forms.PictureBox pic_Orders;
        private System.Windows.Forms.PictureBox pic_Portfolio;
        private System.Windows.Forms.PictureBox pic_Search;
    }
}

