/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

System.Console.WriteLine("Введите число: ");
List<int> LenPozNum= new List<int>();
LenPozNum.Add(int.Parse(Console.ReadLine()));
string Char="";
while(Char!="+")
{System.Console.WriteLine("Чтобы посчитать количество положительныч чисел введите + или продолжайте вводить интересующие числа)): ");
Char = Console.ReadLine();
if(Char!="+")
LenPozNum.Add(int.Parse(Char));
}
int sum=0;
foreach(int i in LenPozNum)
{if (i>0)
sum+=i;}
System.Console.WriteLine("Сумма положительных чисел в списке: "+String.Join(" ",LenPozNum)+" -> равна "+sum);

