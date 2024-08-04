using System;
using System.Collections.Generic;

namespace Flyweight_Pratico
{
    public class PersonagemFactory
    {
        private static Dictionary<string, IPersonagem> personagemMap =
            new Dictionary<string, IPersonagem>();

        public static IPersonagem GetPersonagem(string tipo)
        {
            IPersonagem personagem;

            if (personagemMap.ContainsKey(tipo))
            {
                Console.WriteLine($">>> Retornando personagem do cache : {tipo} >>>");
                return personagemMap[tipo];
            }
            else
            {
                Console.WriteLine($"### Instanciando um novo personagem : {tipo} ###");
                if (tipo == "soldado")
                {
                    personagem = new Soldado();
                    personagemMap.Add("soldado", personagem);
                }
                else if (tipo == "piloto")
                {
                    personagem = new Piloto();
                    personagemMap.Add("piloto", personagem);
                }
                else
                {
                    throw new Exception("Este tipo de personagem não pode ser criado");
                }
            }
            return personagem;
        }
    }
}
