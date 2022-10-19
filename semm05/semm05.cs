/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие 
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Задача 33: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
// List<int> myList=new List<int>();
// for(int i =0;i<5;i++)
// myList.Add(new Random().Next(-10,10));
// System.Console.WriteLine(String.Join(", ",myList));
// for(int i =0;i<5;i++)
// myList[i]=myList[i]*(-1);
// System.Console.WriteLine(String.Join(", ",myList));
// List<int> myList=new List<int>();
//  for(int i =0;i<5;i++)
//  myList.Add(new Random().Next(-10,10));
//  System.Console.WriteLine(String.Join(", ",myList));
//  int num=int.Parse(Console.ReadLine());
//  int col=0;
//  foreach(int i in myList)
//  {
//  if(num==i)
//  col++;
//  }
//  if (col>0)
//  System.Console.WriteLine("yes");
//  else
//  System.Console.WriteLine("no");
/*Условие
N кеглей выставили в один ряд, занумеровав их слева 
направо числами от 1 до N. Затем по этому ряду 
бросили K шаров, при этом i-й шар сбил все кегли 
с номерами от li до ri включительно. Определите, 
какие кегли остались стоять на месте.
Программа получает на вход количество кеглей N и 
количество бросков K. Далее идет K пар чисел li, 
ri, при этом 1≤ li≤ ri≤ N.

Программа должна вывести последовательность из N 
символов, где j-й символ есть “I”, если j-я кегля 
осталась стоять, или “.”, если j-я кегля была сбита.*/
List<string> myList=new List<string>();
System.Console.WriteLine("Введите число кеглей: ");
int num=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число бросков: ");
int K=int.Parse(Console.ReadLine());
for(int i =0;i<num;i++)
myList.Add("|");
System.Console.WriteLine(String.Join(" ",myList));
for(int i =0;i<K;i++)
{
System.Console.WriteLine("С какой кегли сбито: ");
int left=int.Parse(Console.ReadLine());
System.Console.WriteLine("По какую кеглю сбито: ");
int right=int.Parse(Console.ReadLine());
while(left!=right+1)
{myList[left-1]=".";
left++;
}
}
System.Console.WriteLine(String.Join(" ",myList));