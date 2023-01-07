using System;

namespace Beecrowd.Exercícios {
    class Exe1101 {
        public static void Executar() {

            int entradaM = 1, entradaN = 1, menorEntrada = 0;
            int maiorEntrada = 0, somaEntradas = 0;

            while (true) {

                string[] entradas1 = Console.ReadLine().Split();

                entradaM = int.Parse(entradas1[0]);
                entradaN = int.Parse(entradas1[1]);

                if (entradaM > entradaN) {
                    maiorEntrada = entradaM;
                    menorEntrada = entradaN;
                } else {
                    maiorEntrada = entradaN;
                    menorEntrada = entradaM;
                }

                if (maiorEntrada <= 0 || menorEntrada <= 0) {
                    break;

                } else {

                    for (int j = menorEntrada; j <= maiorEntrada; j++) {
                        Console.Write($"{j} ");

                        somaEntradas += j;

                        if (j == maiorEntrada) {
                            Console.WriteLine($"Sum={somaEntradas}");
                            somaEntradas = 0;
                        }
                    }
                }
            }
        }
    }
}
