using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Tabuleiro Tab { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QteMovi { get; protected set; }
  

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovi = 0;
        }
        public void IncrementarMovimentos()
        {
            QteMovi++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
