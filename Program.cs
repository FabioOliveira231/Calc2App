using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
        enum OpcaoMenu { Sair, Somar, Subtracao, Divisao, Multiplicacao, Porcentagem, Potencia, Raiz, Tabuada };
        static void Main(string[] args)
        {

            bool queroSair = false;
            while (!queroSair)
            {
                Console.WriteLine("Seja Bem vindo ao Calc2App. Escolha uma das opções a baixo:");
                Console.WriteLine(" ");
                Console.WriteLine("(1) - Somar\n(2) - Subtrair\n(3) - Divisão\n(4) - Multiplicação\n(5) - Porcentagem\n(6) - Potenciação\n(7) - Raiz\n(8) - E se ainda quiser saber a tabuada" +
                    "\n(0) - SAIR ");
                int index = int.Parse(Console.ReadLine());
                OpcaoMenu opcaoSelecionado = (OpcaoMenu)index;

                switch (opcaoSelecionado)
                {
                    case OpcaoMenu.Sair:
                        queroSair = true;
                        Console.WriteLine();
                        break;

                    case OpcaoMenu.Somar:
                        Somar();
                        break;

                    case OpcaoMenu.Subtracao:
                        Subtracao();
                        break;

                    case OpcaoMenu.Divisao:
                        Divisao();
                        break;

                    case OpcaoMenu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case OpcaoMenu.Porcentagem:
                        Porcentagem();
                        break;

                    case OpcaoMenu.Potencia:
                        Potencia();
                        break;

                    case OpcaoMenu.Raiz:
                        Raiz();
                        break;

                    case OpcaoMenu.Tabuada:
                        Tabuada();
                        break;
                }
             
            }
        }

        static void Somar()
        {
            Console.WriteLine("Você escolheu a opção Somar");
            Console.WriteLine("Digite o primeiro numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int y = int.Parse(Console.ReadLine());
            int result = x + y;
            Console.WriteLine($"A Soma de {x} + {y} = {result}");
            Console.WriteLine(" ");
        }

        static void Subtracao()
        {
            Console.WriteLine("Você escolheu a opção Subtração");
            Console.WriteLine("Digite o primeiro numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int y = int.Parse(Console.ReadLine());
            int result = x - y;
            Console.WriteLine($"A Subtração de {x} - {y} = {result}");
            Console.WriteLine(" ");

        }


        static void Divisao()
        {
            Console.WriteLine("Você escolheu a opção Divisão");
            Console.WriteLine("Digite o primeiro numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float y = float.Parse(Console.ReadLine());
            float result = x / y;
            Console.WriteLine($"A Divisão de {x} / {y} = {result}");
            Console.WriteLine(" ");
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Você escolheu a opção Multiplicação");
            Console.WriteLine("Digite o primeiro numero: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float y = float.Parse(Console.ReadLine());
            float result = x * y;
            Console.WriteLine($"A Multiplicação de {x} * {y} = {result}");
            Console.WriteLine(" ");

        }

        static void Porcentagem()
        {
            Console.WriteLine("Você escolheu a opção Porcentagem");
            Console.WriteLine("Digite o primeiro numero: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float y = float.Parse(Console.ReadLine());
            float result = (y / 100) * x;
            Console.WriteLine($"O numero: {x} x {y}% o resultado de: {result}");
            Console.WriteLine(" ");

        }
        static void Potencia()
        {
            Console.WriteLine("Você escolheu a opção Potenciação");
            Console.WriteLine("Digite o primeiro numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float y = float.Parse(Console.ReadLine());
            double result = Math.Pow(x, y);
            Console.WriteLine($"O numero: {x} elevado a potencia de: {y} = {result}");
            Console.WriteLine(" ");
        }

        static void Raiz()
        {
            Console.WriteLine("Você escolheu a opção Raiz");
            Console.WriteLine("Digite o primeiro nuemro: ");
            int x = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(x);
            Console.WriteLine($"A Raiz quadrada de: {x} é {result}");
            Console.WriteLine(" ");
        }


        static void Tabuada()
        {
            Console.WriteLine("Você escolheu a opção Tabuada");
            Console.WriteLine("Digite o nuemro da Tabuada quer saber: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{x} x {contador} = { x * contador}");
            }


        

        }


        

    }
    

}
