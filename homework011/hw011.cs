/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int numb = new Random().Next(100, 999);
int numb1=0;                            //
int numb2=0;
int numb3=0;                            //
Console.WriteLine(numb);
numb1=numb/100;                         //
numb3=numb%10;                          //
numb2=(numb-(numb1*100+numb3))/10;      //   первый вариант
Console.WriteLine(numb2);
numb2=(numb/10)%10;                      //  второй вариант
Console.WriteLine(numb2);