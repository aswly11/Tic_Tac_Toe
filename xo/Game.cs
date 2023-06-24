using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xo
{
    public partial class Game : Form
    {
        int counter = 1;
    
        public Game()
        {
            InitializeComponent();
            
            //mouseenter
            r1.MouseEnter += (sender, e) => hoverall(sender, e, r1);
            r2.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r2);
            r3.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r3);
            r4.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r4);
            r5.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r5);
            r6.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r6);
            r7.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r7);
            r8.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r8);
            r9.MouseEnter += (sender2, e2) => hoverall(sender2, e2, r9);
            //////mouseleave
            r1.MouseLeave += (sender, e) => leaveall(sender, e, r1);
            r2.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r2);
            r3.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r3);
            r4.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r4);
            r5.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r5);
            r6.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r6);
            r7.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r7);
            r8.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r8);
            r9.MouseLeave += (sender2, e2) => leaveall(sender2, e2, r9);
            ///mouseclick
            r1.MouseClick += (sender, e) => clickall(sender, e, r1);
            r2.MouseClick += (sender2, e2) => clickall(sender2, e2, r2);
            r3.MouseClick += (sender2, e2) => clickall(sender2, e2, r3);
            r4.MouseClick += (sender2, e2) => clickall(sender2, e2, r4);
            r5.MouseClick += (sender2, e2) => clickall(sender2, e2, r5);
            r6.MouseClick += (sender2, e2) => clickall(sender2, e2, r6);
            r7.MouseClick += (sender2, e2) => clickall(sender2, e2, r7);
            r8.MouseClick += (sender2, e2) => clickall(sender2, e2, r8);
            r9.MouseClick += (sender2, e2) => clickall(sender2, e2, r9);

            
            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
            foreach (PictureBox i in arr)
            {

                i.Tag = "";

            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
           
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void leaveall(object sender, EventArgs e, PictureBox p)
        {
            if (p.Enabled) { p.Image = null; }

        }
        private bool checkifwinner()
        {

            if ((r1.Tag.ToString() == "O" && r2.Tag.ToString() == "O" && r3.Tag.ToString() == "O") ||
                (r4.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r6.Tag.ToString() == "O") ||
                 (r7.Tag.ToString() == "O" && r8.Tag.ToString() == "O" && r9.Tag.ToString() == "O") ||
                  (r1.Tag.ToString() == "O" && r4.Tag.ToString() == "O" && r7.Tag.ToString() == "O") ||
                   (r2.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r8.Tag.ToString() == "O") ||
                    (r3.Tag.ToString() == "O" && r6.Tag.ToString() == "O" && r9.Tag.ToString() == "O") ||
                (r3.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r7.Tag.ToString() == "O") ||
                (r1.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r9.Tag.ToString() == "O"))
            {
                return true;

            }
            else if ((r1.Tag.ToString() == "x" && r2.Tag.ToString() == "x" && r3.Tag.ToString() == "x") ||
                (r4.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r6.Tag.ToString() == "x") ||
                 (r7.Tag.ToString() == "x" && r8.Tag.ToString() == "x" && r9.Tag.ToString() == "x") ||
                  (r1.Tag.ToString() == "x" && r4.Tag.ToString() == "x" && r7.Tag.ToString() == "x") ||
                   (r2.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r8.Tag.ToString() == "x") ||
                    (r3.Tag.ToString() == "x" && r6.Tag.ToString() == "x" && r9.Tag.ToString() == "x") ||
                (r3.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r7.Tag.ToString() == "x") ||
                (r1.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r9.Tag.ToString() == "x"))
            {
                return true;

            }
            return false;
        }


        private void clickall(object sender, EventArgs e, PictureBox p)
        {

            if (p.Enabled)
            {
                if (counter % 2 == 0)
                {
                    Bitmap opimg = new Bitmap(xo.Properties.Resources._734552);
                    p.Image = opimg;
                    p.Tag = "O";

                }
                else
                {
                    Bitmap xopimg = new Bitmap(xo.Properties.Resources._361px_Redx2_svg);
                    p.Image = xopimg;
                    p.Tag = "x";
                }
            }
            p.Enabled = false;
            if(checkifwinner())
            {
                pictureBox3.Visible = true;
                button1.Visible = true;
            }
            if(drawcheak())
            {
                return;
            }

            counter++;

    }

        private void hoverall(object sender, EventArgs e,PictureBox p)
        {

            if (p.Enabled)
            {
                if (counter % 2 == 0)
                {
                    Bitmap opimg = new Bitmap(xo.Properties.Resources._734552_op);
                    p.Image = opimg;

                }
                else
                {
                    Bitmap xopimg = new Bitmap(xo.Properties.Resources.x_op);
                    p.Image = xopimg;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 1;


            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
            foreach (PictureBox i in arr)
            {

                i.Tag = "";
                i.Enabled = true;
                i.Image = null;
                pictureBox3.Visible = false;
                button1.Visible = false;

            }

        }
        private bool drawcheak()
        {
            List<PictureBox> enabledpics = new List<PictureBox>();
            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
            foreach (PictureBox i in arr)
            {

                if (i.Enabled)
                {
                    enabledpics.Add(i);
                }
            }
            if (enabledpics.Count == 0)
            {
                Bitmap drawimg = new Bitmap(xo.Properties.Resources.source);
                pictureBox3.Image = drawimg;
                pictureBox3.Visible = true;
                button1.Visible = true;
                return true;


            }
            return false;
        }

        private void r1_Click(object sender, EventArgs e)
        {

        }

        private void r2_Click(object sender, EventArgs e)
        {

        }

        private void r3_Click(object sender, EventArgs e)
        {

        }

        private void r4_Click(object sender, EventArgs e)
        {

        }

        private void r6_Click(object sender, EventArgs e)
        {

        }

        private void r7_Click(object sender, EventArgs e)
        {

        }

        private void r8_Click(object sender, EventArgs e)
        {

        }

        private void r9_Click(object sender, EventArgs e)
        {

        }

        private void r5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
