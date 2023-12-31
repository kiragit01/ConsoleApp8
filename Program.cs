﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.CursorVisible = false;
                Console.Title = "Шеленков Кирилл - практикум 10";


                //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.

                Console.Write("Укажите номер дня недели: ");
                byte day = byte.Parse(Console.ReadLine());
                while (day > 7)
                {
                    day -= 7;
                }
                switch (day)
                {
                    case 1: Console.WriteLine("Понедельник"); break;
                    case 2: Console.WriteLine("Вторник"); break;
                    case 3: Console.WriteLine("Среда"); break;
                    case 4: Console.WriteLine("Четверг"); break;
                    case 5: Console.WriteLine("Пятница"); break;
                    case 6: Console.WriteLine("Суббота"); break;
                    case 7: Console.WriteLine("Воскресенье"); break;
                    default: Console.WriteLine("Ошибка, нет такого дня недели"); break;
                }


                //Задача 2. В зависимости от порядкового номера месяца (1, 2, ... , 12) вывести на экран его название (январь, февраль, ... , декабрь).

                Console.Write("Укажите номер месяца: ");
                byte month = byte.Parse(Console.ReadLine());

                while (month > 12)
                {
                    month -= 12;
                }
                switch (month)
                {
                    case 1: Console.WriteLine("Январь"); break;
                    case 2: Console.WriteLine("Февраль"); break;
                    case 3: Console.WriteLine("Март"); break;
                    case 4: Console.WriteLine("Апрель"); break;
                    case 5: Console.WriteLine("Май"); break;
                    case 6: Console.WriteLine("Июнь"); break;
                    case 7: Console.WriteLine("Июль"); break;
                    case 8: Console.WriteLine("Август"); break;
                    case 9: Console.WriteLine("Сентябрь"); break;
                    case 10: Console.WriteLine("Октябрь"); break;
                    case 11: Console.WriteLine("Ноябрь"); break;
                    case 12: Console.WriteLine("Декарбь"); break;
                    default: Console.WriteLine("Ошибка, нет такого номера месяца"); break;
                }


                //Задача 3.По номеру месяца вывести название времени года.

                Console.Write("Укажите номер месяца: ");
                byte season = byte.Parse(Console.ReadLine());

                while (season > 12)
                {
                    season -= 12;
                }
                switch (season)
                {
                    case 1: case 2: case 12: Console.WriteLine("Зима"); break;
                    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
                    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
                    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
                    default: Console.WriteLine("Ошибка, нет такого номера месяца"); break;
                }


                //Задача 4.Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.

                Console.Write("Введите первую букву учебного предмета: ");
                char lessons = char.Parse(Console.ReadLine());
                switch (lessons)
                {
                    case 'ф': case 'Ф': Console.WriteLine("физика"); break;
                    case 'м': case 'М': Console.WriteLine("математика"); break;
                    case 'и': case 'И': Console.WriteLine("история"); break;
                    case 'г': case 'Г': Console.WriteLine("география"); break;
                    case 'б': case 'Б': Console.WriteLine("биология"); break;
                    default: Console.WriteLine("Ошибка, нет такого урока в программе."); break;
                }


                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
        }
    }
}
