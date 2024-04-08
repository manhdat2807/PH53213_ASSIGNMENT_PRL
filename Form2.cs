using BUS_PH53213.Service;
using DAL_PH53213.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH53213_ASSIGNMENT_PRL
{
    public partial class Form2 : Form
    {
        SachService SaService;
        TaikoanService tkservice;
        Docgiaservice dgservice;
        Phieumuonservice pmservice;
        private string idwhenclick;
        public Form2()
        {
            InitializeComponent();
            SaService = new SachService();
            tkservice = new TaikoanService();
            dgservice = new Docgiaservice();
            pmservice= new Phieumuonservice();
            loadSA();
            loadTK();
            loadDG();
            loadPM();
        }
        // Quản lý sách 
        public void loadSA()
        {
            dgv_sach.ColumnCount = 6;
            dgv_sach.Columns[0].Name = "Mã sách";
            dgv_sach.Columns[1].Name = "Tên sách";
            dgv_sach.Columns[2].Name = "Tác giả";
            dgv_sach.Columns[3].Name = "Thể loại ";
            dgv_sach.Columns[4].Name = "Năm xuất bản";
            dgv_sach.Columns[5].Name = "NXB";
            dgv_sach.Rows.Clear();
            foreach (var sa in SaService.GetSaches())
            {
                dgv_sach.Rows.Add(sa.MaSach, sa.TenSach, sa.TacGia, sa.MaTheLoai, sa.NamXuatBan, sa.Nxb);
            }
        }

        private void dgv_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex < 0 || rowindex >= SaService.GetSaches().Count())
            {
                return;
            }
            idwhenclick = dgv_sach.Rows[rowindex].Cells[0].Value.ToString();
            Binddatesa();
        }
        public void Binddatesa()
        {
            var sa = SaService.GetSaches().First(x => x.MaSach == idwhenclick);
            txt_masach.Text = sa.MaSach;
            txt_tensach.Text = sa.TenSach;
            txt_tacgia.Text = sa.TacGia;
            txt_theloai.Text = sa.MaTheLoai;
            txt_nxb.Text = sa.Nxb;
        }

        private void btn_themsach_Click(object sender, EventArgs e)
        {
            Sach sa = new Sach();
            sa.MaSach = txt_masach.Text;
            sa.TenSach = txt_tensach.Text;
            sa.TacGia = txt_tacgia.Text;
            sa.MaTheLoai = txt_theloai.Text;
            sa.NamXuatBan = DateTime.Parse(txt_namxb.Text);
            sa.Nxb = txt_nxb.Text;
            MessageBox.Show(SaService.addbook(sa));
            loadSA();
        }

        private void btn_capnhapsach_Click(object sender, EventArgs e)
        {
            var colne = SaService.GetSaches().Find(x => x.MaSach == idwhenclick);
            colne.MaSach = txt_masach.Text;
            colne.TenSach = txt_tensach.Text;
            colne.TacGia = txt_tacgia.Text;
            colne.MaTheLoai = txt_theloai.Text;
            colne.NamXuatBan = DateTime.Parse(txt_namxb.Text);
            colne.Nxb = txt_nxb.Text;
            MessageBox.Show(SaService.updatesa(colne));
            loadSA();
        }

        private void btn_xoasach_Click(object sender, EventArgs e)
        {
            string ma = txt_masach.Text;
            MessageBox.Show(SaService.removebook(ma));

            loadSA();
        }

        private void btn_lammoisach_Click(object sender, EventArgs e)
        {
            txt_masach.Clear();
            txt_tensach.Clear();
            txt_tacgia.Clear();
            txt_namxb.Clear();
            txt_nxb.Clear();
            txt_theloai.Clear();
        }
        //Quản lý tài khoản
        public void loadTK()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Mã Nhân viên";
            dataGridView1.Columns[1].Name = "Họ tên ";
            dataGridView1.Columns[2].Name = "SĐT";
            dataGridView1.Columns[3].Name = "Tài khoản";
            dataGridView1.Columns[4].Name = "Vai trò";
            dataGridView1.Columns[5].Name = "Mật khẩu";
            dataGridView1.Rows.Clear();
            foreach (var tk in tkservice.GetTaikhoans())
            {
                dataGridView1.Rows.Add(tk.MaNv, tk.HoTen, tk.SoDienThoai, tk.TaiKhoan1, tk.VaiTro, tk.MatKhau);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex < 0 || rowindex >= tkservice.GetTaikhoans().Count())
            {
                return;
            }
            idwhenclick = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            Binddatetk();
        }
        public void Binddatetk()
        {
            var tk = tkservice.GetTaikhoans().First(x => x.MaNv == idwhenclick);
            txt_manv.Text = tk.MaNv;
            txt_hoten.Text = tk.HoTen;
            txt_taikhoan.Text = tk.TaiKhoan1;
            txt_matkhau.Text = tk.MatKhau;
            txt_vaitro.Text = tk.VaiTro;
            txt_sdt.Text = tk.SoDienThoai.ToString();
        }

        private void btn_themtaikhoan_Click(object sender, EventArgs e)
        {
            Taikhoan tk = new Taikhoan();
            tk.MaNv = txt_manv.Text;
            tk.HoTen = txt_hoten.Text;
            tk.TaiKhoan1 = txt_taikhoan.Text;
            tk.MatKhau = txt_matkhau.Text;
            tk.VaiTro = txt_vaitro.Text;
            if (int.TryParse(txt_sdt.Text, out int soDienThoai))
            {
                tk.SoDienThoai = soDienThoai;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                return;
            }
            MessageBox.Show(tkservice.addTk(tk));
            loadTK();
        }

        private void btn_capnhaptk_Click(object sender, EventArgs e)
        {
            var colne = tkservice.GetTaikhoans().Find(x => x.MaNv == idwhenclick);
            colne.MaNv = txt_manv.Text;
            colne.HoTen = txt_hoten.Text;
            colne.TaiKhoan1 = txt_taikhoan.Text;
            colne.MatKhau = txt_matkhau.Text;
            if (int.TryParse(txt_sdt.Text, out int soDienThoai))
            {
                colne.SoDienThoai = soDienThoai;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                return;
            }
            colne.VaiTro = txt_vaitro.Text;
            MessageBox.Show(tkservice.updateTk(colne));
            loadTK();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma = txt_manv.Text;
            MessageBox.Show(tkservice.removeTk(ma));
            loadTK();
        }

        private void btn_lammoitk_Click(object sender, EventArgs e)
        {
            txt_hoten.Clear();
            txt_manv.Clear();
            txt_taikhoan.Clear();
            txt_matkhau.Clear();
            txt_sdt.Clear();
            txt_vaitro.Clear();
        }
        //Quản lý độc giả
        public void loadDG()
        {
            dtg_dsdocgia.ColumnCount = 3;
            dtg_dsdocgia.Columns[0].Name = "Mã độc giả";
            dtg_dsdocgia.Columns[1].Name = "Tên độc gải";
            dtg_dsdocgia.Columns[2].Name = "Số điện thoại độc giả";
            dtg_dsdocgia.Rows.Clear();
            foreach (var dg in dgservice.GetDocGia())
            {
                dtg_dsdocgia.Rows.Add(dg.MaDocGia, dg.TenDocGia, dg.SoDienThoai);
            }
        }

        private void dtg_dsdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == 0 || rowindex >= dgservice.GetDocGia().Count())
            {
                return;
            }
            idwhenclick = dtg_dsdocgia.Rows[rowindex].Cells[0].Value.ToString();
            binddatedg();
        }
        public void binddatedg()
        {
            var dg = dgservice.GetDocGia().Find(x => x.MaDocGia == idwhenclick);
            txt_madg.Text = dg.MaDocGia;
            txt_tendg.Text = dg.TenDocGia;
            txt_sdtdg.Text = dg.SoDienThoai.ToString();

        }

        private void btn_themdg_Click(object sender, EventArgs e)
        {
            DocGium dg = new DocGium();
            dg.MaDocGia = txt_madg.Text;
            dg.TenDocGia = txt_tendg.Text;
            if (int.TryParse(txt_sdtdg.Text, out int soDienThoai))
            {
                dg.SoDienThoai = soDienThoai;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                return;
            }
            MessageBox.Show(dgservice.addDG(dg));
            loadDG();
        }

        private void btn_capnhapdg_Click(object sender, EventArgs e)
        {
            var colne = dgservice.GetDocGia().Find(x => x.MaDocGia == idwhenclick);
            colne.MaDocGia = txt_madg.Text;
            colne.TenDocGia = txt_tendg.Text;

            if (int.TryParse(txt_sdtdg.Text, out int soDienThoai))
            {
                colne.SoDienThoai = soDienThoai;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            MessageBox.Show(dgservice.updateDG(colne));
            loadDG();
        }

        private void btn_xoadg_Click(object sender, EventArgs e)
        {
            string ma = txt_madg.Text;
            MessageBox.Show(dgservice.removeDG(ma));
            loadDG();
        }

        private void btn_lammoidg_Click(object sender, EventArgs e)
        {
            txt_madg.Clear();
            txt_tendg.Clear() ;
            txt_sdtdg.Clear();
        }
        //Quản lý mượn trả
        public void loadPM()
        {
            dataGridView2.ColumnCount = 8;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Name";
            dataGridView2.Columns[2].Name = "Name";
            dataGridView2.Columns[3].Name = "Name";
            dataGridView2.Columns[4].Name = "Name";
            dataGridView2.Columns[5].Name = "Name";
            dataGridView2.Columns[6].Name = "Name";
            dataGridView2.Columns[7].Name = "Name";
        }
    }
}
