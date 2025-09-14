namespace Gameshow_VuaTiengViet
{
    partial class FormDiem
    {
        private Label lblDiem;
        private Label lblTrangThai;
        private Button btnChoiLai, btnThoat;

        private void InitializeComponent()
        {
            lblDiem = new Label();
            lblTrangThai = new Label();
            btnChoiLai = new Button();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDiem
            // 
            lblDiem.BackColor = Color.FromArgb(255, 192, 255);
            lblDiem.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblDiem.Location = new Point(100, 60);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(1150, 60);
            lblDiem.TabIndex = 0;
            lblDiem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.BackColor = Color.Transparent;
            lblTrangThai.Font = new Font("Segoe UI", 20F, FontStyle.Italic);
            lblTrangThai.ForeColor = Color.DarkCyan;
            lblTrangThai.Location = new Point(100, 150);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(1150, 50);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChoiLai
            // 
            btnChoiLai.BackColor = Color.LightGreen;
            btnChoiLai.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnChoiLai.Location = new Point(400, 350);
            btnChoiLai.Name = "btnChoiLai";
            btnChoiLai.Size = new Size(250, 60);
            btnChoiLai.TabIndex = 1;
            btnChoiLai.Text = "Chơi lại";
            btnChoiLai.UseVisualStyleBackColor = false;
            btnChoiLai.Click += btnChoiLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightCoral;
            btnThoat.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnThoat.Location = new Point(700, 350);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(250, 60);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._267574_small;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1350, 701);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormDiem
            // 
            ClientSize = new Size(1350, 700);
            Controls.Add(lblDiem);
            Controls.Add(lblTrangThai);
            Controls.Add(btnChoiLai);
            Controls.Add(btnThoat);
            Controls.Add(pictureBox1);
            Name = "FormDiem";
            Text = "Điểm - Vua Tiếng Việt";
            Load += FormDiem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
    }
}