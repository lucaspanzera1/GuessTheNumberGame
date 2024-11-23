using System;

namespace LogP3Etapa
{
    internal class Program
    {
        static void MostrarTitulo(string titulo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔═════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║{titulo.PadLeft((65 + titulo.Length) / 2).PadRight(65)}║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        static void MostrarCartela(string titulo, int[,] matriz)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n┌── {titulo} ───────────────────────────────────────┐");
            Console.ResetColor();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("│  ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{matriz[i, j],2} ");
                    Console.ResetColor();
                }
                Console.WriteLine(" │");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("└──────────────────────────────────────────────────┘");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.Title = "Jogo de Adivinhação - por Lucas Panzera";
            
            int[,] mat1 = new int[8, 4] { { 32, 33, 34, 35 }, { 36, 37, 38, 39 }, { 40, 41, 42, 43 }, { 44, 45, 46, 47 }, { 48, 49, 50, 51 }, { 52, 53, 54, 55 }, { 56, 57, 58, 59 }, { 60, 61, 62, 63 } };
            int[,] mat2 = new int[8, 4] { { 2, 3, 6, 7 }, { 10, 11, 14, 15 }, { 18, 18, 22, 23 }, { 26, 27, 30, 31 }, { 34, 35, 38, 39 }, { 42, 43, 46, 47 }, { 50, 51, 54, 55 }, { 58, 59, 62, 63 } };
            int[,] mat3 = new int[8, 4] { { 8, 9, 10, 11 }, { 12, 13, 14, 15 }, { 24, 25, 26, 27 }, { 28, 29, 30, 31 }, { 40, 41, 42, 43 }, { 44, 45, 46, 47 }, { 56, 57, 58, 59 }, { 60, 61, 62, 63 } };
            int[,] mat4 = new int[8, 4] { { 4, 5, 6, 7 }, { 12, 13, 14, 15 }, { 20, 21, 22, 23 }, { 28, 29, 30, 31 }, { 36, 37, 38, 39 }, { 44, 45, 46, 47 }, { 52, 53, 54, 55 }, { 60, 61, 62, 63 } };
            int[,] mat5 = new int[8, 4] { { 1, 3, 5, 7 }, { 9, 11, 13, 15 }, { 17, 18, 21, 23 }, { 25, 27, 29, 31 }, { 33, 35, 37, 39 }, { 41, 43, 45, 47 }, { 49, 51, 53, 55 }, { 57, 59, 61, 63 } };
            int[,] mat6 = new int[8, 4] { { 16, 17, 18, 19 }, { 20, 21, 22, 23 }, { 24, 25, 26, 27 }, { 28, 29, 30, 31 }, { 48, 49, 50, 51 }, { 52, 53, 54, 55 }, { 56, 57, 58, 59 }, { 60, 61, 62, 63 } };

            Console.Clear();
            MostrarTitulo("Jogo de Adivinhação");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n► Pense em um número de 1 a 63 e pressione ENTER para continuar...");
            Console.ResetColor();
            Console.ReadKey();

            Console.Clear();
            MostrarCartela("Cartela 1", mat1);
            MostrarCartela("Cartela 2", mat2);
            MostrarCartela("Cartela 3", mat3);
            MostrarCartela("Cartela 4", mat4);
            MostrarCartela("Cartela 5", mat5);
            MostrarCartela("Cartela 6", mat6);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n╔═════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  Digite os números das cartelas onde seu número aparece (1-6)    ║");
            Console.WriteLine("║  Digite 9 quando terminar para que eu adivinhe seu número        ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            int numeros = 0;
            int valor = 0;
            while (numeros != 9)
            {
                Console.Write("\nCartela → ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                numeros = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (numeros)
                {
                    case 1: valor += 32; break;
                    case 2: valor += 2; break;
                    case 3: valor += 8; break;
                    case 4: valor += 4; break;
                    case 5: valor += 1; break;
                    case 6: valor += 16; break;
                }
            }

            Console.Clear();
            MostrarTitulo("Resultado");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n╔═════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║           O número que você pensou é: {valor,-25} ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n                     Desenvolvido por Lucas Panzera");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}