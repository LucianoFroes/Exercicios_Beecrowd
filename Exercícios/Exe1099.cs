using System;

namespace Beecrowd.Exercícios {
    class Exe1099 {
        public static void Executar() {

            int somaImpares = 0;

            int qntRepeticoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qntRepeticoes; i++) {

                string[] testesImpares = Console.ReadLine().Split();

                int valorInicial = int.Parse(testesImpares[0]);
                int valorFinal = int.Parse(testesImpares[1]);

                if(valorInicial > valorFinal) {
                    int aux;
                    aux = valorFinal;
                    valorFinal = valorInicial;
                    valorInicial = aux;
                }

                for(int j = valorInicial + 1; j < valorFinal; j++) {
                    if(j % 2 != 0) {
                        somaImpares += j;
                    }
                }

                Console.WriteLine(somaImpares);
                somaImpares = 0;

            }
        }
    }
}
