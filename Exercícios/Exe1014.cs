using System;


namespace Beecrowd.Exercícios {
     class Exe1014 {
        public static void Executar() {

            double distPercorrida = double.Parse(Console.ReadLine());
            double combustivelGasto = double.Parse(Console.ReadLine());

            double consumoMedio = distPercorrida / combustivelGasto;

            Console.WriteLine($"{consumoMedio:F3} km/l");

        }
    }
}
