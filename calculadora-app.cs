using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace estudos
{
    internal class Program
    {
        enum opcao { sum = 1, sub, mult, div, quit } //Index começa com 1 
        static void Main(string[] args)
        {
            bool opcContinue = true;
            while (opcContinue)
            {
        
                Console.WriteLine("==========================");
                Console.WriteLine("Selecione uma das opções abaixo");
                Console.WriteLine(" 1- Somar \n 2- Subtrair \n 3- Multiplicar \n 4- Dividir \n 5- Sair do programa");
                int index = int.Parse(Console.ReadLine());
                if (index == 5)
                {
                    opcContinue = false;
                    break;
                }
                Console.WriteLine("==========================");
                Console.WriteLine("Digite um número inteiro");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número inteiro");
                int num2 = int.Parse(Console.ReadLine());
                opcao opcaoSelecionada = (opcao)index;
                switch (opcaoSelecionada)
                {
                    case opcao.sum:
                        Console.WriteLine("Resultado: ");
                        Console.WriteLine(num1 + num2);
                        break;
                    case opcao.sub:
                        Console.WriteLine("Resultado: ");
                        Console.WriteLine(num1 - num2);
                        break;
                    case opcao.mult:
                        Console.WriteLine("Resultado: ");
                        Console.WriteLine(num1 * num2);
                        break;
                    case opcao.div:
                        Console.WriteLine("Resultado: ");
                        Console.WriteLine(num1 / num2);
                        break;
                    
                    default:
                        Console.WriteLine("Digite um valor acima!");
                        break;
                }
            }
            

        }
    }
}    
       

