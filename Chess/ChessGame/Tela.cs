using ChessGame.Chess;
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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Linhas; j++)
                {
                    ImprimirPeca(tab.Peca(i, j));
                }
                Console.WriteLine();

            }
            Console.WriteLine("  A B C D E F G H");
        }

         public static PosicaoXadrez LerPosicao()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }



        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }

           
        }
    }
}
