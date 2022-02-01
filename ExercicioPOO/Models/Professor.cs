using System;

namespace ExercicioPOO.Models
{
    public sealed class Professor : Pessoa //O sealed não permite que outras classes herdem a classe Professor. Pode ser usado em classes e métodos.
    {
        public double Salario { get; set; }

        public override void Apresentar() //O override foi usado para que a apresentação da classe Aluno sobrescreva a da herança da classe Pessoa
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um professor. Meu salário é de R${Salario}.");
        }
    }
}
