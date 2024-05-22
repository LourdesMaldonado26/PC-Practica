using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02__PC
{
    public class Pawn
    {
        public const char comerpieza = 'X';
        public const char espacio = ' ';
        public static char[,] Comerpieza;

        public Pawn()
        {
            Comerpieza = new char[ChessBoard.Dimension, ChessBoard.Dimension];
            initPawn();
        }

        private void initPawn()
        {
          for (int r = 0; r < ChessBoard.Dimension; r++)
          {
            for (int c = 0; c < ChessBoard.Dimension; c++)
            {
              if (r == 0 || r == 1 || r == ChessBoard.Dimension - 2 || r == ChessBoard.Dimension - 1)
              {
                Comerpieza[r, c] = comerpieza;
              }
              else
              {
                Comerpieza[r, c] = espacio; 
              }
            }
          }
        }
    }
}
