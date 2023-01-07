using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
    internal class Exe1005 {
        public static void Executar() { 
           

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double media = ((a * 3.5) + (b * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {media:F5}");
            
        }
    }
}
