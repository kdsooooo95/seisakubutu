using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _0H03014_田代創大_uiux01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void Form3_Load(object sender, EventArgs e)
        {

            pictureBox3.Size = new Size(840, 520);
            this.Location = new Point(213, 95);
            ResizeForm(842, 550);
            button1.Location = new Point(722, 455);


            // ループを開始
            for (int i = 0; i < 4; i++)
            {
                
                // 一時停止する1秒
                int delaySeconds = 1;

                pictureBox3.Image = Image.FromFile("海.png");

                await Task.Delay(delaySeconds * 1000);              // 指定した秒数待機

                pictureBox3.Image = Image.FromFile("海part2.png");
                await Task.Delay(delaySeconds * 1000);              // 指定した秒数待機

                pictureBox3.Image = Image.FromFile("海part3.png");
                await Task.Delay(delaySeconds * 1000);              // 指定した秒数待機

                pictureBox3.Image = Image.FromFile("海part4.png");
                await Task.Delay(delaySeconds * 2000);
            }

        }

    


     
        private void ResizeForm(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1.form1.reset();
            Form1.formview.Close();
        }
    }
}
