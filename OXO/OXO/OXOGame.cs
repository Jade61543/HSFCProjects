﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXO
{
    class OxoGame
    {
        // Piece defines possible pieces on board 
        // We use -1 as this makes win easier to calculate 
        public enum Piece {Nought = -1, Space, Cross};

        private Piece[,] theBoard = new Piece[3, 3];

        private string[] players = new String[2];

        private int currentPlayer = 0;
        private Piece currentPiece = Piece.Cross;


        // Constructor for game model
        public OxoGame(String player1, String player2)
        {
            players[0] = player1;
            players[1] = player2;
        }

        // nextPlayer moves the player to the next one, passing back the name 
        public string NextPlayer()
        {
            currentPlayer = (currentPlayer + 1) % 2;   
            return players[currentPlayer];
        }

        // nextPiece returns the piece that makes the next move 
        public Piece NextPiece()
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
        public int MakeMove(int x, int y, Piece move)
        {
            if ((x <= 3) & (y <= 3))
            {
                if (theBoard[x, y] == Piece.Space)
                {
                    theBoard[x, y] = move;
                    return 0;
                }

                return -2;
            }

            return -1;
        }

        public Piece GetPieceAtLocation(int x, int y)
        {
            if ((x <= 3) & (y <= 3))
            {
                return theBoard[x, y];
            }

            return Piece.Space; 
        }

        // detectWin detects whether a win has occurred 
        // returns 0 is Nought wins, 1 if Cross wins, 2 if draw, -1 if no win yet 

        public int DetectWin()
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