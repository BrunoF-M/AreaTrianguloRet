using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine("Olá eu sou a Calculadora de Area Triangulo Retangulo =).. \n");
            Console.ResetColor();

            Console.WriteLine("...enter para continuar");
            Console.ReadLine();

            double valorBase;
            double valorAltura;

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Write("Digite o valor da Base =) : ");
            Console.ResetColor();
            valorBase = Double.Parse(Console.ReadLine());


            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Write("Ok! Base =):");
            Console.ResetColor();
            Console.WriteLine($" {valorBase}");

            Console.WriteLine();

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Write("Agora Digite a Altura =|...: ");
            Console.ResetColor();
            valorAltura = double.Parse(Console.ReadLine());

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Write("Ok a Altura é =): ");
            Console.ResetColor();
            Console.WriteLine($" {valorAltura}");

            Console.WriteLine();
            
            double resultado = valorBase * valorAltura;

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Write($"Hmm =\\ O Resultado da Área éé..: ");
            Console.ResetColor();
            Console.WriteLine($"{resultado / 2}");            

            Console.WriteLine();
            
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine("Fim =) aperte qualque tecla para Encerrar...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
