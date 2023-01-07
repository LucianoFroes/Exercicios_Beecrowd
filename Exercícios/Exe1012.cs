﻿using System;

namespace Beecrowd.Exercícios {
     class Exe1012 {
        public static void Executar() {

            String[] valores = Console.ReadLine().Split();

            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double areaTrianguloRet = (a * c) / 2;
            double areaCirculo = 3.14159 * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTrianguloRet:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
        }
    }
}
