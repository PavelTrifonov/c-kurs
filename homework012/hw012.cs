/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
string numb = Console.ReadLine();
int lennumb=numb.Length;
//Console.WriteLine(numb);
//Console.WriteLine(lennumb);
if(lennumb>=3)
   Console.WriteLine(numb[2]); 
else
   Console.WriteLine("третьей цифры нет");