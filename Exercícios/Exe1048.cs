using System;

namespace Beecrowd.Exercícios {
     class Exe1048 {
        public static void Executar() {

            double salario = double.Parse(Console.ReadLine());
            double reajuste = 0;

            if(salario <= 400.00) {
                reajuste = salario * 0.15;
                salario *= 1.15;

                Console.WriteLine($"Novo salario: {salario:F2}\nReajuste ganho: {reajuste:F2}" +
                    $"\nEm percentual: 15 %");

            }else if(salario > 400.00 && salario <= 800.00) {
                reajuste = salario * 0.12;
                salario *= 1.12;

                Console.WriteLine($"Novo salario: {salario:F2}\nReajuste ganho: {reajuste:F2}" +
                    $"\nEm percentual: 12 %");

            } else if(salario > 800.00 && salario <= 1200.00) {
                reajuste = salario * 0.10;
                salario *= 1.10;

                Console.WriteLine($"Novo salario: {salario:F2}\nReajuste ganho: {reajuste:F2}" +
                    $"\nEm percentual: 10 %");

            }else if(salario > 1200.00 && salario <= 2000.00) {
                reajuste = salario * 0.07;
                salario *= 1.07;

                Console.WriteLine($"Novo salario: {salario:F2}\nReajuste ganho: {reajuste:F2}" +
                    $"\nEm percentual: 7 %");

            } else if (salario > 2000.00) {
                reajuste = salario * 0.04;
                salario *= 1.04;

                Console.WriteLine($"Novo salario: {salario:F2}\nReajuste ganho: {reajuste:F2}" +
                    $"\nEm percentual: 4 %");
            }

        }
    }
}
