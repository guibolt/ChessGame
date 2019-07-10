using ChessGame.tabuleiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
   public class Tela
    {
        public static void ImprimtirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)  {

                for (int j = 0; j < tab.Linhas; j++) {

                    if (tab.Peca(i,j)==null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }

                }

                Console.WriteLine();

            }
        }
    }
}
