using System;
using HelloDIO.Models;

namespace HelloDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloDIO.Saudacoes saudacoes = new HelloDIO.Saudacoes();
            Console.WriteLine(saudacoes.Saudacao("Olá Digital Innovation One!"));

            Pessoa p1 = new();
            p1.Nome = "Mauricio";
            p1.Idade = 38;

            p1.SetEmail("mau@mail.com");
            p1.SetTelefone("99191-8899");

            p1.Apresentar();
            
            Console.WriteLine(p1.ObterEmaileTelefone());
        }
    }
}
