using System;
using tabuleiro;
using xadres;

namespace projeto_xadres
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosicao());
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
