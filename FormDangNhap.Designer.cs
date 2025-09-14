namespace Gameshow_VuaTiengViet
{
    partial class FormDangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNhapTen;
        private TextBox txtTenNguoiChoi;
        private Button btnDangNhap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNhapTen = new Label();
            txtTenNguoiChoi = new TextBox();
            btnDangNhap = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapTen.Location = new Point(286, 393);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(781, 53);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "NHẬP TÊN NGƯỜI CHƠI";
            lblNhapTen.TextAlign = ContentAlignment.MiddleCenter;
            lblNhapTen.Click += lblNhapTen_Click;
            // 
            // txtTenNguoiChoi
            // 
            txtTenNguoiChoi.Anchor = AnchorStyles.None;
            txtTenNguoiChoi.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNguoiChoi.Location = new Point(434, 478);
            txtTenNguoiChoi.Name = "txtTenNguoiChoi";
            txtTenNguoiChoi.Size = new Size(500, 50);
            txtTenNguoiChoi.TabIndex = 1;
            txtTenNguoiChoi.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.LightSkyBlue;
            btnDangNhap.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(546, 572);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(246, 66);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.vua_tieng_viet;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(231, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(851, 390);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            BackColor = Color.PaleTurquoise;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1350, 700);
            Controls.Add(lblNhapTen);
            Controls.Add(txtTenNguoiChoi);
            Controls.Add(btnDangNhap);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Vua Tiếng Việt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
