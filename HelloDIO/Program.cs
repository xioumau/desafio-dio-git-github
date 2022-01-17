using System;
using HelloDIO.Models;

namespace HelloDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Profissional profissional  = new();
            profissional.Nome = "Mauricio";
            profissional.Idade = 38;
            profissional.Stack = ".NET";
            profissional.AnosExperiencia = 1.5;

            profissional.Apresentar();
            Console.WriteLine(profissional.Apresentar(4, "C#"));

            Atleta atleta = new();
            atleta.Nome = "Bill";
            atleta.Idade = 35;
            atleta.Esporte = "Corrida";
            atleta.Recorde = 7.65;

            atleta.Apresentar();

            // HelloDIO.Saudacoes saudacoes = new HelloDIO.Saudacoes();
            // Console.WriteLine(saudacoes.Saudacao("Olá Digital Innovation One!"));

            // Pessoa p1 = new();
            // p1.Nome = "Mauricio";
            // p1.Idade = 38;

            // p1.SetEmail("mau@mail.com");
            // p1.SetTelefone("99191-8899");

            // p1.Apresentar();
            
            // Console.WriteLine(p1.ObterEmaileTelefone());
        }
    }
}
