/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76  */
void difMaxMin()
{
List<int> myList=new List<int>();
System.Console.WriteLine("Задайте размер массива: ");
int num=int.Parse(Console.ReadLine());
for(int i =0;i<num;i++)
myList.Add(new Random().Next(0,100));
System.Console.WriteLine(String.Join(" ",myList));
int min=100;
int max=0;
foreach (int i in myList)
{if(i>max)
 max=i;
if (i<min)
min=i;}
int r=max-min;
System.Console.WriteLine("Hазницa между максимальным и минимальным элементов массива: "+(max-min));}
difMaxMin();