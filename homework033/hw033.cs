/*  Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран. Элементы 
задаются рандомно. Итоговый массив должен 
содержать в себе суммы цифр числа. Т.е. необходимо 
подсчитывать суммы цифр чисел и записывать их в 
новый массив.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
63, 12, 33, 36 -> [9, 3, 6, 9]*/
int col=8;
int[] myArr = new int[col];
for (int i=0;i< col;i++)
{
    myArr[i] = new Random().Next(0,1000);
}
Console.WriteLine("Старый массив: "+ String.Join(", ",myArr));

for (int i=0;i< myArr.Length;i++)
{int sum=0;
while(myArr[i]!=0)
{ sum= sum + myArr[i]%10;
    myArr[i] = myArr[i]/10;}
  myArr[i]=sum;
}
Console.WriteLine("Новый массив: "+ String.Join(", ",myArr));