using System;

namespace lab2_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*          
                        Console.WriteLine("Введите зеначение переменных a, b и c для решения квадратного уравнения");
                        double a, b, c, D;
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        c = double.Parse(Console.ReadLine());
                        D = Math.Pow(b, 2) - 4 * a * c;
                        if ( D > 0 )
                        {
                            double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                            double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                            Console.WriteLine("Ответ: первый корень - " + x1 + ", второй корень - " + x2);
                        }
                        else
                        {
                            if ( D<0 )
                            {
                                Console.WriteLine("Дискрминант отрицателен, корней нет");
                            } 
                            else
                            {
                                double x =(-b + Math.Sqrt(D)) / 2 * a;
                                Console.WriteLine("Корни: {x}+yi и {x}-yi");
                            }
                        }*/


            //2
            /* 
             double pi = 0, num = 1;
             Console.WriteLine("Введите количество слагаемых");
             int member = int.Parse(Console.ReadLine());
             for (int i = 0; i <= member; i++)
             {
                 if (i % 2 == 0)
                 {
                     pi -= (1 / num);
                 }
                 else
                 {
                     pi += (1 / num);
                 }
                 num += 2;
             }
             pi = 4 * pi;
             Console.WriteLine("Ответ: " + pi);*/


            //3
            /*Console.WriteLine("Введите число элементов для ряда Фибоначчи");
            int element = int.Parse(Console.ReadLine());
            int num = 0;
            int f0 = 1, f1 = 1;
            for (int i = 0; i < element - 2; i++)
            {
                int f2 = f0 + f1;
                double f_2 = f2;
                if (f_2 >= 1000 && f_2 < 10000)
                {
                    num = num +1;
                }
                f0 = f1;
                f1 = f2;
            }
            Console.WriteLine("Количесво 4х значных чисел:" + num);*/


            //4
            /*double x, q;
            Console.WriteLine("Введите число x и q:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число q:");
            q = int.Parse(Console.ReadLine());
            while (q <= 0)
            {
                Console.WriteLine("q не должно равнятся нулю, введите число больше нуля");
                q = int.Parse(Console.ReadLine());
            }
            double s = x * x;
            int fakt = 2;
            double cos = 1;
            int i = 2;
            int z = 1;
            while (s / fakt >= q)
            {
                cos = cos + z * s / fakt;
                i = i + 2;
                s = s * x * x;
                fakt = fakt * (i - 1) * i;
                z = z * (-1);
            }
            i = i / 2;
            Console.WriteLine("Количество слагаемых = " + i);
            Console.WriteLine("Значение cos(x) = " + cos);*/



            //5
            /*Console.WriteLine("Введите натуральное число N:");
            int N = int.Parse(Console.ReadLine());
            while (N <= 0)
            {
                Console.WriteLine("Введите положительное число!");
                N = int.Parse(Console.ReadLine());
            }
            int i = 0;

            for (double x = 1; x < N; x++)
            {
                double x1 = Math.Pow(x, 3);
                for (double y = 1; y < N; y++)
                {
                    double y1 = Math.Pow(y, 3);
                    for (double z = 1; z < N; z++)
                    {
                        double z1 = Math.Pow(z, 3);
                        double sum = x1 + y1 + z1;
                        if (sum == N)
                        {
                            Console.WriteLine($"{x1}+{y1}+{z1} = {N}");
                            i++;
                            return;
                        }
                    }
                }
            }
            if (i == 0)
            {
                Console.WriteLine("No such combinations!");
            }*/


            //6
            Console.WriteLine("Введите число от 1 до 100");
            int N = int.Parse(Console.ReadLine());
            while (N < 1 || N > 100)
            {
                Console.WriteLine("Отибка ввода. Введите число из промежутка: от 1 до 100");
                N = int.Parse(Console.ReadLine());
            }
            if (N > 4 && N < 21)
            {
                Console.WriteLine($"{N} лет");
            }
            else
            {
                if (N % 10 > 1)
                {
                    Console.WriteLine($"{N} года");
                }
                else
                {
                    Console.WriteLine($"{N} год");
                }
            }

        }
    }
}
