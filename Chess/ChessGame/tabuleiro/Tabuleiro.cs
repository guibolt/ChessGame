﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.tabuleiro
{
   public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas,Colunas];
        }

        public Peca Peca(int linha,int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.Linhas, pos.Colunas];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.Linhas, pos.Colunas] = p;
            p.Posicao = pos;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linhas<0 || pos.Linhas >=Linhas || pos.Colunas<0 || pos.Colunas>=Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }

    }
}