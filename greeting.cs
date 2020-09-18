using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}, в каком году вы родились?");; //обработка года
            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 1870)
                Console.WriteLine($"Вам больше {DateTime.Now.Year - year} лет.");
            else
                Console.WriteLine("В каком по счету месяце вы родились?");
            
            int month = Convert.ToInt32(Console.ReadLine()); //обработка месяца
            if (month == 0)
                Console.WriteLine("Такого месяца не существует.");
            else if (month > 13)
                Console.WriteLine("Такого месяца не существует.");
            else
                Console.WriteLine("В какой день вы родились?");
            
            int day = Convert.ToInt32(Console.ReadLine()); //обработка дня
            if (day == 0)
                Console.WriteLine("Такого дня не существует.");
            else if (day > 31)
                Console.WriteLine("Такого дня не существует.");
            else if ((day == 31) && ((month == 4) || (month == 6) || (month == 9) || (month == 11)))
                Console.WriteLine("Такого дня не существует.");
            else if ((day == 29) && (month == 2) && !(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)))
                Console.WriteLine("Такого дня не существует.");
            else if ((day > 29) && (month == 2))
                Console.WriteLine("Такого дня не существует.");
            else
            {
                long youryear = DateTime.Now.Year - year; //обработка даты
                long yourmonth = DateTime.Now.Month - month;
                if (yourmonth < 0)
                    youryear = youryear - 1;
                long yourday = DateTime.Now.Day - day;
                if (yourday < 0)
                    yourmonth = yourmonth - 1;

                if ((youryear % 10 == 1) && (youryear != 11))
                    Console.WriteLine($"Привет, {name}. Ваш возраст равен {youryear} год. Приятно познакомиться.");
                else if (((youryear % 10 < 5) && (youryear % 10 > 1)) && (youryear != 12) && (youryear != 13) && (youryear != 14))
                    Console.WriteLine($"Привет, {name}. Ваш возраст равен {youryear} года. Приятно познакомиться.");
                else
                    Console.WriteLine($"Привет, {name}. Ваш возраст равен {youryear} лет. Приятно познакомиться.");
            }
         
        }
    }
}
