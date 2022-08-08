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

Console.WriteLine ( );

Console.WriteLine ("Пожалуйста, введи еще 2 числа, я снова найду минимальное и максималное, но буду использовать другую логику");

Console.WriteLine (" ");

Console.Write ("Введи первое число (c): ");

int c = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введи второе число (d): ");

int d = Convert.ToInt32 (Console.ReadLine());

    if (c < d)
        {
        max = d; min = c;
        Console.WriteLine("max: " + d);
        Console.WriteLine("min: " + c);
        }
    else
        {
        max = d; min = c;
        Console.WriteLine("max: " + c);
        Console.WriteLine("min: " + d);
        }

