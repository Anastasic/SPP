using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AramaAG.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.AramaAG.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Арама А.Г. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: SprintReview                                                      *");
            Console.WriteLine("* Задание #ревью                                                          *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Арама Анастасия Георгиевна | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать метод , который вычисляет выражение(x + y + z) * 5 и возвращает *");
            Console.WriteLine("* целочисленное значение.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y, z;
            Console.WriteLine("* Введите число х");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите число y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите число z");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
