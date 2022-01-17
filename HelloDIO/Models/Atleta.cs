using System;

namespace HelloDIO.Models
{
    public class Atleta : Pessoa
    {
        public string Esporte { get; set; }
        public double Recorde { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome}, pratico {Esporte} e meu recorde é {Recorde} km.");
        }

        public override void Estudar()
        {
            Console.WriteLine($"\nEu estudo para ser um atleta melhor.");
        }
    }
}