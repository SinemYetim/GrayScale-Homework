namespace RGBtoGrayScale
{
    partial class Form4
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalsıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rgbbrgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rgbgbrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kanalsıralaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.dosyaToolStripMenuItem.Text = "dosya ";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.açToolStripMenuItem.Text = "aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.kaydetToolStripMenuItem.Text = "kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.kapatToolStripMenuItem.Text = "kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // kanalsıralaToolStripMenuItem
            // 
            this.kanalsıralaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rgbbrgToolStripMenuItem,
            this.rgbgbrToolStripMenuItem});
            this.kanalsıralaToolStripMenuItem.Name = "kanalsıralaToolStripMenuItem";
            this.kanalsıralaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.kanalsıralaToolStripMenuItem.Text = "kanalsırala";
            // 
            // rgbbrgToolStripMenuItem
            // 
            this.rgbbrgToolStripMenuItem.Name = "rgbbrgToolStripMenuItem";
            this.rgbbrgToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.rgbbrgToolStripMenuItem.Text = "rgbbrg";
            this.rgbbrgToolStripMenuItem.Click += new System.EventHandler(this.rgbbrgToolStripMenuItem_Click);
            // 
            // rgbgbrToolStripMenuItem
            // 
            this.rgbgbrToolStripMenuItem.Name = "rgbgbrToolStripMenuItem";
            this.rgbgbrToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.rgbgbrToolStripMenuItem.Text = "rgbgbr";
            this.rgbgbrToolStripMenuItem.Click += new System.EventHandler(this.rgbgbrToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(12, 27);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(200, 200);
            this.kaynakBox.TabIndex = 3;
            this.kaynakBox.TabStop = false;
            this.kaynakBox.Click += new System.EventHandler(this.kaynakBox_Click);
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(286, 27);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(200, 200);
            this.islemBox.TabIndex = 4;
            this.islemBox.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 247);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalsıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rgbbrgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rgbgbrToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.PictureBox islemBox;
    }
}