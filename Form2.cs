using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpRandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0,5);
            int b = rastgele.Next(0,5);
            int c = rastgele.Next(0,5);
            int d = rastgele.Next(0,5);

            
            label4.Text = a.ToString();
            label5.Text= b.ToString();
            label6.Text= c.ToString();
            label7.Text= d.ToString();

            if (Convert.ToInt32 (label4.Text)> Convert.ToInt32 (label5.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if(Convert.ToInt32 (label5.Text)> Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32 (label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan= gspuan + 1;
                fbpuan= fbpuan + 1;
                labelgspuan.Text= gspuan.ToString();
                labelfbpuan.Text=fbpuan.ToString();
            }


            if(Convert.ToInt32 (label7.Text)> Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text= bjkpuan.ToString();
            }
            if(Convert.ToInt32 (label6.Text)> Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text= tspuan.ToString();
            }
            if(Convert.ToInt32(label7.Text)== Convert.ToInt32(label6.Text))
            {
                bjkpuan= bjkpuan + 1;
                tspuan= tspuan + 1;
                labelbjkpuan.Text=bjkpuan.ToString();
                labeltspuan.Text=tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);


            label11.Text = a.ToString();
            label12.Text = b.ToString();
            label13.Text = c.ToString();
            label14.Text = d.ToString();
            
            if (Convert.ToInt32(label11.Text)> Convert.ToInt32(label12.Text))
            {
                gspuan= gspuan + 3;
                labelgspuan.Text= gspuan.ToString();
            }
            if(Convert.ToInt32(label12.Text)> Convert.ToInt32(label13.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if(Convert.ToInt32(label11.Text)== Convert.ToInt32(label12.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan= bjkpuan + 1;
                labelgspuan.Text= gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label14.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text=fbpuan.ToString();
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label13.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text= tspuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label14.Text))
            {
                fbpuan = fbpuan + 1; 
                tspuan = tspuan + 1;
                labelfbpuan.Text=fbpuan.ToString();
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
            label26.Text = b.ToString();
            label27.Text = c.ToString();
            label28.Text = d.ToString();

            if(Convert.ToInt32(label25.Text) > Convert.ToInt32(label26.Text))
            {
                fbpuan=fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label25.Text))
            {
                bjkpuan=bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label26.Text))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelfbpuan.Text= fbpuan.ToString();
                labelbjkpuan.Text= bjkpuan.ToString();
            }

            if (Convert.ToInt32(label27.Text) > Convert.ToInt32(label28.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label27.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label27.Text) == Convert.ToInt32(label28.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text));
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\DELL\\Desktop\\gs.mp3";
                label35.Text = "Şampiyon Galatasaray!!!";
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\gs.jpg";
            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text));
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\DELL\\Desktop\\fb.mp3";
                label35.Text = "Şampiyon Fenerbahçe!!!";
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\fb.jpg";

            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text));
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\DELL\\Desktop\\bjk.mp3";
                label35.Text = "Şampiyon Beşiktaş!!!";
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\bjk.jpeg";

            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text));
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\DELL\\Desktop\\ts.mp3";
                label35.Text = "Şampiyon Trabzonspor!!!";
                pictureBox1.ImageLocation = "C:\\Users\\DELL\\Desktop\\ts.jpg";


            }


        }
    }
}
