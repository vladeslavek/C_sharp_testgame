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
    public partial class Form1 : Form
    {
        public String LOGIN;
        public String PASSWORD;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form2 game = new Form2();
                game.ShowDialog();
            }else{
                label1.Visible = true;

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
