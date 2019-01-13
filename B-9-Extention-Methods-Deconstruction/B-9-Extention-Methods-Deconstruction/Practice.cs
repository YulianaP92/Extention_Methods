using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        public static DateTime Date { get; set; }
       static DateTime date = new DateTime();
        public struct Coordinates
        {
            public int a, b, c;
            public void Deconstruct(out int a, out int b, out int c, out int vector)
            {
                a = this.a;
                b = this.b;
                c = this.c;
                vector = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
            }
        }
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
            var coordinate_1 = new Coordinates { a = 1, b = 2, c = 3 };
            var (_, _, _, result) = coordinate_1;
            Console.WriteLine(result);
        }

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {           
            date = DateTime.Now;
            ( _,  _, int hour, int minute, int second) = date;
            Console.WriteLine($"{hour}: {minute}: {second}");
        }

        public static void Deconstruct(this DateTime Date, out int year, out int month, out int hour, out int minute, out int second)
        {
            year = Date.Year;
            month = Date.Month;
            hour = Date.Hour;
            minute = Date.Minute;
            second = Date.Second;
        }
    }
}
