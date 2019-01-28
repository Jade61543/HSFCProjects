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
        private string player1, player2;
        private string currentPName;
        private OxoGame.Piece currentPiece;


        public GameUI(string p1Name, string p2Name)
        {
            player1 = p1Name;
            player2 = p2Name;

            InitializeComponent();
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            theGame = new OxoGame(player1, player2);
        }
    }
}
