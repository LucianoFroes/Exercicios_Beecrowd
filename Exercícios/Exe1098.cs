using System;


namespace Beecrowd.Exercícios {
    class Exe1098 {
        public static void Executar() {

            int contadorI = 0;
            int contadorJ = 0;

            double valor = 0;
            double i, j;

            for (i = 0, j = 1; i < 2; j++) {
                if (contadorI == 0) {
                    Console.WriteLine($"I={i:F0} J={j:F0}");
                } else {
                    Console.WriteLine($"I={i:F1} J={j:F1}");
                }

                contadorJ++;

                if (contadorJ == 3) {
                    i += 0.2;
                    valor += 0.2;
                    j = valor;
                    contadorJ = 0;
                    contadorI++;
                }

                if (contadorI == 5) {
                    contadorI = 0;
                }
            }

        }
    }
}
