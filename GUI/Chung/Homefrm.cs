using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Try
{
    public partial class Homefrm : Form
    {
        private Timer timer;
        private string[] imageFiles;
        private int currentIndex = 0;
        public Homefrm()
        {
            InitializeComponent();
            string imageFolder = @"C:\Users\pc\OneDrive\Hình ảnh\Ảnh giới thiệu";

            if (Directory.Exists(imageFolder))
            {
                imageFiles = Directory.GetFiles(imageFolder, "*.jpg"); // Lọc file ảnh .jpg
            }
            else
            {
                MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (imageFiles.Length > 0)
            {
                pictureBox1.ImageLocation = imageFiles[currentIndex]; // Hiển thị ảnh đầu tiên
            }

            // Khởi tạo Timer
            timer = new Timer();
            timer.Interval = 5000; // 10 giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        
        private void Homefrm_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Homefrm_Load(object sender, EventArgs e)
        {

        }
        //Tạo hàm đếm thời gian mỗi 10 giây 
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (imageFiles.Length == 0) return;

            // Chuyển sang ảnh tiếp theo
            currentIndex = (currentIndex + 1) % imageFiles.Length;
            pictureBox1.ImageLocation = imageFiles[currentIndex];
        }

 

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            if (imageFiles.Length == 0) return;

            // Chuyển sang ảnh trước đó
            currentIndex = (currentIndex - 1 + imageFiles.Length) % imageFiles.Length;
            pictureBox1.ImageLocation = imageFiles[currentIndex];
        }

        private void siticoneCircleButton2_Click_1(object sender, EventArgs e)
        {
            if (imageFiles.Length == 0) return;

            // Chuyển sang ảnh tiếp theo
            currentIndex = (currentIndex + 1) % imageFiles.Length;
            pictureBox1.ImageLocation = imageFiles[currentIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            if(panel1.Width > 1452)
            {
                picBacsy1.Size = new Size(500, 428);
                picBacsy2.Size = new Size(500, 428);
                picBacsy3.Size = new Size(500, 428);
                picBacsy4.Size = new Size(500, 428);
            }
            else
            {
                picBacsy1.Size = new Size(400, 360);
                picBacsy2.Size = new Size(400, 360);
                picBacsy3.Size = new Size(400, 360);
                picBacsy4.Size = new Size(400, 360);
            }
        }
    }
}
