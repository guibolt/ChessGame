using ChessGame.tabuleiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Chess
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
