using QuanLyKTX.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class frmQuanLyPhong : Form
    {
        public frmQuanLyPhong()
        {
            InitializeComponent();
            btnDoiTrangThai.Enabled = false;
            loadPhong();
        }
        void loadPhong()
        {
            List<Phong> phongs = PhongDAO.Instance.loadListPhong();
            foreach(Phong item in phongs)
            {
                Button btn = new Button() {Width = PhongDAO.phongWidth, Height = PhongDAO.phongHeight };
                btn.Text = item.soPhong+ Environment.NewLine + Environment.NewLine  + item.tinhTrang;
                btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
                btn.ForeColor = Color.FromArgb(200, 200, 200);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                btn.Click += new System.EventHandler(this.btn_Click);
                btn.Tag = item;
                switch (item.tinhTrang)
                {
                    case "Tốt":
                        btn.BackColor = Color.FromArgb(4, 30, 54);
                        btn.Image = global::QuanLyKTX.Properties.Resources.apartment;
                        break;
                    default:
                        btn.BackColor = Color.IndianRed;
                        btn.Image = global::QuanLyKTX.Properties.Resources.repair;
                        break;
                }

                flpPhong.Controls.Add(btn);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            btnDoiTrangThai.Enabled = true;
            textBox1.Text = " "+ (sender as Button).Text;
        }
        private void btnDoiTrangThai_Click(object sender, EventArgs e)
        {
            string soPhong = textBox1.Text.Remove(4).Trim();
            string query = "USP_CHANGEROOMSTATUS @soPhong";
            int i = dataProvider.Instance.ExecuteNonQuery(query, new object[] {soPhong});
            if (i == 1)
            {
                MessageBox.Show("Đổi Thành Công");
                flpPhong.Controls.Clear();
                loadPhong();
                return;
            }
            else
            {
                MessageBox.Show("Nhấn OK để thoát", "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
    }
}
