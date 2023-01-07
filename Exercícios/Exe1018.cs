using System;

namespace Beecrowd.Exercícios {
     class Exe1018 {
        public static void Executar() {

            int dinheiro = int.Parse(Console.ReadLine());
            Console.WriteLine(dinheiro);

            int nota100 = 0;
            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;
            int nota2 = 0;
            int nota1 = 0;

            while(dinheiro >= 100) {
                dinheiro = dinheiro - 100;
                nota100++;
            }

            while (dinheiro >= 50) {
                dinheiro = dinheiro - 50;
                nota50++;
            }

            while (dinheiro >= 20) {
                dinheiro = dinheiro - 20;
                nota20++;
            }

            while (dinheiro >= 10) {
                dinheiro = dinheiro - 10;
                nota10++;
            }

            while (dinheiro >= 5) {
                dinheiro = dinheiro - 5;
                nota5++;
            }

            while (dinheiro >= 2) {
                dinheiro = dinheiro - 2;
                nota2++;
            }
            while (dinheiro >= 1) {
                dinheiro = dinheiro - 1;   
                nota1++;
            }

            Console.WriteLine($"{nota100} nota(s) de R$ 100,00\n" +
                $"{nota50} nota(s) de R$ 50,00\n{nota20} nota(s) de R$ 20,00\n" +
                $"{nota10} nota(s) de R$ 10,00\n{nota5} nota(s) de R$ 5,00\n" +
                $"{nota2} nota(s) de R$ 2,00\n{nota1} nota(s) de R$ 1,00");

        }
    }
}
