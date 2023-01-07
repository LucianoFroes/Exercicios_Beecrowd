using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
    class Exe1009 {
        public static void Executar() {

            string nomeVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double valorVendas = double.Parse(Console.ReadLine());

            double bonusVendas = valorVendas * 0.15;
            double salario = salarioFixo + bonusVendas;

            Console.WriteLine($"TOTAL = R$ {salario:F2}");
        }
    }
}
