/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число от 1 до 7: ");
int numb = int.Parse(Console.ReadLine());
string[] daysweek = {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"};
if(numb>5)
   Console.WriteLine(daysweek[numb-1]+" this is weekend!!!"); 
else
   Console.WriteLine(daysweek[numb-1]+" this is not weekend!!!");