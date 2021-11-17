using System;

namespace ConverterPolegadasEmMilimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            //1º Declarar variáveis e respectivos tipos
            float valorPol = 0;
            const float fator = 25.4f;
            float resultado;

            //2º Solicitar e ler valor
            Console.WriteLine("Digite um valor em polegadas para ser convertido em milímetros:");
            valorPol = float.Parse(Console.ReadLine());

            //3º Processamento
            resultado = valorPol*fator;

            //4º Escrever o valor inserido em milímetros
            Console.WriteLine("O valor de " + valorPol + " polegada(s) é " + resultado + " milímetros."+ "\n");

            //5º Efectuada a leitura do código
            Console.ReadLine();
            Console.Clear();
        }
    }
}
