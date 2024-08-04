using System;

namespace Flyweight_Pratico
{
    public class Soldado : IPersonagem
    {
        // estado extrínseco (não compartilhável)
        // muda para cada objeto
        public int Poder { get; set; }

        //estado intrínseco (cache - compartilhável)
        //é o mesmo para cada objeto
        public string Defesa = "Colete e Capacete";
        public string Atuacao = "Luta Corporal";
        public string Arma = "Fuzil e Pistola";

        public Soldado()
        { }

        public Soldado(int poder)
        {
            if (poder >= 10 && poder <= 50)
                Poder = poder;
            else
                throw new ArgumentException("Valor esta fora do poder de um soldado");
        }

        public void Render()
        {
            Console.WriteLine($"Soldado: {Poder} - Arma: {Arma} - Defesa: {Defesa} " +
             $"- Atuação: {Atuacao}");
        }
    }
}
