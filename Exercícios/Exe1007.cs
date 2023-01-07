using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
    internal class Exe1007 {
        public static void Executar() {


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = ((a * b) - (c * d));

            Console.WriteLine($"DIFERENCA = {diferenca}");

        }
    }
}
