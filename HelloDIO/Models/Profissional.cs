using System;

namespace HelloDIO.Models
{
    public class Profissional : Pessoa
    {
        public string Stack { get; set; }
        public double AnosExperiencia { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"\nOlá, meu nome é {Nome}, trabalho com a stack {Stack} e tenho {AnosExperiencia} anos de experiência.");
        }

        public string Apresentar(double anos, string stack)
        {
            this.AnosExperiencia = anos;
            this.Stack = stack;
            return $"\nTrabalho há {AnosExperiencia} anos com {Stack}.";
        }

        public override void Estudar()
        {
            Console.WriteLine($"\nEstudar faz parte da minha profissão.");
        }
    }

}