using System;

namespace BuscaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] Mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    Mat[i, j] = int.Parse(numbers[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < m; i++)
            {
               for (int j = 0; j < n; j++)
                {
                    if (x == Mat[i, j])
                    {
                        Console.Write("Position:" + i + "," + j);
                        Console.WriteLine();
                        int a = j - 1; 
                            if (a >= 0 && a <= m && a <= n) 
                            { 
                                Console.Write("Left:" + Mat [i,a]);
                                Console.WriteLine();
                            }
                        int b = j + 1;
                            if (b >= 0 && b <= m && b <= n)
                            {
                                Console.Write("Right:" + Mat[i, b]);
                                Console.WriteLine();
                            }
                        int c = i - 1;
                            if (c >= 0 && c <= m && c <= n)
                            {
                                Console.Write("Up:" + Mat[c, j]);
                                Console.WriteLine();
                            }
                        int d = i + 1;
                            if (d >= 0 && d <= m && d <= n)
                            {
                                Console.Write("Down:" + Mat[d, j]);
                                Console.WriteLine();
                            }
                        
                    }
                }
            }
            
        }
    }
}
