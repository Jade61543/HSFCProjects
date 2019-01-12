using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneArmedBandit.Properties;
using System.Media;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        Random myRand = new Random();

        private Image[] wheelImages1 = { Resources.AppleSymbol, Resources.BananaSymbol, Resources.BARSymbol,
            Resources.CherrySymbol, Resources.GoldenAppleSymbol, Resources.GrapesSymbol,
            Resources.LemonSymbol, Resources.MelonSymbol, Resources.OrangeSymbol };

        private Image[] wheelImages2 = {Resources.GrapesSymbol, Resources.LemonSymbol, Resources.OrangeSymbol,
            Resources.MelonSymbol, Resources.BARSymbol, Resources.GoldenAppleSymbol,
            Resources.CherrySymbol, Resources.BananaSymbol, Resources.AppleSymbol};

        private Image[] wheelImages3 = {Resources.MelonSymbol, Resources.BananaSymbol, Resources.AppleSymbol,
            Resources.BARSymbol, Resources.GrapesSymbol, Resources.OrangeSymbol,
            Resources.LemonSymbol, Resources.CherrySymbol, Resources.GoldenAppleSymbol};

        SoundPlayer audio = new SoundPlayer(Resources.OneSecondSilence);

        int box1Image = 5;
        int box2Image = 3;
        int box3Image = 5;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = wheelImages1[box1Image];
            pictureBox2.Image = wheelImages2[box2Image];
            pictureBox3.Image = wheelImages3[box3Image];

            audio.Play();

        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            int box3SpinNum = myRand.Next(7, 19);
            int box2SpinNum = box3SpinNum - 2;
            int box1SpinNum = box2SpinNum - 2;
            int longestSpinNum = box3SpinNum;
            int count;

            audio =  new SoundPlayer(Resources.SpinSound);
            audio.Play();


            for (count = 0; count < box3SpinNum; count++)
            {
                if (count < box1SpinNum)
                {
                    pictureBox1.Image = wheelImages1[box1Image++];
                    pictureBox1.Update();
                    box1Image = (box1Image + 1) % 9;
                }

                if (count < box2SpinNum)
                {
                    pictureBox2.Image = wheelImages2[box2Image++];
                    pictureBox2.Update();
                    box2Image = (box2Image + 1) % 9;
                }

                pictureBox3.Image = wheelImages3[box3Image++];
                pictureBox3.Update();
                box3Image = (box3Image + 1) % 9;



                System.Threading.Thread.Sleep(250);
            }

            if (count >= longestSpinNum)
            {
                audio.Stop();
            }

            if (pictureBox1.Image == pictureBox2.Image & pictureBox2.Image == pictureBox3.Image)
            {

            }
        }
    }
}

