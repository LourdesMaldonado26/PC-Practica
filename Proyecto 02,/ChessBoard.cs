using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02__PC
{
      public class ChessBoard
    {
        private string[,] chessboard;
        public const int Dimension = 8;

        public Move Move;

        public ChessBoard()
        {
            Move = new Move();
            chessboard = new string[Dimension, Dimension];
            ChessBoardSignoHorizontal = "+---";
            ChessBoardSignoVertical = "| ";
        }

        public string ChessBoardSignoHorizontal { get; set; }
        public string ChessBoardSignoVertical { get; set; }
        public void Estructura()
        {
           while (!Move.Exit)
           {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6   7");

                for (int r = 0; r < Dimension; r++)
                {
                    Console.Write("  ");
                    for (int c = 0; c < Dimension; c++)
                    {
                        Console.Write(ChessBoardSignoHorizontal);
                    }
                    Console.Write("+\n");

                    for (int c = 0; c < Dimension; c++)
                    {
                        if (c == 0)
                        Console.Write(r + " ");
                        Console.Write(ChessBoardSignoVertical + Pawn.Comerpieza[r, c] + " ");
                    }

                    Console.Write("|\n");
                }
                Console.Write("  ");
                for (int c = 0; c < Dimension; c++)
                {
                    Console.Write(ChessBoardSignoHorizontal);
                }
                Console.Write("+\n\n");
                Move.MoverPiezas();
           }
        }
    }
}