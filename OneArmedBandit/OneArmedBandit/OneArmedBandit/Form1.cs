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
        private Image[] wheelImages = { Resources.AppleSymbol, Resources.BananaSymbol, Resources.BARSymbol,
            Resources.CherrySymbol, Resources.GoldenAppleSymbol, Resources.GrapesSymbol,
            Resources.LemonSymbol, Resources.MelonSymbol, Resources.OrangeSymbol };

        Random myRand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = wheelImages[1];
            pictureBox2.Image = wheelImages[5];
            pictureBox3.Image = wheelImages[8];
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
              
        }
    }
}
