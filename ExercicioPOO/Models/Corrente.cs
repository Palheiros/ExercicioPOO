using System;

namespace ExercicioPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            saldo = valor;
        }
    }
}
