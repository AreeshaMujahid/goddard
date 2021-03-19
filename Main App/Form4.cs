using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Main_App
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }       

        private void button2_Click(object sender, EventArgs e)
        {

          



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {

           

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Label txt1 = new Label();

                txt1.Text = ofd.FileName;
                this.splitContainer3.Panel1.Controls.Add(txt1);
                txt1.Location = new Point(5, 100);
                txt1.Size = new System.Drawing.Size(200, 200);
                txt1.ForeColor = Color.DarkOrange;


                Label txt2 = new Label();
                txt2.Text = ofd.SafeFileName;
                this.splitContainer4.Panel2.Controls.Add(txt2);
                txt2.Location = new Point(20, 100);
                txt2.Size = new System.Drawing.Size(200, 200);
                txt2.ForeColor = Color.DarkOrange;
                Random _random = new Random();
                int numx = _random.Next(300);
                int numy = _random.Next(300);
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("../circle2.png");

                pb1.Location = new Point(numx, numy);


                //pb1.Location = new Point(100, 100);
                pb1.BringToFront();
                pb1.Size = new Size(60, 60);
                //this.Controls..Add(pb1);
                this.splitContainer4.Panel1.Controls.Add(pb1);
                pb1.Visible = true;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer4_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
