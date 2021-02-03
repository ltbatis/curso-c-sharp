using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: "+estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " +idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de dols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario dos sonhos: " + salario);

            int menorValorInt = int.MinValue; // mais usados do inteiro
            Console.WriteLine("Menor int: "+ menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira: "+populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long: "+menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populacao Mundial: "+ populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço computador: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00; // mais usado
            Console.WriteLine("Valor Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: "+ letra);

            string texto = "Seja bem vindo ao curso de csharp";
            Console.WriteLine(texto);
        }
    }
}
