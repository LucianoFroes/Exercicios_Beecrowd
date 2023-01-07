using System;


namespace Beecrowd.Exercícios {
     class Exe1043 {
        public static void Executar() {

            string[] numeros = Console.ReadLine().Split();

            double a = double.Parse(numeros[0]);
            double b = double.Parse(numeros[1]);
            double c = double.Parse(numeros[2]);

            double menorAB = Math.Min(a, b);
            double menorTodos = Math.Min(menorAB, c);

            double maiorAB = Math.Max(a, b);
            double maiorTodos = Math.Max(maiorAB, b);

            double perimetroTriangulo = a + b + c;
            double areaTrapezio = ((maiorAB + menorAB) * c) / 2;

            if((menorAB + menorTodos) > maiorTodos) {
                Console.WriteLine($"Perimetro = {perimetroTriangulo:F1}");
            } else {
                Console.WriteLine($"Area = {areaTrapezio:F1}");
            }


        }
    }
}
