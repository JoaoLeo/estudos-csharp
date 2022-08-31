using System;

namespace EquacaoSegundoGrau
{
    internal class Program
    {

         static double delta(double a= 0, double b = 0, double c = 0)
            {
                double delta = (b * b) - (4 * a *  c);
                return delta;
            }

        static void Main(string[] args)
        {

            Console.WriteLine("RESOLUÇÃO EQUAÇÃO SEGUNDO GRAU");
            
            Console.WriteLine("SEGUINDO A FÓRMULA: ax² + bx + c = 0  ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Digite o valor de: ");

            Console.Write("A = "); 
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("B = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("C = ");
            double c = Convert.ToDouble(Console.ReadLine());
                        
            double resDelta = delta(a,b,c); 

            Console.WriteLine();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"{a}x² + {b}x + {c} = 0"); 
            Console.WriteLine($"Delta = {resDelta}");
           
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Seguindo a formula de bhaskara o resultado da sua equação de segundo grau é: ");

            if(resDelta > 0) 
            {
                double x1 = (-b + Math.Sqrt(resDelta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(resDelta)) / (2 * a);
                Console.WriteLine($"X1 = {x1.ToString("F1")}");
                Console.WriteLine($"X2 = {x2.ToString("F1")}");
            }
            else if(resDelta == 0)
            {
                double x1 = (-b + Math.Sqrt(resDelta)) / (2* a);
                Console.WriteLine($"X1 e X2 = {x1.ToString("F1")}");
            }
            else
            {
                Console.WriteLine("Não possui raízes reais");
            }

            Console.ReadLine();
        }
    }
}