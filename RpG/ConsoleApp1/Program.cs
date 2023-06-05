using System;
using System.Collections.Generic;

namespace DemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>() {"Борис","Александр","Коди","Сейдоу","Олег","Арам","Биба","Шлёпа","Генадий","Гигачат","Рикардо","Джо","Владимир","Акаме","Вин Дизель","Иисус","Светлана","Наташа","Саша Белый","Моисей","Ибрагим", "Ашот", "Цинь", "Аянами Рей", "Чингисхан", "Карл", "Адам", "Кэнсин", "Томас", "Вэш", "Йо", "Ашока", "Тосиро Хцугая", "Жан", "Юлий", "Иосиф", "Тихиро", "Мани", "Лелуш", "Гатс", "Пётр", "Генри", "Стив", "Лансер", "Гуччио", "Алукард", "Ливай", "Энцо", "Билл", "Кристиан", "Марсель", "Росс", "Пабло", "Бенджамин", "Кишо Арима" };
            Random rnd = new Random();
            Player p1 = new Player(rnd.Next(10, 20), rnd.Next(2, 5), name[rnd.Next(0,57)]);
            Player p2 = new Player(rnd.Next(10, 20), rnd.Next(2, 5), name[rnd.Next(0, 57)]);
            Console.WriteLine($"{p1.Info()} vs {p2.Info()}");

            while (true)
            {
                p1.Hit(p2);
                if (p2.IsLose())
                {
                    Console.WriteLine($"Игрок 2 {p2.Infoname()} проиграл");
                    break;
                }
                Console.WriteLine();
                p2.Hit(p1);
                if (p1.IsLose())
                {
                    Console.WriteLine($"Игрок 1 {p1.Infoname()} проиграл");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}