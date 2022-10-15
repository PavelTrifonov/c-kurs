/*Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */
void sumNechNumList()
{
List<int> myList=new List<int>();
System.Console.WriteLine("Задайте размер массива: ");
int num=int.Parse(Console.ReadLine());
for(int i =0;i<num;i++)
myList.Add(new Random().Next(-10,10));
System.Console.WriteLine(String.Join(" ",myList));
int sum=0;
for (int i=0;i<num;i++)
if(i%2==1)
sum+=myList[i];
System.Console.WriteLine("Сумму элементов, стоящих на нечётных позициях: "+sum);
}
sumNechNumList();
