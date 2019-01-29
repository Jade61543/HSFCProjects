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
        private string player1;
        private string player2;
        private string currentPName;
        private OxoGame.Piece currentPiece;
        int outCome;
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
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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
            if (theGame.GetPieceAtLocation(1, 0) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button2.Image = Resources.Donut2;
                }
                else
                {
                    button2.Image = Resources.XBun2;
                }


                theGame.MakeMove(1, 0, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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


        private void button3_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(2, 0) == OxoGame.Piece.Space) 
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button3.Image = Resources.Donut2;
                }
                else
                {
                    button3.Image = Resources.XBun2;
                }


                theGame.MakeMove(2, 0, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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


        private void button4_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(0, 1) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button4.Image = Resources.Donut2;
                }
                else
                {
                    button4.Image = Resources.XBun2;
                }


                theGame.MakeMove(0, 1, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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



        private void button5_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(1, 1) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button5.Image = Resources.Donut2;
                }
                else
                {
                    button5.Image = Resources.XBun2;
                }


                theGame.MakeMove(1, 1, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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



        private void button6_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(2, 1) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button6.Image = Resources.Donut2;
                }
                else
                {
                    button6.Image = Resources.XBun2;
                }


                theGame.MakeMove(2, 1, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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



        private void button7_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(0, 2) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button7.Image = Resources.Donut2;
                }
                else
                {
                    button7.Image = Resources.XBun2;
                }


                theGame.MakeMove(0, 2, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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



        private void button8_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(1, 2) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button8.Image = Resources.Donut2;
                }
                else
                {
                    button8.Image = Resources.XBun2;
                }


                theGame.MakeMove(1, 2, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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


        private void button9_Click(object sender, EventArgs e)
        {
            if (theGame.GetPieceAtLocation(2, 2) == OxoGame.Piece.Space)
            {
                if (currentPiece == OxoGame.Piece.Nought)
                {
                    button9.Image = Resources.Donut2;
                }
                else
                {
                    button9.Image = Resources.XBun2;
                }


                theGame.MakeMove(2, 2, currentPiece);
                outCome = theGame.DetectWin();


                if (outCome == 1) //cross win
                {
                    winningP.Text = (currentPlayer + " Wins!");
                }

                if (outCome == 0) //nought win
                {
                    winningP.Text = (currentPlayer + " Wins!");
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
    }
}
