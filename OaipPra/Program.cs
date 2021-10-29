using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OaipPra
{
    class Program
    {
        static void ZapolnitMatritzu(int[,] mat, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = rnd.Next(0, 10);
                }
            }
        }
        static void VyvodMatritzu(int[,] mat, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void UNO(int[,] mat1, int[,] mat2, int[,] mat3, int a1, int b1, int b2)
        {
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < b2; j++)
                {
                    mat3[i, j] = 0;
                    for (int k = 0; k < b1; k++)
                    {
                        mat3[i, j] += mat1[i, k] * mat2[k, j];
                    }
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            int n1;
            int m1;
            int n2;
            int m2;
            Console.Write("Строчек первой матрицы: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов первой матрицы: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Строчек второй матрицы: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов второй матрицы: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n1, m2];
            int[,] B = new int[n2, m2];
            ZapolnitMatritzu(A, n1, m1);
            ZapolnitMatritzu(B, n2, m2);
            Console.WriteLine("Беренче матрица");
            VyvodMatritzu(A, n1, m1);
            Console.WriteLine("Икенче матрица");
            VyvodMatritzu(B, n2, m2);
            int[,] C = new int[n1, m2];
            if (n1 == m2)
            {
                Console.WriteLine("Умноженная матрица: ");
                UNO(A, B, C, n1, m1, m2);
            }
            else
            {
                Console.WriteLine("Невазможна");
            }
        }
    }
}
