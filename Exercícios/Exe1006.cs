using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
    internal class Exe1006 {
        public static void Executar() {


            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double media = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine($"MEDIA = {media:F1}");

        }
    }
}
