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

            #region Operadores de Igualdade ==, !=

            Console.WriteLine(5 == 5);
            Console.WriteLine(5 == 4); // é igual

            Console.WriteLine(5 != 5); //diferente
            Console.WriteLine(4 != 5);

            #endregion

            #region Operadores Lógicos AND && e OR ||

            var minhaNota = 7;
            var ultimoAno = true;

            if (minhaNota >= 7 && ultimoAno)
            {
                Console.WriteLine("Aprovado");
            } 
            
            if (minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado!");
            }

            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            #endregion
            Console.Read();
        }
    }
}
