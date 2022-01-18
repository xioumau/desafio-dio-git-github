using System;

namespace HelloDIO.Models
{
    public class Cozinheiro : Profissional
    {
        public string Especialidade { get; set; }

        public string Apresentar(string especialidade)
        {
            this.Especialidade = especialidade;

            return $"\nOlá, me chamo {Nome} e minha especialidade é {Especialidade}";
        }
    }
}