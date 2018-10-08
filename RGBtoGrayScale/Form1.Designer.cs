namespace RGBtoGrayScale
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkgetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridönüşümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalsıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem1,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem1
            // 
            this.dosyaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem1.Name = "dosyaToolStripMenuItem1";
            this.dosyaToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.dosyaToolStripMenuItem1.Text = "dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "kapat";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkgetirToolStripMenuItem,
            this.gridönüşümToolStripMenuItem,
            this.kanalsıralaToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "işlemler";
            // 
            // renkgetirToolStripMenuItem
            // 
            this.renkgetirToolStripMenuItem.Name = "renkgetirToolStripMenuItem";
            this.renkgetirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renkgetirToolStripMenuItem.Text = "renkgetir";
            this.renkgetirToolStripMenuItem.Click += new System.EventHandler(this.renkgetirToolStripMenuItem_Click);
            // 
            // gridönüşümToolStripMenuItem
            // 
            this.gridönüşümToolStripMenuItem.Name = "gridönüşümToolStripMenuItem";
            this.gridönüşümToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gridönüşümToolStripMenuItem.Text = "gridönüşüm";
            this.gridönüşümToolStripMenuItem.Click += new System.EventHandler(this.gridönüşümToolStripMenuItem_Click);
            // 
            // kanalsıralaToolStripMenuItem
            // 
            this.kanalsıralaToolStripMenuItem.Name = "kanalsıralaToolStripMenuItem";
            this.kanalsıralaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kanalsıralaToolStripMenuItem.Text = "kanalsırala";
            this.kanalsıralaToolStripMenuItem.Click += new System.EventHandler(this.kanalsıralaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkgetirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridönüşümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalsıralaToolStripMenuItem;
    }
}

