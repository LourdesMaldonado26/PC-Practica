using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02__PC
{
    public class Move : Pawn
    {
        private int PiezaBlanca;
        private int PiezaNegra;
        private int MoverPiezaBlanca;
        private int MoverPiezaNegra;

        public Move()
        {
            PiezaBlanca = 0;
            PiezaNegra = 0;
            MoverPiezaBlanca = 0;
            MoverPiezaNegra = 0;
            Exit = false;
        }
        public bool Exit { get; set; }

        public void MoverPiezas()
        {
          getInput();
          if (!Exit)
        
            rearangePawns();
      
        }
        private void getInput()
        {
          Console.WriteLine("Ingresar pieza blanca");
          Exit = validarInput(int.TryParse(Console.ReadLine(), out PiezaBlanca));

          if (Exit)
          {
             Console.WriteLine("Ingresar pieza negra");
          Exit = validarInput(int.TryParse(Console.ReadLine(), out PiezaNegra));
          }

           if (Exit)
          {
             Console.WriteLine("Ingresar pieza blanca");
          Exit = validarInput(int.TryParse(Console.ReadLine(), out MoverPiezaBlanca));
          }

           {
             Console.WriteLine("Ingresar pieza negra");
          Exit = validarInput(int.TryParse(Console.ReadLine(), out MoverPiezaNegra));
          }
        }

        private bool validarInput(bool parsed)
        {
          bool error = false;

            if (!parsed)
            {
              error = true;
            }
            else if (PiezaBlanca < 0 || PiezaNegra < 0 || MoverPiezaBlanca < 0 || MoverPiezaNegra < 0)    
            {
              error = true;
            }
            else if (PiezaBlanca > ChessBoard.Dimension - 1 || PiezaNegra > ChessBoard.Dimension - 1 || MoverPiezaBlanca > ChessBoard.Dimension -1 || MoverPiezaNegra > ChessBoard.Dimension -1)
            {
              error = true;
            }

            if (error)
            {
              Console.WriteLine("Dato invalido");
            }

          return error;
        }
        private void rearangePawns()
        {
          Comerpieza[MoverPiezaBlanca,MoverPiezaNegra] = Comerpieza[PiezaBlanca,PiezaNegra];
          Comerpieza[PiezaBlanca, PiezaNegra] = espacio;
        }
    }
}