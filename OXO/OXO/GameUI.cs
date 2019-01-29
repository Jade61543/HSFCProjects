using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OXO.Properties;

namespace OXO
{
    public partial class GameUI : Form
    {
        private string player1, player2;
        private string currentPName;
        private OxoGame.Piece currentPiece;        //Ask Mark
        OxoGame theGame;



        public GameUI(string p1Name, string p2Name)
        {
            player1 = p1Name;
            player2 = p2Name;

            InitializeComponent();
        }


        private void GameUI_Load(object sender, EventArgs e)
        {
            theGame = new OxoGame(player1, player2);
            currentPName = theGame.NextPlayer();
            currentPiece = theGame.NextPiece();

            currentPlayerName.Text = currentPName;
            currentPlayerSymbol.Text = Convert.ToString(currentPiece);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(0, 0) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button1.Image = Resources.Donut2;
                }
                else
                {
                    button1.Image = Resources.XBun2;
                }


                theGame.MakeMove(0, 0, currentPiece);
                int outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    // create button on design and have text print saying cross win. Include sound effect.

                }

                if (outCome == 0) //nought win
                {

                }

                if (outCome == -1) //no win
                {
                    currentPName = theGame.NextPlayer();
                    currentPlayerName.Text = currentPName;
                    currentPiece = theGame.NextPiece();
                    currentPlayerSymbol.Text = Convert.ToString(currentPiece);
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {

        }



        private void button7_Click(object sender, EventArgs e)
        {

        }



        private void button8_Click(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
