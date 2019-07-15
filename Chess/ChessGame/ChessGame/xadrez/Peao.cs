﻿using tabuleiro;

namespace xadrez {

    class Peao : Peca {

        private PartidaDeXadrez Partida;
        public Peao(Tabuleiro tab, Cor cor,PartidaDeXadrez partida) : base(tab, cor) {
            Partida = partida;
        }

        public override string ToString() {
            return "P";
        }

        private bool existeInimigo(Posicao pos) {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos) {
            return tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca) {
                pos.definirValores(posicao.linha - 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 2, posicao.coluna);
                Posicao p2 = new Posicao(posicao.linha - 1, posicao.coluna);
                if (tab.posicaoValida(p2) && livre(p2) && tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos)) {
                 mat[pos.linha, pos.coluna] = true;

                    if (posicao.linha ==3)
                    {
                        Posicao esqueda = new Posicao(posicao.linha, posicao.coluna - 1);
                        if (tab.posicaoValida(esqueda) && existeInimigo(esqueda) && tab.peca(esqueda) == Partida.vuneravelEnPassant)
                        {
                            mat[esqueda.linha -1, esqueda.coluna] = true;
                        }
                        Posicao direita= new Posicao(posicao.linha, posicao.coluna - 1);
                        if (tab.posicaoValida(direita) && existeInimigo(direita) && tab.peca(direita) == Partida.vuneravelEnPassant)
                        {
                            mat[direita.linha -1, direita.coluna] = true;
                        }
                    }


                }
            }
            else {
                pos.definirValores(posicao.linha + 1, posicao.coluna);
                if (tab.posicaoValida(pos) && livre(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 2, posicao.coluna);
                Posicao p2 = new Posicao(posicao.linha + 1, posicao.coluna);
                if (tab.posicaoValida(p2) && livre(p2) && tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.linha, pos.coluna] = true;
                }

                if (posicao.linha == 4)
                {
                    Posicao esqueda = new Posicao(posicao.linha, posicao.coluna - 1);
                    if (tab.posicaoValida(esqueda) && existeInimigo(esqueda) && tab.peca(esqueda) == Partida.vuneravelEnPassant)
                    {
                        mat[esqueda.linha +1, esqueda.coluna] = true;
                    }
                    Posicao direita = new Posicao(posicao.linha, posicao.coluna - 1);
                    if (tab.posicaoValida(direita) && existeInimigo(direita) && tab.peca(direita) == Partida.vuneravelEnPassant)
                    {
                        mat[direita.linha +1, direita.coluna] = true;
                    }
                }
            }
            return mat;
        }
    }
}
