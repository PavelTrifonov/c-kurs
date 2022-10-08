// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
int[] myNewarrey()
{
Console.WriteLine("Введите нечетное количество разрядности числа: ");
int col = int.Parse(Console.ReadLine());
int[] myArr = new int[col];
Console.WriteLine("Введите через enter значение элементов числа: ");
for (int i=0;i< col;i++)
{
    myArr[i] = int.Parse(Console.ReadLine());
}
return myArr;
}
void palindrom()
{
int j=0;
int[] myArr2=myNewarrey();
while (j<myArr2.Length/2)
      {if (myArr2[j]==myArr2[myArr2.Length-1-j] && j<myArr2.Length/2)
         {j++;
         continue;}
     else
     {Console.WriteLine("Число {0} не является палиндромом",String.Join(" ",myArr2));
         break;}
      }   
Console.WriteLine("Число {0} является палиндромом",String.Join(" ",myArr2));
}
 palindrom();
void palindrom2()
{Console.WriteLine("Введите 5 значное число: ");
int numb=int.Parse(Console.ReadLine());
if(numb/1000==((numb%100)/10)+(numb%10)*10)
Console.WriteLine("Число {0} является палиндромом",numb);
else
Console.WriteLine("Число {0} не является палиндромом",numb);
}
// palindrom2();