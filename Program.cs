using System;

class Program
{
    static void Main()
    {
        main0();
    }
    static void MainP()
    {
        Console.WriteLine("Выберите задание которое хотите проверить (от 1 до 22): ");
        Console.WriteLine("Введите exit если хотите выйти из программы");
        Console.WriteLine("1 - Задание 2.1 Напишите программу, которая выводит на экран ваше имя и город.");
        Console.WriteLine("2 - Задание 2.2 Напишите программу, которая выводит небольшое стихотворение (3–4 строки) построчно, используя несколько вызовов Console.WriteLine.");
        Console.WriteLine("3 - Задание 3.1 Объявите переменные для хранения: вашего имени, возраста, роста и того, работаете ли вы (bool). Выведите все значения на экран.");
        Console.WriteLine("4 - Задание 3.2 Объявите две переменные типа int, найдите их сумму, разность и произведение. Выведите результаты.");
        Console.WriteLine("5 - Задание 4.1 Спросите у пользователя два числа и выведите их сумму.");
        Console.WriteLine("6 - Задание 4.2 Спросите у пользователя название товара и его цену, выведите фразу вида: «Товар \"Хлеб\" стоит 45.5 рублей».");
        Console.WriteLine("7 - Задание 5.1 Напишите программу, которая определяет, является ли введённое число чётным(используйте %).");
        Console.WriteLine("8 - Задание 5.2 Напишите программу, которая переводит температуру из Цельсия в Фаренгейт по формуле: F = C * 9 / 5 + 32.");
        Console.WriteLine("9 - Задание 6.1 Спросите у пользователя число и определите, положительное оно, отрицательное или равно нулю.");
        Console.WriteLine("10 - Задание 6.2 Напишите программу «оценка по баллам»: пользователь вводит число баллов(0–100), программа выводит буквенную оценку(A, B, C, D, F) по любой логике на ваш выбор.");
        Console.WriteLine("11 - Задание 6.3 С помощью switch напишите программу, которая по номеру месяца(1–12) выводит название времени года.");
        Console.WriteLine("12 - Задание 7.1 Выведите на экран числа от 1 до 20 с помощью for.");
        Console.WriteLine("13 - Задание 7.2 Найдите сумму всех чисел от 1 до 100, используя цикл while.");
        Console.WriteLine("14 - Задание 7.3 Напишите программу с использованием do -while, которая просит пользователя вводить числа, пока он не введёт 0.После этого выведите сумму всех введённых чисел.");
        Console.WriteLine("15 - Задание 7.4 Выведите таблицу умножения для числа, введённого пользователем(от 1 до 10).");
        Console.WriteLine("16 - Задание 8.1 Создайте массив из 5 чисел, введённых пользователем, и выведите их сумму и среднее значение.");
        Console.WriteLine("17 - Задание 8.2 Найдите максимальное и минимальное число в массиве.");
        Console.WriteLine("18 - Задание 8.3 Создайте массив строк с именами нескольких друзей и выведите их с помощью foreach.");
        Console.WriteLine("19 - Задание 9.1 Напишите метод IsEven(int number), который возвращает true, если число чётное.");
        Console.WriteLine("20 - Задание 9.2 Напишите метод Factorial(int n), вычисляющий факториал числа.");
        Console.WriteLine("21 - Задание 9.3 Напишите метод Max(int a, int b, int c), возвращающий наибольшее из трёх чисел.");
        Console.WriteLine("22 - Задание 10 Итоговое задание Напишите консольную программу «Мини - калькулятор»");
        Console.WriteLine("Введите цифру задания которое хотите проверить: ");
    }
    static void main0()
    {
        while (true)
        {
            Console.WriteLine("Выберите задание которое хотите проверить (от 1 до 22 или введите ? для просмотра списка заданий): ");
            Console.WriteLine("Введите exit если хотите выйти из программы");
            Console.WriteLine("Введите цифру задания которое хотите проверить: ");
            string f = Console.ReadLine() ?? "";
            if (f == "1")
            {
                main21();//Задание 2.1 Напишите программу, которая выводит на экран ваше имя и город.
            }
            else if (f == "2")
            {
                main22();//Задание 2.2 Напишите программу, которая выводит небольшое стихотворение (3–4 строки) построчно, используя несколько вызовов Console.WriteLine.
            }
            else if (f == "3")
            {
                main31();//Задание 3.1 Объявите переменные для хранения: вашего имени, возраста, роста и того, работаете ли вы (bool). Выведите все значения на экран.
            }
            else if (f == "4")
            {
                main32();//Задание 3.2 Объявите две переменные типа int, найдите их сумму, разность и произведение. Выведите результаты.
            }
            else if (f == "5")
            {
                main41();//Задание 4.1 Спросите у пользователя два числа и выведите их сумму.
            }
            else if (f == "6")
            {
                main42();//Задание 4.2 Спросите у пользователя название товара и его цену, выведите фразу вида: «Товар "Хлеб" стоит 45.5 рублей».
            }
            else if (f == "7")
            {
                main51();//Задание 5.1 Напишите программу, которая определяет, является ли введённое число чётным(используйте %).
            }
            else if (f == "8")
            {
                main52();//Задание 5.2 Напишите программу, которая переводит температуру из Цельсия в Фаренгейт по формуле: F = C * 9 / 5 + 32.
            }
            else if (f == "9")
            {
                main61();//Задание 6.1 Спросите у пользователя число и определите, положительное оно, отрицательное или равно нулю.
            }
            else if (f == "10")
            {
                main62();//Задание 6.2 Напишите программу «оценка по баллам»: пользователь вводит число баллов(0–100), программа выводит буквенную оценку(A, B, C, D, F) по любой логике на ваш выбор.
            }
            else if (f == "11")
            {
                main63();//Задание 6.3 С помощью switch напишите программу, которая по номеру месяца(1–12) выводит название времени года.
            }
            else if (f == "12")
            {
                main71();//Задание 7.1 Выведите на экран числа от 1 до 20 с помощью for.
            }
            else if (f == "13")
            {
                main72();//Задание 7.2 Найдите сумму всех чисел от 1 до 100, используя цикл while.
            }
            else if (f == "14")
            {
                main73();//Задание 7.3 Напишите программу с использованием do -while, которая просит пользователя вводить числа, пока он не введёт 0.После этого выведите сумму всех введённых чисел.
            }
            else if (f == "15")
            {
                main74();//Задание 7.4 Выведите таблицу умножения для числа, введённого пользователем(от 1 до 10).
            }
            else if (f == "16")
            {
                main81();//Задание 8.1 Создайте массив из 5 чисел, введённых пользователем, и выведите их сумму и среднее значение.
            }
            else if (f == "17")
            {
                main82();//Задание 8.2 Найдите максимальное и минимальное число в массиве.
            }
            else if (f == "18")
            {
                main83();//Задание 8.3 Создайте массив строк с именами нескольких друзей и выведите их с помощью foreach.
            }
            else if (f == "19")
            {
                main91();//Задание 9.1 Напишите метод IsEven(int number), который возвращает true, если число чётное.
            }
            else if (f == "20")
            {
                main92();//Задание 9.2 Напишите метод Factorial(int n), вычисляющий факториал числа.
            }
            else if (f == "21")
            {
                main93();//Задание 9.3 Напишите метод Max(int a, int b, int c), возвращающий наибольшее из трёх чисел.
            }
            else if (f == "22")
            {
                main10();//Задание 10 Итоговое задание Напишите консольную программу «Мини - калькулятор»:
            }
            else if (f == "?")
            {
                MainP();
            }
            else if (f == "exit")
            {
                Console.WriteLine("Выход из программы...");
                return;
            }
            else
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Повторите ввод");
            }
        }
    }

    static void main21()
    {
        Console.WriteLine("Напишите программу, которая выводит на экран ваше имя и город.");
        Console.WriteLine("Город: Москва, имя: Тигран");
        return;
    }
    static void main22()
    {
        Console.WriteLine("Напишите программу, которая выводит небольшое стихотворение (3–4 строки) построчно, используя несколько вызовов Console.WriteLine.");
        Console.WriteLine($"Вечер падает на город,");
        Console.WriteLine($"Тихо гаснут фонари,");
        Console.WriteLine($"Мир заснул, заботы скорый");
        Console.WriteLine($"Бег утих до утренней зари.");
        return;
    }
    static void main31()
    {
        Console.WriteLine("Объявите переменные для хранения: вашего имени, возраста, роста и того, работаете ли вы (bool). Выведите все значения на экран.");
        string name = "Тигран";
        int age = 17;
        double height = 175d;
        bool work = true;
        Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} Работает?: {work} (наверное)");
        return;
    }
    static void main32()
    {
        Console.WriteLine("Объявите две переменные типа int, найдите их сумму, разность и произведение. Выведите результаты.");
        int a = 5;
        int b = 4;
        Console.WriteLine($"Сумма: {a + b}, Разность: {a - b}, Произведение: {a / b}.");
        return;
    }
    static void main41()
    {
        Console.WriteLine("Спросите у пользователя два числа и выведите их сумму.");
        while (true)
        {
            Console.WriteLine("Введите два числа");
            double a, b;
            Console.Write("Введите первое число: ");
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out b))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            Console.WriteLine($"Сумма двух чисел: {a + b}");
            return;
        }
    }
    static void main42()
    {
        Console.WriteLine("Спросите у пользователя название товара и его цену, выведите фразу вида: «Товар \"Хлеб\" стоит 45.5 рублей».");
        while (true)
        {
            Console.WriteLine("Введите цену и название товара");
            double a;
            Console.Write("Введите цену товара: ");
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            Console.Write("Введите название товара: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine($"Товар \"{name}\" стоит {a} рублей");
            return;
        }
    }
    static void main51()
    {
        Console.WriteLine("Напишите программу, которая определяет, является ли введённое число чётным (используйте %).");
        while (true)
        {
            Console.WriteLine("Введите число");
            double a;
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            if (a % 2 == 0) { Console.WriteLine($"Число {a} четное"); }
            else { Console.WriteLine($"Число {a} не четное"); }
            return;
        }
    }
    static void main52()
    {
        Console.WriteLine("Напишите программу, которая переводит температуру из Цельсия в Фаренгейт по формуле: F = C * 9 / 5 + 32.");
        while (true)
        {
            Console.Write("Введите температуру по шкале Цельсия: ");
            double C, F;
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out C))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            F = C * 9 / 5 + 32;
            Console.WriteLine($"Температура по фаренгейту: {F}");
            return;
        }
    }
    static void main61()
    {
        Console.WriteLine("Спросите у пользователя число и определите, положительное оно, отрицательное или равно нулю.");
        while (true)
        {
            double a;
            Console.Write("Введите число: ");
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            if (a > 0) { Console.WriteLine($"Число положительное"); }
            else if (a < 0) { Console.WriteLine($"Число отрицательное"); }
            else { Console.WriteLine($"Число равно нолю"); }
            return;
        }
    }
    static void main62()
    {
        Console.WriteLine("Напишите программу «оценка по баллам»: пользователь вводит число баллов (0–100), программа выводит буквенную оценку (A, B, C, D, F) по любой логике на ваш выбор.");
        while (true)
        {
            double a;
            char b='F';
            Console.Write("Введите число (от 0 до 100): ");
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            if (a<0 ||a>100)
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            if (a < 30)
            {
                b = 'F';
            }
            if (a >= 30)
            {
                b = 'D';
            }
            if (30 < a && a <= 50)
            {
                b = 'C';
            }
            if (50 < a && a <= 85)
            {
                b = 'B';
            }
            if (a > 85)
            {
                b = 'A';

            }
            Console.WriteLine($"Оценка: {b}");
            return;
        }
    }
    static void main63()
    {
        Console.WriteLine("С помощью `switch` напишите программу, которая по номеру месяца (1–12) выводит название времени года.");
        while (true)
        {
            uint a;
            Console.Write("Введите номер месяца (0-12): ");
            string input = Console.ReadLine() ?? "";
            if (!uint.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            if (a>12)
            {
                Console.WriteLine("Не более 12, перезапуск");
                continue;
            }
            switch (a)
            {
                case 1: Console.WriteLine("Зима"); break;
                case 2: Console.WriteLine("Зима"); break;
                case 3: Console.WriteLine("Весна"); break;
                case 4: Console.WriteLine("Весна"); break;
                case 5: Console.WriteLine("Весна"); break;
                case 6: Console.WriteLine("Лето"); break;
                case 7: Console.WriteLine("Лето"); break;
                case 8: Console.WriteLine("Лето"); break;
                case 9: Console.WriteLine("Осень"); break;
                case 10: Console.WriteLine("Осень"); break;
                case 11: Console.WriteLine("Осень"); break;
                case 12: Console.WriteLine("Зима"); break;
            }
            return;
        }
    }
    static void main71()
    {
        Console.WriteLine("Выведите на экран числа от 1 до 20 с помощью `for`.");
       for(int i = 1; i <= 20; i++)
       {
            Console.WriteLine($"{i}");
       }
    return;
    }
    static void main72()
    {
        Console.WriteLine("Найдите сумму всех чисел от 1 до 100, используя цикл `while`.");
        int i = 0, sum = 0;
        while(i<=100)
        {
            sum += i;
            i++;
        }
        Console.WriteLine($"Сумма: {sum}");
        return;
    }
    static void main73()
    {
        Console.WriteLine("Напишите программу с использованием `do-while`, которая просит пользователя вводить числа, пока он не введёт 0. После этого выведите сумму всех введённых чисел.");
        double sum = 0,a;
        string input;
        do
        {
            while (true)
            {
                Console.Write("Введите число: ");
                input = Console.ReadLine() ?? "";
                if (!double.TryParse(input, out a))
                {
                    Console.WriteLine("Ошибка ввода, перезапуск");
                    continue;
                }
                break;
            }
            sum += a;

        } while (a != 0);
        Console.WriteLine($"Сумма всех чисел: {sum}");
        return;
    }
    static void main74()
    {
        Console.WriteLine("Выведите таблицу умножения для числа, введённого пользователем (от 1 до 10).");
        double a, c;
        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            break;
        }
        for (int i = 1; i <= 10; i++)
        {
            c = a * i;
            Console.WriteLine($"{a} * {i} = {c}");
        }
        return;
    }
    static void main81()
    {
        Console.WriteLine("Создайте массив из 5 чисел, введённых пользователем, и выведите их сумму и среднее значение.");
        double sum=0, sr;
        int[] numbers = { 57, 49, 79, 13, 28 };
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        sr = sum / numbers.Length;
        Console.WriteLine($"Сумма чисел массива: {sum}");
        Console.WriteLine($"Среднее значение чисел массива: {sr}");
        return;
    }
    static void main82()
    {
        Console.WriteLine("Найдите максимальное и минимальное число в массиве.");
        int[] numbers = { 57, 49, 79, 13, 28 };
        double min = numbers[0], max = numbers[0];

        foreach (int number in numbers)
        {
            if (min > number) min = number;
            if (max < number) max = number;
        }
        Console.WriteLine($"Максимальное число массива: {max}");
        Console.WriteLine($"Минимальное число массива: {min}");
        return;
    }
    static void main83()
    {
        Console.WriteLine("Создайте массив строк с именами нескольких друзей и выведите их с помощью `foreach`.");
        string[] friends = { "Танос","Закир","Ктулху","Азиз","Далер","Евгений" };
        foreach (string friend in friends)
        {
            Console.WriteLine($"Друг: {friend}");
        }
        return;
    }
    static void main91()
    {
        Console.WriteLine("Напишите метод `IsEven(int number)`, который возвращает `true`, если число чётное.");
        static void IsEven(int number)
        {

            if (number % 2 == 0) { Console.WriteLine($"Число четное (True)"); }
            else { Console.WriteLine($"Число не четное (false)"); }
        }

        int number;
        while (true)
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            break;
        }
        IsEven(number);
    }
    static void main92()
    {
        Console.WriteLine("Напишите метод Factorial(int n), вычисляющий факториал числа.");
        static void Factorial(int number)
        {
            int f = 1;
        for(int i = 1; i <= number; i++)
            {
                f *= i;
            }
            Console.WriteLine($"Факториал числа {number} равен: {f}");
        }

        int number;
        while (true)
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            break;
        }
        Factorial(number);
    }
    static void main93()
    {
        Console.WriteLine("Напишите метод Max(int a, int b, int c), возвращающий наибольшее из трёх чисел.");
        static int Max(int a, int b, int c)
        {
            int Max = 0;
            if (Max < a) Max = a;
            if (Max < b) Max = b;
            if (Max < c) Max = c;
            Console.WriteLine($"Наибольшее: {Max}");
            return Max;
        }

        int a, b, c;
        while (true)
        {
            Console.WriteLine("Введите число A");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.WriteLine("Введите число B");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out b))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.WriteLine("Введите число C");
            string input = Console.ReadLine() ?? "";
            if (!int.TryParse(input, out c))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            break;
        }
        Max(a, b, c);
    }
    static void main10()
    {
        Console.WriteLine("Напишите консольную программу «Мини-калькулятор»");
        double a, b, c;
        char z;
        while (true)
        {
            Console.WriteLine("Введите число A");
            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            Console.WriteLine("Введите число B");
            input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out b))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            Console.WriteLine("Введите знак (+,-,*,/)");
            input = Console.ReadLine() ?? "";
            if (!char.TryParse(input, out z) || (z != '+' && z != '-' && z != '*' && z != '/'))
            {
                Console.WriteLine("Ошибка ввода, перезапуск");
                continue;
            }
            switch (z)
            {
                case '+': c = a + b; Console.WriteLine($"{a} {z} {b} = {c}"); break;
                case '-': c = a - b; Console.WriteLine($"{a} {z} {b} = {c}"); break;
                case '*': c = a * b; Console.WriteLine($"{a} {z} {b} = {c}"); break;
                case '/':
                if (a == 0 || b == 0) { Console.WriteLine("На ноль делить нельзя, перезапуск"); continue; }
                    c = a / b;
                    Console.WriteLine($"{a} {z} {b} = {c}"); break;
            }
            return;
        }
    }
}