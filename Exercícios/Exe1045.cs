using System;

namespace Beecrowd.Exercícios {
     class Exe1045 {
        public static void Executar() {

            string[] ladosTriangulo = Console.ReadLine().Split();

            double ladoA = double.Parse(ladosTriangulo[0]);
            double ladoB = double.Parse(ladosTriangulo[1]);
            double ladoC = double.Parse(ladosTriangulo[2]);

            double maior;

            if(ladoB > ladoA) {
                maior = ladoA;
                ladoA = ladoB;
                ladoB = maior;
            }
            if (ladoC > ladoA) {
                maior = ladoA;
                ladoA = ladoC;
                ladoC = maior;
            }

            double quadradoA = Math.Pow(ladoA, 2);
            double quadradoB = Math.Pow(ladoB, 2);
            double quadradoC = Math.Pow(ladoC, 2);

            double quadradoBC = quadradoB + quadradoC;


            if (ladoA >= ladoB + ladoC) {
                Console.WriteLine("NAO FORMA TRIANGULO");

            } else {

                if (quadradoA == quadradoBC) {
                    Console.WriteLine("TRIANGULO RETANGULO");

                }
                if (quadradoA > quadradoBC) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                }
                if (quadradoA < quadradoBC) {
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                }
                if (ladoA == ladoB && ladoB == ladoC) {
                    Console.WriteLine("TRIANGULO EQUILATERO");

                }
                if ((ladoA == ladoB && ladoA != ladoC) || (ladoB == ladoC && ladoB != ladoA)
                    || ladoC == ladoA && ladoC != ladoB) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
