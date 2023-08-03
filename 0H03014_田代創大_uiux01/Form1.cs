using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _0H03014_田代創大_uiux01
{
   
    public partial class Form1 : Form
    {
       
        public static Form formview;
        public static Form1 form1;
        public void reset()
        {
            label14.Location = new Point(86, 90);
            label14.Text = "季\r\n節\r\nが\r\n表\r\n示\r\nさ\r\nれ\r\nる\r\nよ";
            label15.Text = "選\r\n択\r\nし\r\nた\r\n月\r\nの";
        }
        public Form1()
        {
            
            form1 = this;
            InitializeComponent();
         
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "３\n月\nの\n季\n節\nは\n春\n";
            label15.Text = "３\n月\nを\n選\n択\n中";
            formview = new Form2();        //春
            formview.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "４\n月\nの\n季\n節\nは\n春\n";
            label15.Text = "４\n月\nを\n選\n択\n中";
            formview = new Form2();        //春
            formview.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "５\n月\nの\n季\n節\nは\n春\n";
            label15.Text = "５\n月\nを\n選\n択\n中";
            formview = new Form2();        //春
            formview.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "６\n月\nの\n季\n節\nは\n夏\n";
            label15.Text = "６\n月\nを\n選\n択\n中";
            formview = new Form3();        //夏
            formview.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "７\n月\nの\n季\n節\nは\n夏\n";
            label15.Text = "７\n月\nを\n選\n択\n中";
            formview = new Form3();        //夏
            formview.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "８\n月\nの\n季\n節\nは\n夏\n";
            label15.Text = "８\n月\nを\n選\n択\n中";
            formview = new Form3();        //夏
            formview.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "９\n月\nの\n季\n節\nは\n秋\n";
            label15.Text = "９\n月\nを\n選\n択\n中";
            formview = new Form4();        //秋
            formview.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "10\n月\nの\n季\n節\nは\n秋\n";
            label15.Text = "10\n月\nを\n選\n択\n中";
            formview = new Form4();        //秋
            formview.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "11\n月\nの\n季\n節\nは\n秋\n";
            label15.Text = "11\n月\nを\n選\n択\n中";
            formview = new Form4();        //秋
            formview.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "12\n月\nの\n季\n節\nは\n冬\n";
            label15.Text = "12\n月\nを\n選\n択\n中";
            formview = new Form5();        //冬
            formview.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "１\n月\nの\n季\n節\nは\n冬\n";
            label15.Text = "１\n月\nを\n選\n択\n中";
            formview = new Form5();        //冬
            formview.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label14.Location = new Point(86, 150);
            label14.Text = "２\n月\nの\n季\n節\nは\n冬\n";
            label15.Text = "２\n月\nを\n選\n択\n中";
            formview = new Form5();        //冬
            formview.Show();
        } 
       
    


    }
}
