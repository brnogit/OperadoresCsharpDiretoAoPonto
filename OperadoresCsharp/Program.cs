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
            #endregion

            Console.Read();
        }
    }
}
