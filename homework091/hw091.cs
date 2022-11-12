// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string CountDown(int N)
{
    if(N==1) return "1";
    else return ($"{N}, {CountDown(N-1)}");
}
System.Console.WriteLine("Введите число");
System.Console.WriteLine(CountDown(int.Parse(Console.ReadLine())));