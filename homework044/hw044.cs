/*Дополнительно
Дан список некоторых целых чисел, найдите значение 20 
в нем и, если оно присутствует, замените его на 200. 
Обновите список только при первом вхождении числа 20.
[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20] */
void newElInList()
{
List<int> myList=new List<int>();
System.Console.WriteLine("Задайте размер массива: ");
int num=int.Parse(Console.ReadLine());
for(int i =0;i<num;i++)
myList.Add(new Random().Next(15,25));
System.Console.WriteLine(String.Join(" ",myList));
int j=0;
while(myList[j]!=20)
j++;
myList[j]=200;
System.Console.WriteLine(String.Join(" ",myList));}
newElInList();