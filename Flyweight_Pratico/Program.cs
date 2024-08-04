using System;

namespace Flyweight_Pratico
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i< 5;++i)
            {
                var personagem = (Soldado)PersonagemFactory.GetPersonagem("soldado");
                //prop extrinseca
                personagem.Poder = getRandomPoderSoldado();
                personagem.Render();
            }
            Console.WriteLine("\n-------------------------------------------");

            for (int i = 0; i < 5; ++i)
            {
                var personagem = (Piloto)PersonagemFactory.GetPersonagem("piloto");
                personagem.Poder = getRandomPoderPiloto();
                personagem.Render();
            }
            Console.ReadKey();
        }

        private static int getRandomPoderSoldado()
        {
            Random rnd = new Random();
            return rnd.Next(10, 50);
        }
        private static int getRandomPoderPiloto()
        {
            Random rnd = new();
            return rnd.Next(20, 100);
        }
    }
}
