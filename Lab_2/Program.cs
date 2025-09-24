using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2_Lepilkin_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double a = 10;
            //double b = 3;
            //double c = a / b;
            //Console.WriteLine(c);

            //double x = 10 / 3;
            //Console.WriteLine(x);

            //int x1 = 4;
            //int y1 = ++x1;
            //Console.WriteLine($"x1-{x1},y1-{y1}");

            //int x2 = 4;
            //int y2 = x2++; .
            //Console.WriteLine($"x2={x2},y2={y2}");

            //int x = 1;
            //Console.WriteLine((10/5) * 2);

            //bool x1 = (5 > 6) || (4 < 7);
            //bool x2 = (5 > 6) && (4 < 7);

            //double number = 4.4656423;
            //Console.WriteLine($"{number:F2}");
            //Console.WriteLine($"{number:C}");
            //Console.WriteLine($"{number:P}");

            //int number = int.Parse(Console.ReadLine());
            //if (number > 0){
            //Console.WriteLine("Положиетльное");
            // else if(number<0) {
            //Console.WriteLine("");
            // else {Console.WriteLine("число ноль") };

            //int x = 3;
            //int y = 2;
            //int z = (x > y) ? (x + y) : (x - y);

            //Console.WriteLine("Введите вашу игру");
            //string input = Console.ReadLine().ToLower();
            //switch (input) {
            //case "dota2":
            //Console.WriteLine("Ваша игра - dota 2");
            //goto case "minecraft";
            //break;
            //case "minecraft":
            //Console.WriteLine("Ваша Игра - minecraft");
            //break;
            //default:
            //Console.WriteLine("Не найдена");
            //break;

            // задание 1
            //string n = Console.ReadLine();
            //int ni = Convert.ToInt32(n);
            //if (ni % 2 == 0)
            //{
            //    Console.WriteLine("Четное");
            //}
            //else
            //{
            //    Console.WriteLine("Нечетное");
            //}

            // задание 2
            //Console.Write("Введите пароль:");
            //string p1 = Console.ReadLine();
            //Console.Write("Введите еще пароль:");
            //string p2 = Console.ReadLine();
            //if (p1 == p2)
            //{
            //    Console.WriteLine("Пароль принят");
            //}
            //else
            //{
            //    Console.WriteLine("Пароль не принят");
            //}

            // задание 3
            //string chr = Console.ReadLine();
            //int chr1 = Convert.ToInt32(chr);
            //int a1 = ((chr1 / 1000) + (chr1 % 10));
            //int a2 = (((chr1 / 100) % 10) - ((chr1 / 10) % 10));
            //if (a1 == a2)
            //{
            //    Console.WriteLine("Да");
            //}
            //else
            //{
            //    Console.WriteLine("Нет");
            //}

            //задание 4
            //string age = Console.ReadLine();
            //int age1 = Convert.ToInt32(age);
            //if (age1 >= 18)
            //{
            //    Console.WriteLine("Доступ разрешен");
            //}
            //else
            //{
            //    Console.WriteLine("Доступ запрещен");
            //}

            // задание 5
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(a);
            //}

            // задание 6
            //string a = Console.ReadLine();
            //float a1 = float.Parse(a);
            //string b = Console.ReadLine();
            //float b1 = float.Parse(b);
            //string op = Console.ReadLine();

            //if (op == "+")
            //{
            //    Console.WriteLine($"{a1} + {b1} = {a1 + b1}");
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine($"{a1} - {b1} = {a1 - b1}");
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine($"{a1} * {b1} = {a1 * b1}");
            //}
            //else if(op == "/")
            //{
            //    Console.WriteLine($"{a1} / {b1} = {a1 / b1}");
            //}

            // задание 7
            //string dn = Console.ReadLine();
            //switch (dn)
            //{
            //    case "1":
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case "2":
            //        Console.WriteLine("Вторник");
            //        break;
            //    case "3":
            //        Console.WriteLine("Среда");
            //        break;
            //    case "4":
            //        Console.WriteLine("Четверг");
            //        break;
            //    case "5":
            //        Console.WriteLine("Пятница");
            //        break;
            //    case "6":
            //        Console.WriteLine("Суббота");
            //        break;
            //    case "7":
            //        Console.WriteLine("Воскресенье");
            //        break;
            //}

            // задание 8
            //float a = float.Parse(Console.ReadLine());
            //float b = float.Parse(Console.ReadLine());
            //string op = Console.ReadLine();
            //switch (op)
            //{
            //    case "+":
            //        Console.WriteLine($"{a} + {b} = {a + b}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{a} - {b} = {a - b}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{a} * {b} = {a * b}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{a} / {b} = {a / b}");
            //        break;
            //}

            // задание 9
            //Console.WriteLine("Выберите сложность");
            //Console.WriteLine("Легкий - 1");
            //Console.WriteLine("Средний - 2");
            //Console.WriteLine("Сложный - 3");
            //string dif = Console.ReadLine();
            //switch (dif)
            //{
            //    case "1":
            //        Console.WriteLine("Легкий");
            //        Console.WriteLine("Враги слабые");
            //        break;
            //    case "2":
            //        Console.WriteLine("Средний");
            //        Console.WriteLine("Враги сильные");
            //        break;
            //    case "3":
            //        Console.WriteLine("Сложный");
            //        Console.WriteLine("Враги очень сильные");
            //        break;
            //}

            // задание 11
            //string player = Console.ReadLine();
            //switch (player)
            //{
            //    case "Воин":
            //    Console.WriteLine("ближний бой");
            //        break;
            //    case "Маг":
            //    Console.WriteLine("дальный бой");
            //        break;
            //    case "Разбойник":
            //    Console.WriteLine("ближний бой");
            //        break;
            //    case "Паладин":
            //    Console.WriteLine("ближний бой");
            //        break;
            //    case "Варвар":
            //    Console.WriteLine("ближний бой");
            //        break;
            //    case "Охотник":
            //    Console.WriteLine("дальный бой");
            //        break;
            //    case "Друид":
            //    Console.WriteLine("дальный бой");
            //        break;
            //    case "Жрец":
            //    Console.WriteLine("дальный бой");
            //        break;
            //}

            // задание 12
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < 0 && b < 0 && c < 0)
            //{
            //    Console.WriteLine(0); 
            //}
            //else if (a < 0 && b < 0)
            //{
            //    Console.WriteLine(c); 
            //}
            //else if (a < 0 && c < 0)
            //{
            //    Console.WriteLine(b); 
            //}
            //else if (b < 0 && c < 0)
            //{
            //    Console.WriteLine(a); 
            //}
            //else if (a < 0)
            //{
            //    Console.WriteLine(b + c); 
            //}
            //else if (b < 0)
            //{
            //    Console.WriteLine(a + c); 
            //}
            //else if (c < 0)
            //{
            //    Console.WriteLine(a + b); 
            //}
            //else
            //{
            //    Console.WriteLine(a + b + c); 
            //}

            // задание 13
            //Console.Write("Выбери путь А или В: ");
            //string way = Console.ReadLine();
            //if (way == "A")
            //{
            //    Console.WriteLine("Вы наткнулись на дракона и вы должны ответь на зададку");
            //    Console.WriteLine("Дракон говорит : 'Кто не дышит, но живет; хоть не нужно - много пьет; и в жизни, и в смерти тело как лед.'");
            //    Console.Write("Ваш ответ: ");
            //    string answer = Console.ReadLine();
            //    if (answer == "рыба")
            //    {
            //        Console.WriteLine("Правильный ответ, вы прошли дальше");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Вас съел дракон");
            //    }
            //}
            //else if (way == "B") 
            //{
            //    Console.WriteLine("Вы наткнулись на две двери и вам нужно выбрать 1-ую или 2-ую дверь: ");
            //    string door = Console.ReadLine();
            //    if (door == "1")
            //    {
            //        Console.WriteLine("Вы наткнулись на сокровища");
            //    }
            //    else if (door == "2")
            //    {
            //        Console.WriteLine("Вы попали в ловушку с ядовитыми шипами");
            //    }
            //}


        }
        // задание 10
        //static int health = 100; // постоянная (статическая) переменная 'health' персонажа

        //static void Main1(string[] args) // Главный метод программы, точка входа в приложение
        //{
        //    Console.WriteLine($"Здоровье персонажа: {health}"); //вывод текущего здоровья персонажа
        //    TakeDamage(30);// Вызов метода TakeDamage для уменьшения здоровья на 30 единиц
        //}

        //static void TakeDamage(int damage)// Метод для обработки получения урона персонажем
        //{
        //    health -= damage;// Уменьшение здоровья на величину полученного урона
        //    Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}.");// Вывод информации о полученном уроне и текущем уровне здоровья
        //}
    }
}

