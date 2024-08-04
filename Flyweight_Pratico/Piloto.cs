using System;

namespace Flyweight_Pratico
{
    public class Piloto : IPersonagem
    {
        // estado extrínseco (não compartilhável)
        // muda para cada objeto
        public int Poder { get; set; }

        //estado intrínseco (cache - compartilhável)
        //é o mesmo para cada objeto
        public string Arma = "AMX A1 : Bombas/Metralhadora";
        public string Defesa = "Velocidade e Altitude";
        public string Atuacao = "Combate Aéreo";

        public Piloto() { }
        public Piloto(int poder)
        {
            if (poder >= 20 && poder <= 100)
                Poder = poder;
            else
                throw new ArgumentException("Valor esta fora do poder de um piloto");
        }

        public void Render()
        {
            Console.WriteLine($"Piloto: {Poder} - Arma: {Arma} - Defesa : {Defesa} " +
               $"- Atuação: {Atuacao}");
        }
    }
}
