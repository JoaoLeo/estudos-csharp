using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ComparadorDeMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de notas a serem salvas: ");
            int qtdNotas = Convert.ToInt32(Console.ReadLine());
            double[] notas = new double[qtdNotas];
            
            for (int c = 0; c < qtdNotas; c++) // Adicionando valores no array atráves do for
            {
                Console.Write($"Digite a nota {c + 1}: ");
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                notas[c] = nota;
            }
            
            Console.Write("Notas cadastradas: | ");

            foreach (double nota in notas) // Mostrando o array atráves do foreach
            {
                Console.Write(nota + " | ");
            }

            double somaNotas = Convert.ToDouble(notas.Sum());
            
            Console.WriteLine();

            double media = somaNotas / Convert.ToDouble(qtdNotas);

            Console.WriteLine("----------------------------------");

            Console.Write("Digite sua nota: ");
            double notaAluno = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Média das notas: " + media.ToString("F1"));
            Console.WriteLine("Sua nota: " + notaAluno.ToString("F1"));

            Console.WriteLine("----------------------------------");

            if(notaAluno > media)
            {
                Console.WriteLine("Sua nota ficou acima da média, parabéns!");
            } 
            else if (notaAluno == media)
            {
                Console.WriteLine("Sua nota ficou na média, ok!");
            }
            else
            {
                Console.WriteLine("Sua nota ficou abaixo da média, estude mais da proxima vez!");
            }

            Console.ReadLine();
    
        }  
    }
}
