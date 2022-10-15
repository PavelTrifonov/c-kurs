/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных 
чисел в массиве.
[345, 897, 568, 234] -> 2 */
void chetNumInList()
{
List<int> myList=new List<int>();
System.Console.WriteLine("Задайте размер массива: ");
int num=int.Parse(Console.ReadLine());
for(int i =0;i<num;i++)
myList.Add(new Random().Next(100,999));
System.Console.WriteLine(String.Join(" ",myList));
int col=0;
foreach(int i in myList)
if (i%2==0)
col++;
System.Console.WriteLine("Kоличество чётных чисел в массиве: "+col);
}
chetNumInList();
