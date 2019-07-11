using ChessGame.tabuleiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Chess
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
        public bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {

            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);
            //acima
            pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // nordeste
            pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // direta
            pos.DefinirValores(Posicao.Linhas, Posicao.Colunas + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }

            // sudeste
            pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }

            // abaixo
            pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }

            //sudoeste 

            pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }

            //esquerda 
            pos.DefinirValores(Posicao.Linhas, Posicao.Colunas - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }

            // noroeste
            pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            return mat;

        }

    }
}
