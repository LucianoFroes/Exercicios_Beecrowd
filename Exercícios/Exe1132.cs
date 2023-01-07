using System;

namespace Beecrowd.Exercícios {
    class Exe1132 {

        public static void Executar() {

            int maiorValor = 0, menorValor = 0;

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (start > end) {
                maiorValor = start;
                menorValor = end;

            } else {
                maiorValor = end;
                menorValor = start;
            }

            int soma = 0;

            for (int i = menorValor; i <= maiorValor; i++) {

                if (i % 13 != 0) {
                    soma += i;
                } else {
                    continue;
                }

            }
            Console.WriteLine(soma);
        }
    }
}