using System;
using ChessGame.Chess;
using ChessGame.tabuleiro;
namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimtirTabuleiro(partida.tabuleiro);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicao().ToPosicao();

                    bool[,] PosicoesPossiveis = partida.tabuleiro.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.ImprimtirTabuleiro(partida.tabuleiro);


                    
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicao().ToPosicao();

                    partida.ExecutarMovimentos(origem, destino);
                }
        


                Tela.ImprimtirTabuleiro(partida.tabuleiro);
            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
