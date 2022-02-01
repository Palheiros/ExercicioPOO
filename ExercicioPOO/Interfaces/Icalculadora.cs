using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO.Interfaces
{
    public interface Icalculadora
    {
        public int Somar(int num1, int num2);
        public int Subtrair(int num1, int num2);
        public int Multiplicar(int num1, int num2);
        public int Dividir(int num1, int num2);

        public int Soma3(int num1, int num2, int num3) //Quando se implementa um método na Interface não é obrigatório implementar na classe que a herda
        {
            return num1 + num2 + num3;
        }
    }
}
