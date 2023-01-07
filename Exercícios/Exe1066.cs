using System;


namespace Beecrowd.Exercícios {
    class Exe1066 {
        public static void Executar() {

            double[] valoresArray = new double[5];
            int qntPares = 0;
            int qntImpares = 0;
            int qntPositivos = 0;
            int qntNegativos = 0;

            for (int i = 0; i <= 4; i++) {
                valoresArray[i] = double.Parse(Console.ReadLine());

                if (valoresArray[i] % 2 == 0) {
                    qntPares++;
                }else if (valoresArray[i] % 2 != 0) {
                    qntImpares++;
                }

                if (valoresArray[i] > 0) {
                    qntPositivos++;
                }else if (valoresArray[i] < 0) {
                    qntNegativos++;
                }
            }
            Console.WriteLine($"{qntPares} valor(es) par(es)");
            Console.WriteLine($"{qntImpares} valor(es) impar(es)");
            Console.WriteLine($"{qntPositivos} valor(es) positivo(s)");
            Console.WriteLine($"{qntNegativos} valor(es) negativo(s)");
        }
    }
}
