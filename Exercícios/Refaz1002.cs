using System;

namespace Beecrowd.Exercícios {

    public class Area {

        static double Raio;
        double PI = 3.14159;

        public double AreaCirculo(double raio) {
            Area.Raio = raio;
            return this.PI * (Math.Pow(raio, 2));
        }
    }
    class Refaz1002 {
        public static void Executar() {

            var area = new Area();
            double raio = double.Parse(Console.ReadLine());

            double equacaoCirculo = area.AreaCirculo(raio);

            Console.WriteLine($"A={equacaoCirculo:F4}");

        }
    }
}
