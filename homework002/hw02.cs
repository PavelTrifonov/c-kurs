/*Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите три целых числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a>b)
    {if (a>c)
       {Console.WriteLine($"max= {a}");
        if (b>c)
            Console.WriteLine($"min= {c}");
        else
            Console.WriteLine($"min= {b}");}
    else
        Console.WriteLine($"max= {c} min= {b}");}
else
    {if (b>c)
        {Console.WriteLine($"max= {b}");
        if (a>c)
            Console.WriteLine($"min= {c}");
        else
            Console.WriteLine($"min= {a}");}
    else
        Console.WriteLine($"max= {c} min= {a}");}