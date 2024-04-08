namespace PH53213_ASSIGNMENT_PRL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grb_thongtin = new GroupBox();
            btn_thoat = new Button();
            btn_dangnhap = new Button();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            grb_thongtin.SuspendLayout();
            SuspendLayout();
            // 
            // grb_thongtin
            // 
            grb_thongtin.Controls.Add(btn_thoat);
            grb_thongtin.Controls.Add(btn_dangnhap);
            grb_thongtin.Controls.Add(txt_matkhau);
            grb_thongtin.Controls.Add(txt_taikhoan);
            grb_thongtin.Controls.Add(label3);
            grb_thongtin.Controls.Add(label2);
            grb_thongtin.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grb_thongtin.Location = new Point(476, 149);
            grb_thongtin.Name = "grb_thongtin";
            grb_thongtin.Size = new Size(397, 272);
            grb_thongtin.TabIndex = 4;
            grb_thongtin.TabStop = false;
            grb_thongtin.Text = "Thông tin đăng nhập";
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(252, 206);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(112, 33);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(49, 206);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(113, 33);
            btn_dangnhap.TabIndex = 4;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(127, 116);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(205, 27);
            txt_matkhau.TabIndex = 3;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(127, 53);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(205, 27);
            txt_taikhoan.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 124);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 61);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(220, 42);
            label1.Name = "label1";
            label1.Size = new Size(489, 35);
            label1.TabIndex = 3;
            label1.Text = "Đăng nhập hệ thống Quản lý thư viên";
            // 
            // listView1
            // 
            listView1.Location = new Point(53, 202);
            listView1.Name = "listView1";
            listView1.Size = new Size(394, 160);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 491);
            Controls.Add(grb_thongtin);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            grb_thongtin.ResumeLayout(false);
            grb_thongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb_thongtin;
        private Button btn_thoat;
        private Button btn_dangnhap;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView1;
    }
}
