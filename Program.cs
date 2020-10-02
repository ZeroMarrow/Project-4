using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высокий уровень сложности
            try
            {
                Console.Write("Введите число от 1 до 99 ");
                double x = double.Parse(Console.ReadLine());
                if (x > 99 && x < 0) ;
                if (x == 1) Console.WriteLine(x + "Копейка");
                if (x >= 2 && x <= 4 || x >= 22 && x <= 24 || x >= 32 && x <= 34 || x >= 42 && x <= 44 || x >= 52 && x <= 54 || x >= 62 && x <= 64 || x >= 72 && x <= 74 || x >= 82 && x <= 84 || x >= 92 && x <= 94) Console.WriteLine(x + " Копейки");
                if (x >= 5 && x <= 21 || x >= 25 && x <= 31 || x >= 35 && x <= 41 || x >= 45 && x <= 51 || x >= 55 && x <= 61 || x >= 65 && x <= 71 || x >= 75 && x <= 81 || x >= 85 && x <= 91 || x >= 95 && x <= 99) Console.WriteLine(x + " Копеяк");
                else Console.WriteLine("Только от 1 до 99 ");
            }
            catch (Exception e)
            {

            }
        }
    }
}
