using System;


namespace Beecrowd.Exercícios {
     class Exe1013 {
        public static void Executar() {

            string[] numeros = Console.ReadLine().Split(); // Split separa a String determinado pelo caracter dentro das aspas.   
                                                 // Por padrão ele separa por espaços.
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);

            int maior = (n1 + n2 + Math.Abs(n1 - n2)) / 2;

            maior = (maior + n3 + Math.Abs(maior - n3)) / 2;

            Console.WriteLine($"{maior} eh o maior");

        }

    }
}
