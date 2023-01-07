using System;

namespace Beecrowd.Exercícios {
    class Exe1131 {
        public static void Executar() {

            int jogosGremio = 0, placarGremio = 0;
            int jogosInter = 0, placarInter = 0;
            int empates = 0, novoJogo = 0;
            int qntGrenais = 0;

            while (true) {

                string[] valoresGrenais = Console.ReadLine().Split();

                placarInter = int.Parse(valoresGrenais[0]);
                placarGremio = int.Parse(valoresGrenais[1]);

                if (placarInter > placarGremio) {
                    jogosInter++;
                    qntGrenais++;
                    placarGremio = 0;
                    placarInter = 0;

                } else if (placarInter == placarGremio) {
                    empates++;
                    qntGrenais++;
                    placarGremio = 0;
                    placarInter = 0;

                } else {
                    jogosGremio++;
                    qntGrenais++;
                    placarGremio = 0;
                    placarInter = 0;

                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoJogo = int.Parse(Console.ReadLine());

                if (novoJogo == 2) {
                    Console.WriteLine($"{qntGrenais} grenais");
                    Console.WriteLine($"Inter:{jogosInter}");
                    Console.WriteLine($"Gremio:{jogosGremio}");
                    Console.WriteLine($"Empates:{empates}");

                    if(jogosInter > jogosGremio) {
                        Console.WriteLine("Inter venceu mais");

                    } else {
                        Console.WriteLine("Gremio venceu mais");
                    }

                    break;

                } else {
                    continue;
                }
            }
        }
    }
}
