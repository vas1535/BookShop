using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#define TASK1
//#define TASK2
//#define TASK3
//#define TASK4
//#define TASK5
//#define TASK6
//#define TASK7

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
#if TASK1
            int number = 0;
            Console.WriteLine("Введите число в диапазоне от 1 до 100: ");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number < 0 || number > 100)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неверные данные! Необходимо ввести число от 1 до 100!");
            }
            if (number > 0 && number < 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                    return;
                }
                if (number % 3 == 0) Console.WriteLine("Fizz");
                if (number % 5 == 0) Console.WriteLine("Buzz");
                if (number % 3 != 0 && number % 5 != 0) Console.WriteLine(number);
            }
#endif
#if TASK2
            int number = 0;
            int percent = 0;

            Console.WriteLine("Введите число: ");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите число для процента: ");
                percent = Int32.Parse(Console.ReadLine());
                int result = number * percent / 100;
                Console.WriteLine("Результат вычисления: {0}", result);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели неверные символы! Введите число");

            }
#endif
#if TASK3
            double num1, num2, num3, num4;
            int result;

            Console.WriteLine("Введите 1 цифру");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 цифру");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 цифру");
            num3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 4 цифру");
            num4 = Double.Parse(Console.ReadLine());

            result = (int)num1 * 1000 + (int)num2 * 100 + (int)num3 * 10 + (int)num4;
            Console.WriteLine("Полученный результат = {0}", result);
#endif
#if TASK4
            int size = 6;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int x1=0, x2=0;
            Console.WriteLine("Введите первый номер разряда: ");
            try
            {
                x1 = Int32.Parse(Console.ReadLine());
                if (x1 < 1 || x1 > 6) throw new Exception();
            }
            catch (Exception) { Console.WriteLine("Неправильно! Введите разряд от 1 от 6!");}
            Console.WriteLine("Введите второй номер разряда: ");
            try
            {
                x2 = Int32.Parse(Console.ReadLine());
                if (x2 < 1 || x2 > 6) throw new Exception();
            }
            catch (Exception) { Console.WriteLine("Неправильно! Введите разряд от 1 от 6!");}

            int buffer2 = arr[x1 - 1];
            arr[x1 - 1] = arr[x2 - 1];
            arr[x2 - 1] = buffer2;
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
#endif
#if TASK5
            int year = 0, month = 0, day = 0;
            Console.WriteLine("Введите год: ");
            year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            try
            {
                month = Int32.Parse(Console.ReadLine());
                if (month < 1 || month > 12) throw new Exception();
            }
            catch (Exception) { Console.WriteLine("Неправильно! Введите корректный номер месяца");}                   
          Console.WriteLine("Введите день: ");
            try
            {
                day = Int32.Parse(Console.ReadLine());
                if (day < 1 || day > 31) throw new Exception();
            }
            catch (Exception) { Console.WriteLine("Неправильно! Такого дня не существует"); }
           
            DateTime dateValue = new DateTime(year, month, day);
            string season = "";
            if (month == 12 || month <= 2) { season = "зима"; }
            if (month >= 3 && month <= 5) { season = "весна"; }
            if (month >= 6 && month <= 8) { season = "лето"; }
            if (month >= 9 && month <= 11) { season = "осень"; }
            Console.WriteLine(dateValue.ToString("dddd") + ", " + season);
#endif
#if TASK6
            Console.WriteLine("Введите температуру: ");
            int t = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите температурную шкалу (F или C): ");
            string str = Console.ReadLine();

            double temp = 0;
            if (str == "F")
            {
                temp = 1.8 * t + 32;
                Console.WriteLine(t + " градусов по Цельсию = {0} градусов по Форенгейту", temp);
            }
            if (str == "C")
            {
                temp = (t - 32) / 1.8;
                Console.WriteLine(t + " градусов по Форенгейту = {0} градусов по Цельсию", temp);
            }
#endif
#if TASK7
            Console.WriteLine("Введите верхнюю границу диапазона: ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите нижнюю границу диапазона: ");
            int x2 = Int32.Parse(Console.ReadLine());
            if (x1 > x2)
            {
                int buffer = x1;
                x1 = x2;
                x2 = buffer;
            }
            Console.WriteLine("Все четные числа в указанном диапазоне: ");
            for (int i = x1; i <= x2; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");              
            }
#endif
        }
    }
}

