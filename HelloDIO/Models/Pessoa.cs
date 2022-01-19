using System;
using HelloDIO.Interfaces;

namespace HelloDIO.Models
{
    public abstract class Pessoa : IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private string Email { get; set; }
        private string Telefone { get; set; }

        public virtual void Apresentar() // pode ser sobreescrito
        {
            Console.WriteLine($"\nOlá meu nome é {Nome} e tenho {Idade} anos");
        }

        public abstract void Estudar(); // deve ser sobreescrito

        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string ObterEmaileTelefone()
        {
            if(Email == "" || Telefone == "")
            {
                return "Faltando informações";
            }
            else
            {
                return $"O email é {Email} e o telefone é {Telefone}";
            }
        }
    }
}