using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Gameshow_VuaTiengViet
{
    partial class FormChoi
    {
        // QUAN TRỌNG: có container để Dispose()
        private IContainer components = null;

    private Label lblCauHoi, lblThoiGian, lblKetQua, lblSoCauDung;
    private Button btnA, btnB, btnC, btnD;
        // QUAN TRỌNG: dùng đúng Timer của WinForms
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            lblCauHoi = new Label();
            lblThoiGian = new Label();
            lblKetQua = new Label();
            lblSoCauDung = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCauHoi
            // 
            lblCauHoi.BackColor = Color.Transparent;
            lblCauHoi.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCauHoi.Location = new Point(327, 30);
            lblCauHoi.Name = "lblCauHoi";
            lblCauHoi.Size = new Size(696, 60);
            lblCauHoi.TabIndex = 0;
            lblCauHoi.Text = "Câu hỏi sẽ hiển thị ở đây";
            lblCauHoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThoiGian
            // 
            lblThoiGian.BackColor = Color.Transparent;
            lblThoiGian.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblThoiGian.Location = new Point(967, 122);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(200, 35);
            lblThoiGian.TabIndex = 1;
            lblThoiGian.Text = "Thời gian: 20s";
            lblThoiGian.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = Color.Transparent;
            lblKetQua.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKetQua.Location = new Point(419, 605);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(477, 40);
            lblKetQua.TabIndex = 7;
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoCauDung
            // 
            lblSoCauDung.BackColor = Color.Transparent;
            lblSoCauDung.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            lblSoCauDung.Location = new Point(50, 100);
            lblSoCauDung.Name = "lblSoCauDung";
            lblSoCauDung.Size = new Size(300, 35);
            lblSoCauDung.TabIndex = 6;
            lblSoCauDung.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnA
            // 
            btnA.BackColor = Color.LightYellow;
            btnA.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnA.Location = new Point(200, 200);
            btnA.Name = "btnA";
            btnA.Size = new Size(450, 80);
            btnA.TabIndex = 2;
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.LightYellow;
            btnB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnB.Location = new Point(700, 200);
            btnB.Name = "btnB";
            btnB.Size = new Size(450, 80);
            btnB.TabIndex = 3;
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.LightYellow;
            btnC.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnC.Location = new Point(200, 350);
            btnC.Name = "btnC";
            btnC.Size = new Size(450, 80);
            btnC.TabIndex = 4;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.LightYellow;
            btnD.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnD.Location = new Point(700, 350);
            btnD.Name = "btnD";
            btnD.Size = new Size(450, 80);
            btnD.TabIndex = 5;
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.meo_capo;
            pictureBox1.Location = new Point(50, 463);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormChoi
            // 
            BackgroundImage = Properties.Resources.nen_choi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 700);
            Controls.Add(lblCauHoi);
            Controls.Add(lblSoCauDung);
            Controls.Add(lblThoiGian);
            Controls.Add(btnA);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnD);
            Controls.Add(lblKetQua);
            Controls.Add(pictureBox1);
            Name = "FormChoi";
            Text = "Chơi - Vua Tiếng Việt";
            Load += FormChoi_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
    }
}