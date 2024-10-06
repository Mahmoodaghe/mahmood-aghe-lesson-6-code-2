using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace محمود_اغا_lesson_6_code_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap imag= new Bitmap(textBox1.Text.Trim());
            pictureBox1.Image = imag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor= Color.Aqua;
            pictureBox1.Width = pictureBox1.Height = 200;
            pictureBox1.BackColor = Color.Beige;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
