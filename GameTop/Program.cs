using System;
using GameTOP.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*INSTÂNCIAR*/
            var jogo = new JogoFODA(new Jogador1("Ronaldo"), new Jogador2());
            
            jogo.IniciarJogo();
        }
    }
}
