using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_App
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.Image = Image.FromFile("../try.png");
            pb1.Location = new Point(10, 10);
            //pb1.Location = new Point(100, 100);
            pb1.BringToFront();
            pb1.Size = new Size(100, 100);
            this.Controls.Add(pb1);
            pb1.Visible = true;
        }
    }
}
