/*
Напишите программу, которая выводит случайное число из отрезка [10, 9999] 
и показывает наибольшую цифру числа.
*/
int numb = new Random().Next(10, 875);
int max=0;
int s=0;
Console.WriteLine(numb);
while (numb!=0)
{s=numb%10;
if(max<s) 
    max=s;
numb/=10;
Console.WriteLine(numb);
}
Console.WriteLine(max);