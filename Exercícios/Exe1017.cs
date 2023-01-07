using System;


namespace Beecrowd.Exercícios {
     class Exe1017 {
        public static void Executar() {

            int horas = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            int kmRodados = horas * velocidadeMedia;
            double consumoLitros = kmRodados / 12.0;

            Console.WriteLine($"{consumoLitros:F3}");
        }
    }
}
