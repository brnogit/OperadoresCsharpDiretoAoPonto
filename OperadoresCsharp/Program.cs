using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Aritméticos
            // Unários ++, --, + e -
            
            //sufixo que vem depois
            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++);// 4
            Console.WriteLine(numeroOperador--);// 5
            // prefixo que vem antes
            Console.WriteLine(++numeroOperador); // 5
            Console.WriteLine(--numeroOperador);// 4

            Console.WriteLine(numeroOperador);
            Console.WriteLine(-numeroOperador);
            Console.WriteLine(-(-numeroOperador));

            // Binários * / + -

            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;

            var multiplos = (4 * 5) + 10;

            #endregion

            #region Operadores de Comparação > >= < <=

            Console.WriteLine(4 > 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(5 >= 5);

            Console.WriteLine(5 < 4);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 < 6);
            #endregion
            Console.Read();
        }
    }
}
