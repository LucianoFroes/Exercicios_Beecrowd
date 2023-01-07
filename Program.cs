using System;
using System.Collections.Generic;
using Beecrowd.Exercícios;
using Beecrowd.Exercícios.AD_HOC;


namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Exe 1000 - Hello World!", Exe1000.Executar},
                {"Exe 1001 - Extremamente Básico", Exe1001.Executar},
                {"Exe 1002 - Área do Círculo", Exe1002.Executar},
                {"Exe 1003 - Soma Simples", Exe1003.Executar},
                {"Exe 1004 - Produto Simples", Exe1004.Executar},
                {"Exe 1005 - Média 1", Exe1005.Executar},
                {"Exe 1006 - Média 2", Exe1006.Executar},
                {"Exe 1007 - Diferença", Exe1007.Executar},
                {"Exe 1008 - Salário", Exe1008.Executar},
                {"Exe 1009 - Salário com bônus", Exe1009.Executar},
                {"Exe 1010 - Cálculo Simples", Exe1010.Executar},
                {"Exe 1011 - Esfera", Exe1011.Executar},
                {"Exe 1012 - Área", Exe1012.Executar},
                {"Exe 1013 - O Maior", Exe1013.Executar},
                {"Exe 1014 - Consumo", Exe1014.Executar},
                {"Exe 1015 - Distância Entre Dois Pontos", Exe1015.Executar},
                {"Exe 1016 - Distância", Exe1016.Executar},
                {"Exe 1017 - Gasto de Combustível", Exe1017.Executar},
                {"Exe 1018 - Cédulas", Exe1018.Executar},
                {"Exe 1019 - Conversão de Tempo", Exe1019.Executar},
                {"Exe 1020 - Idade em Dias", Exe1020.Executar},
                {"Exe 1021 - Notas e Moedas", Exe1021.Executar},
                {"Exe 1035 - Teste de Seleção", Exe1035.Executar},
                {"Exe 1036 - Fórmula de Bhaskara", Exe1036.Executar},
                {"Exe 1037 - Intervalo", Exe1037.Executar},
                {"Exe 1038 - Lanche", Exe1038.Executar},
                {"Exe 1040 - Media3", Exe1040.Executar},
                {"Exe 1041 - Coordenadas de um Ponto", Exe1041.Executar},
                {"Exe 1042 - Sort Simples", Exe1042.Executar},
                {"Exe 1043 - Triângulo", Exe1043.Executar},
                {"Exe 1044 - Multiplos", Exe1044.Executar},
                {"Exe 1045 - Tipos de Triângulos", Exe1045.Executar},
                {"Exe 1046 - Tempo de Jogo", Exe1046.Executar},
                {"Exe 1047 - Tempo de Jogo com Minutos", Exe1047.Executar},
                {"Exe 1048 - Aumento de Salário", Exe1048.Executar},
                {"Exe 1049 - Animal", Exe1049.Executar},
                {"Exe 1050 - DDD", Exe1050.Executar},
                {"Exe 1051 - Imposto de Renda", Exe1051.Executar},
                {"Exe 1052 - Mês", Exe1052.Executar},
                {"Exe 1059 - Números Pares", Exe1059.Executar},
                {"Exe 1060 - Números Positivos", Exe1060.Executar},
                {"Exe 1064 - Positivos e Média", Exe1064.Executar},
                {"Exe 1065 - Pares entre Cinco Numeros", Exe1065.Executar},
                {"Exe 1067 - Números Ímpares", Exe1067.Executar},
                {"Exe 1070 - Seis Números Ímpares", Exe1070.Executar},
                {"Exe 1071 - Soma de Ímpares Consecutivos", Exe1071.Executar},
                {"Exe 1072 - Intervalo 2", Exe1072.Executar},
                {"Exe 1073 - Quadrado de Pares", Exe1073.Executar},
                {"Exe 1074 - Par ou Ímpar", Exe1074.Executar},
                {"Exe 1075 - Resto2", Exe1075.Executar},
                {"Exe 1078 - Tabuada", Exe1078.Executar},
                {"Exe 1079 - Médias Ponderadas", Exe1079.Executar},
                {"Exe 1080 - Maior e Posição", Exe1080.Executar},
                {"Exe 1094 - Experiências", Exe1094.Executar},
                {"Exe 1095 - Sequencia IJ 1", Exe1095.Executar},
                {"Exe 1096 - Sequencia IJ 2", Exe1096.Executar},
                {"Exe 1097 - Sequencia IJ 3", Exe1097.Executar},
                {"Exe 1098 - Sequencia IJ 4", Exe1098.Executar},
                {"Exe 1099 - Soma de Ímpares Consecutivos 2", Exe1099.Executar},
                {"Exe 1101 - Sequência de Números e Soma", Exe1101.Executar},
                {"Exe 1113 - Crescente e Decrescente", Exe1113.Executar},
                {"Exe 1114 - Senha Fixa", Exe1114.Executar},
                {"Exe 1115 - Quadrante", Exe1115.Executar},
                {"Exe 1116 - Dividindo X por Y", Exe1116.Executar},
                {"Exe 1117 - Validação de Nota", Exe1117.Executar},
                {"Exe 1118 - Várias Notas Com Validação", Exe1118.Executar},
                {"Exe 1131 - Grenal", Exe1131.Executar},
                {"Exe 1132 - Multiplos de 13", Exe1132.Executar},
                {"Exe 1165 - Número Primo", Exe1165.Executar},
                {"Exe 2454 - Fliper", Exe2454.Executar},
                // AD-HOC
                {"Exe 1026 - Carrega ou não Carrega ?", Exe1026.Executar},
                // Refazendo Exercícios
                {"Refaz 1000 - Hello World!",Refaz1000.Executar},
                {"Refaz 1001 - Extremamente Básico",Refaz1001.Executar},
                {"Refaz 1002 - Área do Círculo",Refaz1002.Executar},
                {"Refaz 1003 - Soma Simples",Refaz1003.Executar},
                {"TESTE",TESTE.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}