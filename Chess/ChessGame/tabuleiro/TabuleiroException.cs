using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string mensagem) : base(mensagem)
        {

        }
    }
}
