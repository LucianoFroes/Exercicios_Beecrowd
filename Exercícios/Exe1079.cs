using System;


namespace Beecrowd.Exercícios {
     class Exe1079 {
        public static void Executar() {

            int numTestes = int.Parse(Console.ReadLine());

            double valor1 = 0;
            double valor2 = 0;
            double valor3 = 0;

            for (int i = 1; i <= numTestes; i++) {

                string[] valoresMedia = Console.ReadLine().Split();

                valor1 = double.Parse(valoresMedia[0]);
                valor2 = double.Parse(valoresMedia[1]);
                valor3 = double.Parse(valoresMedia[2]);

                double mediaPonderada = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;

                Console.WriteLine($"{mediaPonderada:F1}");

            }

        }
    }
}
