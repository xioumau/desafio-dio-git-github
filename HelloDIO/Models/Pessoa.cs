using System;

namespace HelloDIO.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"\nOlá meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}