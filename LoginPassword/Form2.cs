using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassword
{
    public partial class Form2 : Form
    {

        int cnt = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //        button1.Enabled = true;
            pictureBox1.Left += 248;
            pictureBox112.Left += 247;
            if (pictureBox1.Left == 1004 || pictureBox1.Left == 1061)
            {
                //          button2.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button2.Enabled = true;
            pictureBox1.Left -= 248;
            pictureBox112.Left -= 248;
            if (pictureBox1.Left == 12 || pictureBox112.Left == 81)
            {
                //   button1.Enabled = false;
            }



        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                timer1.Enabled = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;

                if (pictureBox1.Left > 12)
                {
                    pictureBox1.Left -= 248;
                    pictureBox112.Left -= 248;
                }

            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                timer1.Enabled = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                if (pictureBox1.Left < 1004 || pictureBox112.Left < 1077)
                {
                    pictureBox1.Left += 248;
                    pictureBox112.Left += 248;
                }
            }
            if (e.KeyCode.Equals(Keys.Space))
            {
                if (pictureBox112.Left == 85)
                {
                    pictureBox7.Visible = true;
                    pictureBox2.Top = 3;
                }

                if (pictureBox112.Left == 333)
                {
                    pictureBox8.Visible = true;
                    pictureBox3.Top = 3;
                }
                if (pictureBox112.Left == 581)
                {
                    pictureBox9.Visible = true;
                    pictureBox4.Top = 3;
                }
                if (pictureBox112.Left == 829)
                {
                    pictureBox10.Visible = true;
                    pictureBox5.Top = 3;
                }
                if (pictureBox112.Left == 1077)
                {
                    pictureBox11.Visible = true;
                    pictureBox6.Top = 3;
                }
                cnt++;
                progressBar1.Value = cnt * 100 / 50;
                if (cnt == 50)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Победа");
                    Form2.ActiveForm.Close();
                }


            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs g)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top += 11;
            pictureBox3.Top += 11;
            pictureBox4.Top += 11;
            pictureBox5.Top += 11;
            pictureBox6.Top += 11;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}


