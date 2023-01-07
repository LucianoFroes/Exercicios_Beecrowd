using System;


namespace Beecrowd.Exercícios {
     class Exe1040 {
        public static void Executar() {

            string[] notas = Console.ReadLine().Split();

            double nota1 = Math.Round(double.Parse(notas[0]), 1);  
            double nota2 = Math.Round(double.Parse(notas[1]), 1);
            double nota3 = Math.Round(double.Parse(notas[2]), 1);  
            double nota4 = Math.Round(double.Parse(notas[3]), 1);

            double notaExame = 0.0;

            double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10;
            double mediaExame = 0.0; 

            Console.WriteLine($"Media: {Math.Truncate(media * 10) / 10:F1}");

            if(media >= 5.0 && media <= 6.9) {
                Console.WriteLine("Aluno em exame.");

                 notaExame = double.Parse(Console.ReadLine());
                 mediaExame = (notaExame + media) / 2;

                Console.WriteLine($"Nota do exame: {notaExame:F1}");

                if (mediaExame >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaExame:F1}");
                } else {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {mediaExame:F1}");
                }

            }else if(media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            } else {
                Console.WriteLine("Aluno aprovado.");
            }
        } 
    }
}
