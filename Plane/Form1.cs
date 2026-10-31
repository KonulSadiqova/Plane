using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Plane
{
    public partial class Form1 : Form
    {
        bool isOnState = true;

        public Form1()
        {
            InitializeComponent();
            pictureBoxLight.Visible = false;
            onOffButton.Text = "ON";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnEnisHazirligi_Click(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.inis);
            snd.Play();
        }

        private void btnTurbulans_Click(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.turubulans);
            snd.Play();
        }

        private void btnKemarlar_Click(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.kemer);
            snd.Play();
        }

        private void btnTesekkurler_Click(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.tesekkur);
            snd.Play();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.beep);
            snd.Play();
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxPlane.Top > -pictureBoxPlane.Height)
            {
                pictureBoxPlane.Top -= 5;
                pictureBoxLight.Top = pictureBoxPlane.Top - pictureBoxLight.Height;
            }
            else
            {
                pictureBoxPlane.Top = this.ClientSize.Height;
            }
        }

        private void onOffButton_Click(object sender, EventArgs e)
        {
            if (isOnState)
            {
                isOnState = false;
                onOffButton.Text = "OFF";
                pictureBoxLight.Visible = true;
            }
            else
            {
                isOnState = true;
                onOffButton.Text = "ON";
                pictureBoxLight.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}