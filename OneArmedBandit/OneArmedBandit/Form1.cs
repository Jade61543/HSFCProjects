﻿using System;
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


        private Image[] arrayOfImages = {Resources.AppleSymbol, Resources.BananaSymbol, Resources.BARSymbol,
            Resources.CherrySymbol, Resources.GoldenAppleSymbol, Resources.GrapesSymbol,
            Resources.LemonSymbol, Resources.MelonSymbol, Resources.OrangeSymbol };

        private int[] wheelImages1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

        private int[] wheelImages2 = { 5, 3, 7, 2, 8, 6, 0, 1, 4 };

        private int[] wheelImages3 = { 2, 5, 3, 8, 6, 1, 7, 0, 4 };

        SoundPlayer spinSound = new SoundPlayer(Resources.OneSecondSilence);
        SoundPlayer winSound = new SoundPlayer(Resources.OneSecondSilence);

        int box1Image = 5;//5
        int box2Image = 3;//3
        int box3Image = 5;//5

        int nudgeLimit = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = arrayOfImages[wheelImages1[box1Image]];
            pictureBox2.Image = arrayOfImages[wheelImages2[box2Image]];
            pictureBox3.Image = arrayOfImages[wheelImages3[box3Image]];

            spinSound.Play();
            winSound.Play();
        }

        public void DetectWin()
        {
            if (wheelImages1[box1Image] == wheelImages2[box2Image] & wheelImages2[box2Image] == wheelImages3[box3Image])
            {

                winSound = new SoundPlayer(Resources.WinSound);
                winSound.Play();

                System.Threading.Thread.Sleep(170);

                for (int count = 0; count <= 4; count++)
                {
                    pictureBox1.Image = Resources.PoundWin;
                    pictureBox2.Image = Resources.PoundWin;
                    pictureBox3.Image = Resources.PoundWin;
                    pictureBox1.Update();
                    pictureBox2.Update();
                    pictureBox3.Update();

                    System.Threading.Thread.Sleep(170);

                    pictureBox1.Image = arrayOfImages[wheelImages1[box1Image]];
                    pictureBox2.Image = arrayOfImages[wheelImages2[box2Image]];
                    pictureBox3.Image = arrayOfImages[wheelImages3[box3Image]];
                    pictureBox1.Update();
                    pictureBox2.Update();
                    pictureBox3.Update();

                    System.Threading.Thread.Sleep(170);

                }

                winSound.Stop();
            }
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            int box3SpinNum = myRand.Next(7, 19);
            int box2SpinNum = box3SpinNum - 2;
            int box1SpinNum = box2SpinNum - 2;
            int longestSpinNum = box3SpinNum;
            int count;

            spinSound = new SoundPlayer(Resources.SpinSound);
            spinSound.Play();


            for (count = 0; count < box3SpinNum; count++)
            {
                if (count < box1SpinNum)
                {
                    box1Image = (box1Image + 1) % 8;
                    pictureBox1.Image = arrayOfImages[wheelImages1[box1Image]];
                    pictureBox1.Update();
                }

                if (count < box2SpinNum)
                {
                    box2Image = (box2Image + 1) % 8;
                    pictureBox2.Image = arrayOfImages[wheelImages2[box2Image]];
                    pictureBox2.Update();
                }

                box3Image = (box3Image + 1) % 8;
                pictureBox3.Image = arrayOfImages[wheelImages3[box3Image]];
                pictureBox3.Update();


                System.Threading.Thread.Sleep(250);
            }

            if (count >= longestSpinNum)
            {
                spinSound.Stop();
            }

            DetectWin();

            nudgeLimit = 0;
        }

        private void nudgeB1_Click(object sender, EventArgs e)
        {
            if (nudgeLimit == 0)
            {
                box1Image = (box1Image + 1) % 8;
                pictureBox1.Image = arrayOfImages[wheelImages1[box1Image]];
                pictureBox1.Update();

                nudgeLimit++;
                DetectWin();
            }
        }

        private void nudgeB2_Click(object sender, EventArgs e)
        {
            if (nudgeLimit == 0)
            {
                box2Image = (box2Image + 1) % 8;
                pictureBox2.Image = arrayOfImages[wheelImages2[box2Image]];
                pictureBox2.Update();

                nudgeLimit++;
                DetectWin();
            }
        }

        private void nudgeB3_Click(object sender, EventArgs e)
        {
            if (nudgeLimit == 0)
            {
                box3Image = (box3Image + 1) % 8;
                pictureBox3.Image = arrayOfImages[wheelImages3[box3Image]];
                pictureBox3.Update();

                nudgeLimit++;
                DetectWin();
            }

        }
    }
}

