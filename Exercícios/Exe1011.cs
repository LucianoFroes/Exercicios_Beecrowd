using System;


namespace Beecrowd.Exercícios {
     class Exe1011 {
        public static void Executar() {

            double raioEsfera = double.Parse(Console.ReadLine());
            double PI = 3.14159;

            double areaEsfera = (4 / 3.0) * PI * Math.Pow(raioEsfera, 3);

            Console.WriteLine($"VOLUME = {areaEsfera:F3}");

        }
    }
}
