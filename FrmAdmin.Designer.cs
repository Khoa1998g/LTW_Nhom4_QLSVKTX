namespace QuanLyKTX
{
    partial class FrmAdmin
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
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNative = new System.Windows.Forms.Panel();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyHD = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLySV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picUserName = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTile = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSV
            // 
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(277, 106);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 82;
            this.dgvSV.RowTemplate.Height = 33;
            this.dgvSV.Size = new System.Drawing.Size(1324, 232);
            this.dgvSV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNative);
            this.panel1.Controls.Add(this.btnThongBao);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnQuanLyHD);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnQuanLySV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 918);
            this.panel1.TabIndex = 1;
            // 
            // pnlNative
            // 
            this.pnlNative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNative.Location = new System.Drawing.Point(266, 300);
            this.pnlNative.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNative.Name = "pnlNative";
            this.pnlNative.Size = new System.Drawing.Size(4, 200);
            this.pnlNative.TabIndex = 1;
            // 
            // btnThongBao
            // 
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongBao.FlatAppearance.BorderSize = 0;
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnThongBao.Image = global::QuanLyKTX.Properties.Resources.bell;
            this.btnThongBao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThongBao.Location = new System.Drawing.Point(0, 452);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(270, 84);
            this.btnThongBao.TabIndex = 1;
            this.btnThongBao.Text = "  Thông Báo";
            this.btnThongBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongBao.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDangXuat.Image = global::QuanLyKTX.Properties.Resources.exit;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(4, 830);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(270, 84);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "  Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanLyHD
            // 
            this.btnQuanLyHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyHD.FlatAppearance.BorderSize = 0;
            this.btnQuanLyHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHD.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuanLyHD.Image = global::QuanLyKTX.Properties.Resources.bill;
            this.btnQuanLyHD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuanLyHD.Location = new System.Drawing.Point(0, 368);
            this.btnQuanLyHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyHD.Name = "btnQuanLyHD";
            this.btnQuanLyHD.Size = new System.Drawing.Size(270, 84);
            this.btnQuanLyHD.TabIndex = 1;
            this.btnQuanLyHD.Text = "  Quản Lý Hoá Đơn";
            this.btnQuanLyHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyHD.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnThongKe.Image = global::QuanLyKTX.Properties.Resources.graph_50;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 284);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(270, 84);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "  Thống Kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnQuanLySV
            // 
            this.btnQuanLySV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuanLySV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLySV.FlatAppearance.BorderSize = 0;
            this.btnQuanLySV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySV.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLySV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuanLySV.Image = global::QuanLyKTX.Properties.Resources.card;
            this.btnQuanLySV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySV.Location = new System.Drawing.Point(0, 200);
            this.btnQuanLySV.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLySV.Name = "btnQuanLySV";
            this.btnQuanLySV.Size = new System.Drawing.Size(270, 84);
            this.btnQuanLySV.TabIndex = 1;
            this.btnQuanLySV.Text = "  Quản Lý Sinh Viên";
            this.btnQuanLySV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLySV.UseCompatibleTextRendering = true;
            this.btnQuanLySV.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbltxt);
            this.panel2.Controls.Add(this.lblAdmin);
            this.panel2.Controls.Add(this.picUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 200);
            this.panel2.TabIndex = 0;
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltxt.Location = new System.Drawing.Point(14, 149);
            this.lbltxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(125, 24);
            this.lbltxt.TabIndex = 3;
            this.lbltxt.Text = "Tui là admin";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAdmin.Location = new System.Drawing.Point(12, 106);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(95, 31);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            // 
            // picUserName
            // 
            this.picUserName.Image = global::QuanLyKTX.Properties.Resources.schoolboy_at_a_desk__v2;
            this.picUserName.Location = new System.Drawing.Point(18, 4);
            this.picUserName.Margin = new System.Windows.Forms.Padding(4);
            this.picUserName.Name = "picUserName";
            this.picUserName.Size = new System.Drawing.Size(100, 100);
            this.picUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserName.TabIndex = 0;
            this.picUserName.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(1022, 40);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(476, 36);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search something here...";
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTile.Location = new System.Drawing.Point(288, 14);
            this.lblTile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(309, 64);
            this.lblTile.TabIndex = 3;
            this.lblTile.Text = "Dashboard";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1560, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1604, 918);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdmin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNative;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLyHD;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuanLySV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox picUserName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Button btnClose;
    }
}