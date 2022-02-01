using System;


namespace ExercicioPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar() //O override foi usado para que a apresentação da classe Aluno sobrescreva a da herança da classe Pessoa
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}.");
        }
    }
}
