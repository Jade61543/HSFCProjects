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

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        Random myRand = new Random();

        private Image[] wheelImages = { Resources.AppleSymbol, Resources.BananaSymbol, Resources.BARSymbol,
            Resources.CherrySymbol, Resources.GoldenAppleSymbol, Resources.GrapesSymbol,
            Resources.LemonSymbol, Resources.MelonSymbol, Resources.OrangeSymbol };

        int box1Image = 0;
        int box2Image = 5;
        int box3Image = 7;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = wheelImages[box1Image];
            pictureBox2.Image = wheelImages[box2Image];
            pictureBox3.Image = wheelImages[box3Image];

        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            int box3SpinNum = myRand.Next(4, 15);
            int box2SpinNum = box3SpinNum - 1;
            int box1SpinNum = box2SpinNum - 1;

 
            for (int count = 0; count < box3SpinNum; count++)
            {
                if (count < box1SpinNum)
                {
                    pictureBox1.Image = wheelImages[box1Image++];
                    box1Image = (box1Image + 1) % 9;
                }

                if (count < box2SpinNum)
                {
                    pictureBox2.Image = wheelImages[box2Image++];
                    box2Image = (box2Image + 1) % 9;
                }

                pictureBox3.Image = wheelImages[box3Image++];
                box3Image = (box3Image + 1) % 9;

                System.Threading.Thread.Sleep(100);
            }

        }

    }
}

