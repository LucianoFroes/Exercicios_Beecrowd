using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
     class Exe1020 {
        public static void Executar() {

            int quantidadeDias = int.Parse(Console.ReadLine());

            int quantidadeAnos = quantidadeDias / 365;
            quantidadeDias = quantidadeDias % 365;

            int quantidadeMeses = quantidadeDias / 30;
            quantidadeDias = quantidadeDias % 30;

            int dias = quantidadeDias;

            Console.WriteLine($"{quantidadeAnos} ano(s)\n"
                + $"{quantidadeMeses} mes(es)\n{dias} dia(s)");

        }
    }
}
