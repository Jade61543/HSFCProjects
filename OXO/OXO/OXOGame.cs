using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    class OxoGame
    {
        // Piece define possible pieces on board 
        // We use -1 as this makes win easier to calculate 
        public enum Piece { Nought = -1, Space, Cross };

        private Piece[,] theBoard = new Piece[3, 3];

        private String[] players = new String[2];

        private int currentPlayer = 0;
        private Piece currentPiece = Piece.Cross;

        // Constructor that starts game 
        public OxoGame(String player1, String player2)
        {
            players[0] = player1;
            players[1] = player2;
        }

        // nextPlayer moves the player to the next one, passing back the name 
        public String nextPlayer()
        {
            currentPlayer = (currentPlayer + 1) % 2;    // get this? 
            return players[currentPlayer];
        }

        // nextPiece returns the piece that makes the next move 
        public Piece nextPiece()
        {
            if (currentPiece == Piece.Cross)
                currentPiece = Piece.Nought;
            else
                currentPiece = Piece.Cross;
            return currentPiece;
        }

        // makeMove checks that x, y are valid, then if move is valid, makes move 
        // 0 returned if all OK 
        // -1 if x and y are invalid 
        // -2 if move cannot be made 
        public int makeMove(int x, int y, Piece move)
        {
            // -THIS NEEDS IMPLEMENTING                ************* 

            // check x and y are in range 

            // now record the move in theBoard 
            return 999; // place holder so it compiles 
        }

        //  
        public Piece getPieceAtLocation(int x, int y)
        {
            // - THIS NEEDS IMPLEMENTING    ************** 

            // check x and y are in range 

            // passes back the piece at required location 
            return Piece.Nought;   // place holder so it compiles 
        }

        // detectWin detects whether a win has occurred 
        // returns 0 is Nought wins, 1 if Cross wins, 2 if draw, -1 if no win yet 

        public int detectWin()
        {
            int rowScore, columnScore, diag1Score, diag2Score;
            int NoughtWins = 3 * (int)Piece.Nought;   // NOUGHT 
            int CrossWins = 3 * (int)Piece.Cross;     //CROSS 

            for (int i = 0; i < 3; i++)
            {
                rowScore = 0;
                columnScore = 0;
                diag1Score = 0;
                diag2Score = 0;

                for (int j = 0; j < 3; j++)
                {
                    rowScore = rowScore + (int)theBoard[i, j];
                    columnScore = columnScore + (int)theBoard[j, i];
                    diag1Score = diag1Score + (int)theBoard[j, j];
                    diag2Score = diag2Score + (int)theBoard[j, 2 - j];
                }
                if ((rowScore == NoughtWins) | (columnScore == NoughtWins) |
                   (diag1Score == NoughtWins) | (diag2Score == NoughtWins))
                {
                    // Nought has won 
                    return 0;
                }
                else if ((rowScore == CrossWins) | (columnScore == CrossWins) |
                       (diag1Score == CrossWins) | (diag2Score == CrossWins))
                {
                    // Cross has won 
                    return 1;
                }
            }
            //no winners 
            return -1;
        }
    }
}