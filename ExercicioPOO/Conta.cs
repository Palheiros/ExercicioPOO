using System;

namespace ExercicioPOO
{
    public abstract class Conta //A classe abstrata não pode ser instanciada, somente serve de modelo para uma outra classe herdar
    {
        protected double saldo;

        public abstract void Creditar(double valor); //Como este método é abstrato deverá ser sobreescrito na classe filha

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}
