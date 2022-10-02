using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#define TASK1
//#define TASK2 задание решено частично, сумма считается неправильно
//#define TASK4
namespace Homework2_array_string
{
    class Program
    {
        static void Main(string[] args)
        {
#if TASK1
            int size = 5, stroka = 3, stolbec = 4, Amulty = 0, Aeven = 0;

            int[] A = new int[size];
            for (int i = 0; i < size; ++i)
            {
                A[i] = int.Parse(Console.ReadLine());
                Amulty *= A[i];
                if (i % 2 == 0) Aeven += A[i];
            }
            Console.WriteLine();
            foreach (int r in A)
                Console.Write(r + " "); Console.WriteLine();
            Console.WriteLine("\n");

            double[,] B = new double[stroka, stolbec];
            Random random = new Random();
            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    B[i, j] = random.Next(20);
                    Console.Write("{0,4}", B[i, j]);
                }
                Console.WriteLine();
            }
            double Bmax = B[0, 0], Bmin = B[0, 0], Bsum = 0, Bmulty = 0, Buneven = 0;

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (Bmax < B[i, j]) Bmax = B[i, j];
                    if (Bmin > B[i, j]) Bmin = B[i, j];
                    Bsum += B[i, j];
                    Bmulty *= B[i, j];
                    if (j % 2 != 0) Buneven += B[i, j];
                }
            }
            double max, min, sum, multy;
            if (A.Max() > Bmax) max = A.Max();
            else max = Bmax;
            Console.WriteLine("Общий максимальный элемент массивов А и В: {0}", max);

            if (A.Min() > Bmin) min = Bmin;
            else min = A.Min();
            Console.WriteLine("Общий минимальный элемент массивов А и В: {0}", min);

            sum = A.Sum() + Bsum; Console.WriteLine("Общая сумма элементов массивов А и В: {0}", sum);
            multy = Amulty + Bmulty; Console.WriteLine("Общее произведение элементов массивов А и В: {0}", multy);

            Console.WriteLine("Сумма четных элементов массива А {0}", Aeven);
            Console.WriteLine("Сумма нечетных столбцов массива B {0}", Buneven);
#endif
#if TASK2
            int stroka = 3, stolbec = 3;

            int[,] A = new int[stroka, stolbec];
            int min = A[0, 0];
            int max = A[0, 0];
            int minIndex_X = 0;
            int minIndex_Y = 0;
            int maxIndex_X = 0;
            int maxIndex_Y = 0;
            Random random = new Random();
            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    A[i, j] = random.Next(-100, 100);
                    Console.Write("{0,4}", A[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("");

            for (int i = 0; i < stroka; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    if (A[i, j] > max) { max = A[i, j]; maxIndex_X = i; maxIndex_Y = j; }
                    if (A[i, j] < min) { min = A[i, j]; minIndex_X = i; minIndex_Y = j; }
                }
            }
            min = A[minIndex_X, minIndex_Y];
            max = A[maxIndex_X, maxIndex_Y];
            int sum = 0;
            if (minIndex_X < maxIndex_X)
            {
                int i = minIndex_X;
                for (; i == minIndex_X; i++)
                {
                    for (int j = minIndex_Y; j < stolbec; j++)
                    {
                        sum += A[i, j];

                    }
                }
                for (/*int i = minIndex_X + 1*/; i <= maxIndex_X; i++)
                {
                    for (int j = 0; j <= maxIndex_Y; j++)
                    {
                        sum += A[i, j];
                    }

                }
            }
            if (minIndex_X > maxIndex_X)
            {
                int i = maxIndex_X;
                for (; i == maxIndex_X; i++)
                {
                    for (int j = maxIndex_Y; j < stolbec; j++)
                    {
                        sum += A[i, j];

                    }
                }
                for (/*int i = minIndex_X + 1*/; i <= minIndex_X; i++)
                {
                    for (int j = 0; j <= minIndex_Y; j++)
                    {
                        sum += A[i, j];
                    }

                }
            }
            Console.WriteLine('\n' + sum + '\n');

            Console.WriteLine("Мин эл: " + min + "\nМакс эл: " + max + '\n');
#endif
#if TASK4
            int m = 3;
            int n = 3;
            int[,] A = new int[m, n];
            int[,] B = new int[m, n];
            int[,] C = new int[m, n];
            int[,] D = new int[m, n];
            Random random = new Random();

            Console.WriteLine("Матрица А");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = random.Next(20);
                    Console.Write("{0,4}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Матрица В");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = random.Next(20);
                    Console.Write("{0,4}", B[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Результат сложения матриц А и В");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write("{0,4}", C[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("Результат умножения матриц А и В");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++) //перебирает элементы выбранной строки матрицы А и выбранного столбца матрицы В
                    {
                        D[i, j] += A[i, k] * B[k, j];

                    }
                    Console.Write("{0,4}", D[i, j]);

                }
                Console.WriteLine();

            }
            Console.WriteLine("Введите число для умножения матрицы: ");
            int number = Int32.Parse(Console.ReadLine());
            int[,] I = new int[m, n];
            Console.WriteLine();
            Console.WriteLine("Результат умноженяия матрицы А на число {0}", number);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    I[i, j] = A[i, j] * number;
                    Console.Write("{0,4}", I[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Результат умноженяия матрицы B на число {0}", number);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    I[i, j] = B[i, j] * number;
                    Console.Write("{0,4}", I[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
#endif
        }
    }
}
