namespace QuanLyKTX
{
    partial class frmQuanLyPhong
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDoiTrangThai = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flpPhong
            // 
            this.flpPhong.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpPhong.Location = new System.Drawing.Point(52, 12);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(1024, 647);
            this.flpPhong.TabIndex = 0;
            // 
            // btnDoiTrangThai
            // 
            this.btnDoiTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnDoiTrangThai.FlatAppearance.BorderSize = 0;
            this.btnDoiTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoiTrangThai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDoiTrangThai.Location = new System.Drawing.Point(1135, 519);
            this.btnDoiTrangThai.Margin = new System.Windows.Forms.Padding(0);
            this.btnDoiTrangThai.Name = "btnDoiTrangThai";
            this.btnDoiTrangThai.Size = new System.Drawing.Size(168, 76);
            this.btnDoiTrangThai.TabIndex = 0;
            this.btnDoiTrangThai.Text = "Đổi Trạng \r\nThái Phòng";
            this.btnDoiTrangThai.UseVisualStyleBackColor = false;
            this.btnDoiTrangThai.Click += new System.EventHandler(this.btnDoiTrangThai_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(1135, 609);
            this.textBox1.Name = "textBox1";
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new System.Drawing.Size(60, 50);
            this.textBox1.TabIndex = 1;
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1334, 800);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDoiTrangThai);
            this.Controls.Add(this.flpPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyPhong";
            this.Text = "frmQuanLyHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.Button btnDoiTrangThai;
        private System.Windows.Forms.TextBox textBox1;
    }
}