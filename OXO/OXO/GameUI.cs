using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OXO
{
    public partial class GameUI : Form
    {
        string player1;
        string player2;


        public GameUI(string p1Name, string p2Name)
        {
            InitializeComponent();

            player1 = p1Name;
            player2 = p2Name;
        }
    }
}
