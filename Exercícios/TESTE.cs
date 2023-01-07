using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd.Exercícios {
    class TESTE {
        public static void Executar() {

            int resultadoEmpate = 0;
            int resultadoInter = 0;
            int resultadoGremio = 0;
            int golsGremio;
            int golsInter;
            int grenais = 0;
            int resposta = 1;
            string maiorVencedor = "";

            while (resposta == 1) {
                string[] times = Console.ReadLine().Split();
                golsInter = int.Parse(times[0]);
                golsGremio = int.Parse(times[1]);

                grenais += 1;

                if (golsInter > golsGremio) {
                    resultadoInter += 1;
                } else if (golsInter < golsGremio) {
                    resultadoGremio += 1;
                } else {
                    resultadoEmpate += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");

                resposta = int.Parse(Console.ReadLine());

                if (resultadoInter > resultadoGremio) {
                    maiorVencedor = "Inter";
                } else {
                    maiorVencedor = "Gremio";
                }
            }

            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{resultadoInter}");
            Console.WriteLine($"Gremio:{resultadoGremio} ");
            Console.WriteLine($"Empates:{resultadoEmpate}");
            Console.WriteLine($"{maiorVencedor} venceu mais");
        }
    }
}
