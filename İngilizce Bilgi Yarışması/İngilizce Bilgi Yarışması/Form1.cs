using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İngilizce_Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int soru = 0, doğru = 0, yanlış = 0;

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            button5.Enabled = true;
            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                doğru = doğru + 1;
                lbldoğru.Text = doğru.ToString();
                picturebox1.Visible = true;

            }
            else
            {
                yanlış = yanlış + 1;
                lblyanlış.Text = yanlış.ToString();
                picturebox2.Visible = true;

            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            button5.Enabled = true;
            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                doğru = doğru + 1;
                lbldoğru.Text = doğru.ToString();
                picturebox1.Visible = true;

            }
            else
            {
                yanlış = yanlış + 1;
                lblyanlış.Text = yanlış.ToString();
                picturebox2.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            button5.Enabled = true;
            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                doğru = doğru + 1;
                lbldoğru.Text = doğru.ToString();
                picturebox1.Visible = true;

            }
            else
            {
                yanlış = yanlış + 1;
                lblyanlış.Text = yanlış.ToString();
                picturebox2.Visible = true;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            button5.Enabled = true;
            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                doğru = doğru + 1;
                lbldoğru.Text = doğru.ToString();
                picturebox1.Visible = true;


            }
            else
            {
                yanlış = yanlış + 1;
                lblyanlış.Text = yanlış.ToString();
                picturebox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            soru = soru + 1;
            lblsoru.Text=soru.ToString();
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            button5.Enabled = false;
            picturebox1.Visible = false;
            picturebox2.Visible = false;






            if (soru== 1)
            {
                richTextBox1.Text = "We are studing hard ...... pass the exam.";
                buttonA.Text = "For";
                buttonB.Text = "About";
                buttonC.Text = "To";
                buttonD.Text = "By";
                label4.Text = "To";



            }
            if (soru == 2)
            {
                richTextBox1.Text = "We can host ...... 50 people.";
                buttonA.Text = "To";
                buttonB.Text = "Around";
                buttonC.Text = "Be";
                buttonD.Text = "About";
                label4.Text = "About";



            }
            if (soru == 3)
            {
                richTextBox1.Text = "I am flying to Istanbul ...... 7 o'clock ...... Tuesday. ";
                buttonA.Text = "At/In";
                buttonB.Text = "At/On";
                buttonC.Text = "In/In";
                buttonD.Text = "In/On";
                label4.Text = "At/On";

            }
            if (soru == 4)
            {
                richTextBox1.Text = "Take your coat ...... you!";
                buttonA.Text = "By";
                buttonB.Text = "To";
                buttonC.Text = "With";
                buttonD.Text = "And";
                label4.Text = "With";



            }
            if (soru == 5)
            {
                richTextBox1.Text = "Can i have a packet ...... chocolate?";
                buttonA.Text = "Of";
                buttonB.Text = "To";
                buttonC.Text = "And";
                buttonD.Text = "With";
                label4.Text = "Of";

            }
            if (soru == 6)
            {
                richTextBox1.Text = "What ...... you eat 1 hour ago?";
                buttonA.Text = "Are";
                buttonB.Text = "Do";
                buttonC.Text = "Did";
                buttonD.Text = "Are gonna";
                label4.Text = "Did";

            }
            if (soru == 7)
            {
                richTextBox1.Text = "My holiday is ...... August this year.";
                buttonA.Text = "In";
                buttonB.Text = "On";
                buttonC.Text = "At";
                buttonD.Text = "To";
                label4.Text = "In";

            }
            if (soru == 8)
            {
                richTextBox1.Text = "Don't call me ...... noon!";
                buttonA.Text = "On";
                buttonB.Text = "In";
                buttonC.Text = "At";
                buttonD.Text = "To";
                label4.Text = "At";
            }
            if (soru == 9)
            {
                richTextBox1.Text = "The pie ...... nice.";
                buttonA.Text = "Smelling";
                buttonB.Text = "Smelled";
                buttonC.Text = "Smells";
                buttonD.Text = "Smell";
                label4.Text = "Smells";

            }
            if (soru == 10)
            {
                richTextBox1.Text = "We usually ...... football.";
                buttonA.Text = "Play";
                buttonB.Text = "Plays";
                buttonC.Text = "Playing";
                buttonD.Text = "Played";
                label4.Text = "Play";

            }
            if (soru == 11)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                

                button5.Text = "Sonuçlar";
                MessageBox.Show("Doğru:" + " " + doğru + "\n" + "Yanlış:" + " " + yanlış);

            }
            
            
        }
    }
}
