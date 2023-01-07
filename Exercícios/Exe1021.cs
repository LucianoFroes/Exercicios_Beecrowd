using System;

namespace Beecrowd.Exercícios {
    class Exe1021 {
        public static void Executar() {

            double dinheiro = double.Parse(Console.ReadLine());

            int[] notasVetor = new int[6];
            int[] moedasVetor = new int[6];

            while (dinheiro >= 100) {
                dinheiro = dinheiro - 100;
                notasVetor[0]++;
            }

            while (dinheiro >= 50) {
                dinheiro = dinheiro - 50;
                notasVetor[1]++;
            }

            while (dinheiro >= 20) {
                dinheiro = dinheiro - 20;
                notasVetor[2]++;
            }

            while (dinheiro >= 10) {
                dinheiro = dinheiro - 10;
                notasVetor[3]++;
            }

            while (dinheiro >= 5) {
                dinheiro = dinheiro - 5;
                notasVetor[4]++;
            }

            while (dinheiro >= 2) {
                dinheiro = dinheiro - 2;
                notasVetor[5]++;
            }

            while (dinheiro >= 1) {
                dinheiro = dinheiro - 1;
                moedasVetor[0]++;
            }

            while (dinheiro >= 0.5) {
                dinheiro = dinheiro - 0.5;
                moedasVetor[1]++;
            }

            while (dinheiro >= 0.25) {
                dinheiro = dinheiro - 0.25;
                moedasVetor[2]++;
            }

            while (dinheiro >= 0.10) {
                dinheiro = dinheiro - 0.10;
                moedasVetor[3]++;
            }

            while (dinheiro >= 0.05) {
                dinheiro = dinheiro - 0.05;
                moedasVetor[4]++;
            }

            while (dinheiro >= 0.01) {
                dinheiro = dinheiro - 0.01;
                moedasVetor[5]++;
            }


            Console.WriteLine($"NOTAS:\n{notasVetor[0]} nota(s) de R$ 100.00\n" +
                    $"{notasVetor[1]} nota(s) de R$ 50.00\n{notasVetor[2]} nota(s) de R$ 20.00\n" +
                    $"{notasVetor[3]} nota(s) de R$ 10.00\n{notasVetor[4]} nota(s) de R$ 5.00\n" +
                    $"{notasVetor[5]} nota(s) de R$ 2.00");

            Console.WriteLine($"MOEDAS:\n{moedasVetor[0]} moeda(s) de R$ 1.00\n" +
                    $"{moedasVetor[1]} moeda(s) de R$ 0.50\n{moedasVetor[2]} moeda(s) de R$ 0.25\n" +
                    $"{moedasVetor[3]} moeda(s) de R$ 0.10\n{moedasVetor[4]} moeda(s) de R$ 0.05\n" +
                    $"{moedasVetor[5]} moeda(s) de R$ 0.01\n");

        }
    }
}
