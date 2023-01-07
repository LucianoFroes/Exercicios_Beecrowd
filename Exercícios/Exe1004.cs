using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
    internal class Exe1004 {
        public static void Executar() {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int produto = a * b;

            Console.WriteLine($"PROD = {produto}");
        }
    }
}
