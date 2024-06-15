using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class MetodosCal
    {

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Resto da divisão");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("0 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Somar();
                    break;

                case "2":
                    Subtrair();
                    break;

                case "3":
                    Dividir();
                    break;

                case "4":
                    Multiplicacao();
                    break;

                case "5":
                    RestoDaDivisao();
                    break;

                case "6":
                    CalcularPotenciacao();
                    break;

                case "0":
                    break;

                default:
                    Menu();
                    break;

            }

        }


        public void Somar()
        {
            double valor1, valor2;
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
            Console.ReadLine();

            Menu();

        }


        public void Subtrair()
        {
            double valor1, valor2;
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");

            Console.ReadLine();
            Menu();

        }


        public void Dividir()
        {
            double dividendo, divisor;

            Console.WriteLine("Informe o dividendo:");
            dividendo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o divisor:");
            divisor = double.Parse(Console.ReadLine());

            if (divisor != 0)
                Console.WriteLine($"{dividendo} / {divisor} = {dividendo / divisor}");
            else
                Console.WriteLine("Não é possível dividir por zero.");

            Console.ReadLine();
            Menu();

        }

        public void Multiplicacao()
        {
            double valor1, valor2;
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");

            Console.ReadLine();
            Menu();

        }

        public void RestoDaDivisao()
        {
            double dividendo, divisor;

            Console.WriteLine("Informe o dividendo:");
            dividendo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o divisor:");
            divisor = double.Parse(Console.ReadLine());

            if (divisor != 0)
                Console.WriteLine($"Resto entre {dividendo} e {divisor} = {dividendo % divisor}");
            else
                Console.WriteLine("Não é possível dividir por zero.");

            Console.ReadLine();
            Menu();
        }

        public void CalcularPotenciacao()
        {
            double basePotenciacao, expoente;

            Console.WriteLine("Informe a base:");
            basePotenciacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o expoente:");
            expoente = double.Parse(Console.ReadLine());

            Console.WriteLine($"{basePotenciacao} elevado a {expoente} = {Math.Pow(basePotenciacao, expoente)}");

            Console.ReadLine();
            Menu();

        }

    }
}
