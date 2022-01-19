using System;
using System.Collections.Generic;
using System.IO;
using HelloDIO.Helper;
using HelloDIO.Models;

namespace HelloDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "/home/mauricio/Documents/Digital Innovation One/";
            var caminhoPathCombine = Path.Combine(caminho, "PastaTeste1");
            var caminhoArquivo  = Path.Combine(caminho, "arquivoTeste.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste2", "NovoArquivoTeste.txt");
            
            var listaString = new List<string> { "Linha1", "Linha2", "Linha3" }; 
            var listaStringNext = new List<string> { "Linha4", "Linha5", "Linha6" };

            FileHelper helper = new();
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarArquivoTexto(caminhoArquivo, "Teste de criação de arquivo em C#.");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringNext);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
            // helper.CopiarArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            helper.DeletarArquivo(novoCaminhoArquivo);

            // Profissional profissional  = new();
            // profissional.Nome = "Mauricio";
            // profissional.Idade = 38;
            // profissional.Stack = ".NET";
            // profissional.AnosExperiencia = 1.5;
            
            // profissional.SetEmail("prof@mail.com");
            // profissional.SetTelefone("99999-6655");

            // profissional.Apresentar();
            // profissional.Estudar();
            // Console.WriteLine(profissional.Apresentar(4, "C#"));
            // Console.WriteLine(profissional.ObterEmaileTelefone());

            // Atleta atleta = new();
            // atleta.Nome = "Bill";
            // atleta.Idade = 35;
            // atleta.Esporte = "Corrida";
            // atleta.Recorde = 7.65;

            // atleta.SetEmail("atleta@mail.com");
            // atleta.SetTelefone("99955-6565");

            // atleta.Apresentar();
            // atleta.Estudar();
            // Console.WriteLine(atleta.ObterEmaileTelefone());

            // Cozinheiro cozinheiro = new();
            // cozinheiro.Nome = "Jeff";
            // cozinheiro.Especialidade = "Cozinha Asiática";
            // Console.WriteLine(cozinheiro.Apresentar("Cozinha asiática"));

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
