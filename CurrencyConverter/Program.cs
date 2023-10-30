using System;
namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Conversor de Moedas");

            bool executando = true;

            while (executando)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Real para Dólar");
                Console.WriteLine("2 - Real para Euro");
                Console.WriteLine("3 - Dólar para Real");
                Console.WriteLine("4 - Euro para Real");
                Console.WriteLine("5 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RealParaDolar();
                        break;
                    case 2:
                        RealParaEuro();
                        break;
                    case 3:
                        DolarParaReal();
                        break;
                    case 4:
                        EuroParaReal();
                        break;
                    case 5:
                        executando = false;
                        break;
                    default: 
                        Console.WriteLine();
                        break;
                }
            }
        }

        private static void EuroParaReal()
        {
            Console.WriteLine("Digite o valor em Euro: ");
            decimal valorEuro = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 6.19m;

            decimal valorReal = valorEuro * taxaCambio;

            Console.WriteLine($"Valor em Reais: {valorReal}");
            Console.WriteLine("");
        }

        private static void DolarParaReal()
        {
            Console.WriteLine("Digite o valor em Dólar: ");
            decimal valorDolar = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 5.01m;

            decimal valorReal = valorDolar * taxaCambio;

            Console.WriteLine($"Valor em Reais: {valorReal}");
            Console.WriteLine("");
        }

        private static void RealParaDolar()
        {            
            Console.WriteLine("Digite o valor em Reais: ");
            decimal valorReal = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 5.01m;

            decimal valorDolar = valorReal / taxaCambio;

            Console.WriteLine($"Valor em Dólar: {valorDolar}");
            Console.WriteLine("");
        }

        private static void RealParaEuro()
        {
            Console.WriteLine("Digite o valor em Reais: ");
            decimal valorReal = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 6.19m;

            decimal valorEuro = valorReal / taxaCambio;

            Console.WriteLine($"Valor em Euro: {valorEuro}");
            Console.WriteLine("");
        }
    }    

}


