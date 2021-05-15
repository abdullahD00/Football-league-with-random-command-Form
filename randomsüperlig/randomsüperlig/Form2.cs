using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomsüperlig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int fbpuan = 0;
        int gspuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label2.Text = a.ToString();
            label5.Text = b.ToString();
            label7.Text = c.ToString();
            label9.Text = d.ToString();

            if (Convert.ToInt32(label2.Text) > Convert.ToInt32(label5.Text))
                {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();

            }
            if(Convert.ToInt32(label5.Text)>Convert.ToInt32(label2.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label2.Text) == Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelgspuan.Text = gspuan.ToString();

            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label9.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if(Convert.ToInt32(label9.Text )==Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label19.Text = a.ToString();
            label16.Text = b.ToString();
            label14.Text = c.ToString();
            label12.Text = d.ToString();

            if (Convert.ToInt32(label19.Text) > Convert.ToInt32(label16.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if(Convert.ToInt32(label16.Text)>Convert.ToInt32(label19.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label19.Text) == Convert.ToInt32(label16.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label12.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if(Convert.ToInt32(label12.Text )>Convert.ToInt32(label14.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32(label12.Text )==Convert.ToInt32(label14.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label25.Text = a.ToString();
            label30.Text = b.ToString();
            label26.Text = c.ToString();
            label23.Text = d.ToString();

            if(Convert.ToInt32(label25.Text )>Convert.ToInt32(label30.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();

            }
            if(Convert.ToInt32(label30.Text )>Convert.ToInt32(label25.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32(label25.Text )==Convert.ToInt32(label30.Text))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32(label26.Text )>Convert.ToInt32(label23.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();

            }
            if(Convert.ToInt32(label23.Text )>Convert.ToInt32(label26.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();

            }
            if(Convert.ToInt32(label26.Text )==Convert.ToInt32(label23.Text))
            {
                gspuan = gspuan + 1;
                tspuan = tspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            if(Convert.ToInt32(labelfbpuan.Text)>Convert.ToInt32(labelgspuan.Text)&& Convert.ToInt32(labelfbpuan.Text) >Convert.ToInt32(labeltspuan.Text)&& Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\fb.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\fb.jpg";

            }
            if(Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                axWindowsMediaPlayer1.URL= "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\gs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\gs.jpg";

            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\bjk.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\bjk.jpg";

            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\ts.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\randomsüperlig\\ses ve fotolar\\ts.jpg";
            }


        }
    }
}
