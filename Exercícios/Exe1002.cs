using System;


namespace Beecrowd.Exercícios {
     class Exe1002 {
        public static void Executar() {

            double r = double.Parse(Console.ReadLine());
            double raio = Math.Pow(r, 2);
            double PI = 3.14159;
            double area = PI * raio;

            Console.WriteLine($"A={area:F4}");
                
        }
    }
}
