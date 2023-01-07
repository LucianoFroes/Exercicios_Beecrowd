using System;

namespace Beecrowd.Exercícios {
    class Exe1118 {
        public static void Executar() {

            int contNota = 0;
            double somaNotas = 0;

            while (contNota >= 0 && contNota <= 1) {

                double nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10) {
                    Console.WriteLine("nota invalida");

                } else {
                    contNota++;
                    somaNotas += nota;
                }

                if(contNota == 2) {

                    double media = somaNotas / 2;
                    Console.WriteLine($"media = {media:F2}");

                    while (true) {
                        
                        Console.WriteLine("novo calculo (1-sim 2-nao)");

                        int controleRepetir = int.Parse(Console.ReadLine());

                        if(controleRepetir == 2) {
                            break;

                        }else if (controleRepetir == 1) {
                            contNota = 0;
                            somaNotas = 0;
                            break;
                        } 
                    }
                }
            }
        }
    }
}
