
namespace prj_2210900097
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMDanhMuc,
            this.TSMBangLuong,
            this.TSMThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TSMDanhMuc
            // 
            this.TSMDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngBanCtrlPToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.TSMDanhMuc.Name = "TSMDanhMuc";
            this.TSMDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.TSMDanhMuc.Text = "Danh Mục";
            // 
            // phòngBanCtrlPToolStripMenuItem
            // 
            this.phòngBanCtrlPToolStripMenuItem.Name = "phòngBanCtrlPToolStripMenuItem";
            this.phòngBanCtrlPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phòngBanCtrlPToolStripMenuItem.Text = "Phòng Ban Ctrl +P";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên Ctrl+N";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // TSMBangLuong
            // 
            this.TSMBangLuong.Name = "TSMBangLuong";
            this.TSMBangLuong.Size = new System.Drawing.Size(103, 24);
            this.TSMBangLuong.Text = "Bảng Lương";
            // 
            // TSMThoat
            // 
            this.TSMThoat.Name = "TSMThoat";
            this.TSMThoat.Size = new System.Drawing.Size(61, 24);
            this.TSMThoat.Text = "Thoát";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem phòngBanCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMBangLuong;
        private System.Windows.Forms.ToolStripMenuItem TSMThoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

