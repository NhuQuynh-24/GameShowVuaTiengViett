namespace Gameshow_VuaTiengViet
{
    partial class FormCapDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Label lblChon;
        private Button btnDe, btnTrungBinh, btnKho;

        private void InitializeComponent()
        {
            lblChon = new Label();
            btnDe = new Button();
            btnTrungBinh = new Button();
            btnKho = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblChon
            // 
            lblChon.BackColor = Color.Transparent;
            lblChon.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChon.Location = new Point(189, 122);
            lblChon.Name = "lblChon";
            lblChon.Size = new Size(961, 60);
            lblChon.TabIndex = 0;
            lblChon.Text = "CHỌN CẤP ĐỘ CHƠI";
            lblChon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDe
            // 
            btnDe.BackColor = Color.LightGreen;
            btnDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnDe.Location = new Point(200, 250);
            btnDe.Name = "btnDe";
            btnDe.Size = new Size(300, 120);
            btnDe.TabIndex = 1;
            btnDe.Text = "Dễ";
            btnDe.UseVisualStyleBackColor = false;
            btnDe.Click += btnDe_Click;
            // 
            // btnTrungBinh
            // 
            btnTrungBinh.BackColor = Color.Khaki;
            btnTrungBinh.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnTrungBinh.Location = new Point(525, 250);
            btnTrungBinh.Name = "btnTrungBinh";
            btnTrungBinh.Size = new Size(300, 120);
            btnTrungBinh.TabIndex = 2;
            btnTrungBinh.Text = "Trung bình";
            btnTrungBinh.UseVisualStyleBackColor = false;
            btnTrungBinh.Click += btnTrungBinh_Click;
            // 
            // btnKho
            // 
            btnKho.BackColor = Color.LightCoral;
            btnKho.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnKho.Location = new Point(850, 250);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(300, 120);
            btnKho.TabIndex = 3;
            btnKho.Text = "Khó";
            btnKho.UseVisualStyleBackColor = false;
            btnKho.Click += btnKho_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.doremon_cuoi;
            pictureBox1.Location = new Point(77, 451);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormCapDo
            // 
            BackgroundImage = Properties.Resources.nen_choi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 700);
            Controls.Add(pictureBox1);
            Controls.Add(lblChon);
            Controls.Add(btnDe);
            Controls.Add(btnTrungBinh);
            Controls.Add(btnKho);
            DoubleBuffered = true;
            Name = "FormCapDo";
            Text = "Cấp độ - Vua Tiếng Việt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
    }
}