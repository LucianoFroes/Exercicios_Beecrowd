using System;

namespace Beecrowd.Exercícios {
     class Exe1051 {
        public static void Executar() {

            double salario = double.Parse(Console.ReadLine());
            double impostoRenda;
            double impostoRenda2;
            double impostoRenda3;
            double somaImposto;

            if (salario < 2000.00) {
                Console.WriteLine("Isento");

            } else if (salario >= 2000.01 && salario <= 3000.00) {
                impostoRenda = (salario - 2000.00) * 0.08;

                Console.WriteLine($"R$ {impostoRenda:F2}");

            } else if (salario >= 3000.01 && salario <= 4500.00) {
                impostoRenda = 1000.00 * 0.08;
                impostoRenda2 = (salario - 3000.00) * 0.18;
                somaImposto = impostoRenda + impostoRenda2;

                Console.WriteLine($"R$ {somaImposto:F2}");

            } else if (salario > 4500.00) {
                impostoRenda = 1000.00 * 0.08;
                impostoRenda2 = 1500.00 * 0.18;
                impostoRenda3 = (salario - 4500.00) * 0.28;
                somaImposto = impostoRenda + impostoRenda2 + impostoRenda3;

                Console.WriteLine($"R$ {somaImposto:F2}");

            }
        }
    }
}
