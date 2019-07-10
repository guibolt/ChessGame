using System;
using ChessGame.Chess;
using ChessGame.tabuleiro;
namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);


            tabuleiro.ColocarPeca(new Torre(tabuleiro,Cor.Preta), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));


            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(2, 4));






            Tela.ImprimtirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}
