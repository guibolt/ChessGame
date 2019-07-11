using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.tabuleiro
{
   public class Posicao
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

      

        public Posicao(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
        }
        public void DefinirValores(int linha, int coluna)
        {
            Linhas = linha;
            Colunas = coluna;
        }
        public override string ToString()
        {
            return Linhas
                + ","
                + Colunas;
        }
    }
}
