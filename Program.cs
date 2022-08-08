Console.Clear ();

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Здравствуй друг. Введи 2 числа и я найду мимальное и минимальное");
Console.WriteLine ( );

Console.Write ("Введи первое число (a): ");

int a = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введи второе число (b): ");

int b = Convert.ToInt32 (Console.ReadLine());

int max = Convert.ToInt32 (Math.Max(a, b));
int min = Convert.ToInt32 (Math.Min(a, b));

Console.WriteLine("max: " + max);
Console.WriteLine("min: " + min);

// Еще раз

Console.WriteLine (" ");

Console.WriteLine ("Пожалуйста, введи еще 2 числа, я снова найду минимальное и максималное, но буду использовать другую логику");

Console.WriteLine (" ");

Console.Write ("Введи первое число (c): ");

int c = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введи второе число (d): ");

int d = Convert.ToInt32 (Console.ReadLine());

if (c < d)
    {
        // max = d; min = c;
        Console.WriteLine("max: " + d);
        Console.WriteLine("min: " + c);
    }
else
    {
        // max = d; min = c;
        Console.WriteLine("max: " + c);
        Console.WriteLine("min: " + d);
    }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine (" ");

Console.WriteLine ("А сейчас, введи 3 числа, я и снова найду минимальное и максималное");

Console.WriteLine (" ");

Console.Write ("Введи первое число (e): ");

int e = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введи второе число (f): ");

int f = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введи третье число (g): ");

int g = Convert.ToInt32 (Console.ReadLine());

int maximum = e;

    if (e >= max) maximum = e;
    if (f >= max) maximum = f;
    if (g >= max) maximum = g;

Console.WriteLine("max: " + maximum);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//  4 -> да
// -3 -> нет
//  7 -> нет

Console.WriteLine (" ");

Console.WriteLine ("Потруднее, введи 1 число, я скажу четное оно или нет");

Console.WriteLine (" ");

Console.Write ("Введи число (i): ");

int i = Convert.ToInt32 (Console.ReadLine());

if (i % 2 == 0)
    {
        Console.WriteLine("Четное");
    }
else
    {
        Console.WriteLine("Нечетное");
    }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine (" ");

Console.WriteLine ("Сейчас, введи еще 1 число, я покажу тебе как глубока кроличья нора");

Console.WriteLine (" ");

Console.Write ("Введи число (N): ");

int N = Convert.ToInt32 (Console.ReadLine());

int index = 1;

while (index <= N)
{   
    if (index % 2 == 0)
    { 
        Console.Write (index + " ");
        index = index + 1;
    }
    index = index + 1;
}