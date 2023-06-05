using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start:
            Stats hero = new Stats(0, 100, 100, 100, 0, 0, 0, 100, 100, 100, 100);
            Continue:
            Console.WriteLine("========================================\nТекущее здоровье - " + hero.hp + " ед.\nТекущий опыт - " + hero.exp + " ед.\n" + "Текущие деньги - " + hero.money + "$\n" + "Текущая сытость - " + hero.hungry + " ед.\n" + "Текущая бодрость - " + hero.bodrost + " ед.\n" + "Текущая зарплата: " + hero.zp + "$\n========================================");
            Console.WriteLine("\nВведите номер действия, который хотите сделать:\n\n1. Работать.\n2. Кушать.\n3. Отдыхать.\n4. Купить дом.\n5. Устроиться на работу.\n6. Завершить игру.\n");
            int doing = Convert.ToInt32(Console.ReadLine());
            switch (doing)
            {
                case 1:
                    if (hero.work == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("У вас нет работы!");
                        Console.ReadKey();
                    }
                    else
                    {
                        hero.exp += 5;
                        hero.money += hero.zp;
                        hero.hungry -= 30;
                        hero.bodrost -= 30;
                        Console.Clear();
                        Console.WriteLine("Опыт +5; Деньги + " + hero.zp + "; Сытость - 30; Бодрость - 30");
                    }
                    if (hero.hungry < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Программист упал в обморок от голода и его уволили. Вы проиграли!");
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                    if (hero.money < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Программист упал в обморок от голода и его уволили. Вы проиграли!");
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                    if (hero.hungry < 30) { Console.Clear(); Console.WriteLine("Программист слишком голоден, чтобы дальше работать!"); Console.ReadKey(); }
                    if (hero.bodrost < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Программист уснул на работе и его уволили. Вы проиграли!");
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Выберите пищу: \n\n1. Доширак --- 25$.\n2. Твистер --- 75$.\n3. Сендвич с чиабаттой --- 125$.\n4. Мраморный стейк из говядины --- 200$.\n5. Вернуться назад.");
                    int food = Convert.ToInt32(Console.ReadLine());
                    switch (food)
                    {
                        case 1:
                            Console.Clear();
                            if (hero.money < 24)
                            { Console.WriteLine("Недостаточно средств!"); }
                            else
                            {
                                hero.money -= 25;
                                hero.hungry += 35;
                                hero.hp -= 20;
                                Console.WriteLine("Вы успешно съели 'Доширак'.");
                                Console.WriteLine("Деньги -25$; Сытость +35; Здоровье -20");
                            }
                            break;
                        case 2:
                            Console.Clear();
                            if (hero.money < 74)
                            { Console.WriteLine("Недостаточно средств!"); }
                            else
                            {
                                hero.money -= 75;
                                hero.hungry += 40;
                                hero.hp -= 15;
                                Console.WriteLine("Вы успешно съели 'Твистер'.");
                                Console.WriteLine("Деньги -75$; Сытость +40; Здоровье -15");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            if (hero.money < 124)
                            { Console.WriteLine("Недостаточно средств!"); }
                            else
                            {
                                hero.money -= 125;
                                hero.hungry += 50;
                                hero.hp -= 5;
                                Console.WriteLine("Вы успешно съели 'Сендвич с чиабаттой'.");
                                Console.WriteLine("Деньги -125$; Сытость +50; Здоровье -5");
                            }
                            if (hero.hp < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Программист умер на работе и его уволили. Вы проиграли!");
                                Console.ReadKey();
                                Console.Clear();
                                goto Start;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            if (hero.money < 199)
                            { Console.WriteLine("Недостаточно средств!"); }
                            else
                            {
                                hero.money -= 25;
                                hero.hungry += 65;
                                Console.WriteLine("Вы успешно съели 'Мраморный стейк из говядины'.");
                                Console.WriteLine("Деньги -200; Сытость +65");
                            }
                            break;
                        case 5:
                            Console.Clear();
                            goto Continue;
                        default:
                            Console.Clear();
                            Console.WriteLine("Вы ввели неверное число");
                            break;
                    }
                    if (hero.hungry > hero.maxhungry)
                    {
                        Console.Clear();
                        hero.hungry = hero.maxhungry;
                        Console.WriteLine("У вас максимальное количество сытости!");
                    }
                    break;
                case 3:
                    if (hero.home == 0) { hero.hungry -= 35; hero.bodrost += 30; hero.hp += 5; Console.Clear(); Console.WriteLine("Сытость -35; Бодрость +30; Здоровье +5"); }
                    if (hero.home == 1) { hero.hungry -= 35; hero.bodrost += 35; hero.hp += 10; Console.Clear(); Console.WriteLine("Сытость -35; Бодрость +35; Здоровье +10"); }
                    if (hero.home == 2) { hero.hungry -= 30; hero.bodrost += 40; hero.hp += 15; Console.Clear(); Console.WriteLine("Сытость -30; Бодрость +40; Здоровье +15"); }
                    if (hero.home == 3) { hero.hungry -= 30; hero.bodrost += 45; hero.hp += 20; Console.Clear(); Console.WriteLine("Сытость -30; Бодрость +45; Здоровье +20"); }
                    if (hero.home == 4) { hero.hungry -= 25; hero.bodrost += 50; hero.hp += 25; Console.Clear(); Console.WriteLine("Сытость -25; Бодрость +50; Здоровье +25"); }
                    if (hero.hungry < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Программист упал в обморок от голода и его уволили. Вы проиграли!");
                        Console.ReadKey();
                        Console.Clear();
                        goto Start;
                    }
                    if (hero.bodrost > hero.maxbodrost)
                    {
                        Console.Clear();
                        hero.bodrost = hero.maxbodrost;
                        Console.WriteLine("У вас максимальное количество бодрости!");
                    }
                    if (hero.hp > hero.maxhp)
                    {
                        Console.Clear();
                        hero.hp = hero.maxhp;
                        Console.WriteLine("У вас максимальное количество здоровья!");
                    }
                    if (hero.hungry < 35) { Console.WriteLine("Программист слишком голоден, чтобы дальше отдыхать!"); Console.ReadKey(); }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Выберите дом, который хотите приобрести: \n\n1. Двухкомнатная квартира в Челябинске --- 1000$.\n2. Частный одноэтажный дом в Самаре --- 2500$.\n3. Пятикомнатная квартира в Москва-Сити --- 4500$. \n4. Частный двухэтажный дом в Испании --- 9000$.\n5. Вернуться назад.");
                    int home = Convert.ToInt32(Console.ReadLine());
                    switch (home)
                    {
                        case 1:
                            if (hero.money <= 999)
                            {
                                Console.Clear();
                                Console.WriteLine("Недостаточно средств.");
                            }
                            else
                            {
                                hero.money -= 1000;
                                hero.home = 1;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с покупкой. У вас осталось: " + hero.money + "$.");
                            }
                            break;
                        case 2:
                            if (hero.money <= 2499)
                            {
                                Console.Clear();
                                Console.WriteLine("Недостаточно средств.");
                            }
                            else
                            {
                                hero.money -= 2500;
                                hero.home = 2;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с покупкой. У вас осталось: " + hero.money + "$.");
                            }
                            break;
                        case 3:
                            if (hero.money <= 4499)
                            {
                                Console.Clear();
                                Console.WriteLine("Недостаточно средств.");
                            }
                            else
                            {
                                hero.money -= 4500;
                                hero.home = 3;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с покупкой. У вас осталось: " + hero.money + "$.");
                            }
                            break;
                        case 4:
                            if (hero.money <= 8999)
                            {
                                Console.Clear();
                                Console.WriteLine("Недостаточно средств.");
                            }
                            else
                            {
                                hero.money -= 9000;
                                hero.home = 4;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с покупкой. У вас осталось: " + hero.money + "$.");
                            }
                            break;
                        case 5:
                            Console.Clear();
                            goto Continue;
                        default:
                            Console.Clear();
                            Console.WriteLine("Вы ввели неверное число");
                            break;
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Выберите работу: \n\n1. Магнит --- Заработная плата: 75$.\n2. ТехноПром --- Заработная плата: 225$.\n3. SberTech --- Заработная плата: 450$.\n4. Майкрософт --- Заработная плата: 700$.\n5. Вернуться назад.");
                    int work = Convert.ToInt32(Console.ReadLine());
                    switch (work)
                    {
                        case 1:
                            if (hero.exp <= -1)
                            {
                                Console.Clear();
                                Console.WriteLine("Мало опыта.");
                                Console.ReadKey();
                            }
                            else
                            {
                                hero.work = 1;
                                hero.zp = 75;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с получением новой работы.");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            if (hero.exp <= 34)
                            {
                                Console.Clear();
                                Console.WriteLine("Мало опыта.");
                                Console.ReadKey();
                            }
                            else
                            {
                                hero.work = 2;
                                hero.zp = 225;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с получением новой работы.");
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            if (hero.exp <= 124)
                            {
                                Console.Clear();
                                Console.WriteLine("Мало опыта.");
                                Console.ReadKey();
                            }
                            else
                            {
                                hero.work = 3;
                                hero.zp = 450;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с получением новой работы.");
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            if (hero.exp <= 199)
                            {
                                Console.Clear();
                                Console.WriteLine("Мало опыта.");
                                Console.ReadKey();
                            }
                            else
                            {
                                hero.work = 4;
                                hero.zp = 700;
                                Console.Clear();
                                Console.WriteLine("Поздравляю с получением новой работы.");
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            Console.Clear();
                            goto Continue;
                        default:
                            Console.Clear();
                            Console.WriteLine("Вы ввели неверное число");
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 6:
                    Console.Clear();
                    if (hero.exp >= 300) { Console.Clear(); } else { Console.Clear(); Console.WriteLine("Нехватает опыта."); Console.ReadKey(); goto Continue; }
                    if (hero.money >= 10000) { Console.Clear(); } else { Console.Clear(); Console.WriteLine("Нехватает денег."); Console.ReadKey(); goto Continue; }
                    if (hero.home == 4) { Console.Clear(); } else { Console.Clear(); Console.WriteLine("Нет необходимого дома."); Console.ReadKey(); goto Continue; }
                    Console.WriteLine("Поздравляем вы прошли игру!\n");
                    Console.WriteLine("За игру вы накопили " + hero.exp + " опыта.\nЗа игру вы накопили " + hero.money + "$.\nЗа игру вы смогли купить Частный двухэтажный дом в Испании.");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Вы ввели неверное число");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("");
            goto Continue;
        }
    }
}
