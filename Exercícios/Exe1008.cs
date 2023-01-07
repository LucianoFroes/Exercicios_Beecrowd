using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
     class Exe1008 {
         public static void Executar() {

            int numfunc = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());

            double salario = horas * valor;

            Console.WriteLine($"NUMBER = {numfunc}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}
