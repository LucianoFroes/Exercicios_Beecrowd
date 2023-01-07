using System;


namespace Beecrowd.Exercícios {
    class Exe1065 {
        public static void Executar() {

            double[] valoresArray = new double[6];
            int qntPares = 0;

            for (int i = 0; i <= 4; i++) {
                valoresArray[i] = double.Parse(Console.ReadLine());

                if (valoresArray[i] % 2 == 0) {
                    qntPares++;
                }
            }

            Console.WriteLine($"{qntPares} valores pares");
        }
    }
}
