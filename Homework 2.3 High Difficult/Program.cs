using System;

namespace Homework_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите кол-во минут в будние дни:");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите кол-во минут в выходные дни:");
                double y = double.Parse(Console.ReadLine());
                double s1 = (0.50 * x) + (0.50 * y - (0.50 * y * 0.1));
                double s2 = (0.45 * x) + (0.45 * y - (0.45 * y * 0.08));
                double s3 = (0.55 * x) + (0.55 * y - (0.55 * y * 0.12));
                Console.WriteLine($"У первого оператора:{s1:F2} руб.");
                Console.WriteLine($"У второго оператора:{s2:F2} руб.");
                Console.WriteLine($"У третьего оператора:{s3:F2} руб.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
