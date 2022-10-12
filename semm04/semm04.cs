// Дан одномерный массив целых чисел. Найдите, сколько раз в нем повторяется самое частое число.
//Например,  15  23  14  23  17   23   21   14 -> 3
// int[] newarrey()
// {
// Console.WriteLine("Введите количество элементов списка: ");
// int col = int.Parse(Console.ReadLine());
// int[] myArr = new int[col];
// for (int i=0;i< col;i++)
// {
//     myArr[i] =new Random().Next(0,10);
// }
// System.Console.WriteLine(String.Join(",",myArr));

// return myArr;
// }
// int[] newArr=newarrey();
// int max=0;
// int r=1;
// int index=0;
// for(int i=0;i<newArr.Length; i++)
// {  //index=0;
//     r=1;
//     for(int j=0;j<newArr.Length; j++)
//     { 
//         if (newArr[i]==newArr[j] && i!=j)
//     r++;
//     }
// if(r>max)
// {max=r;
// index=newArr[i];}
// }
// System.Console.WriteLine("Cамое частое число повторяется: 
//"+max+", это число: "+index);


//Программа должна создать массив из 12 случайных целых чисел 
//из отрезка [-10;10] таким образом, чтобы отрицательных и положительных 
// элементов там было поровну и не было нулей. При этом порядок следования 
// элементов должен быть случаен (т. е. не подходит вариант, когда в массиве 
// постоянно выпадает сначала 6 положительных, а потом 6 отрицательных чисел 
// или же когда элементы постоянно чередуются через один и пр.). Вывести полученный массив на экран.

void newarrey()
{
  int otr=0;
  int neg=0;
  int pol=0;
  int pos=0;
  int col = 12;
  int[] myArr = new int[col];
 for (int i=0;i< col;i++)
 {int g =new Random().Next(-10,10);
 if(neg<6&&otr<0)
 {myArr[i]=otr;
 pol =new Random().Next(-10,10);
 pos++;
 (pos<6&&pol>0)
 {myArr[i]=pol;
 i=neg+pos;}
 }
 System.Console.WriteLine(String.Join(",",myArr));}

// return myArr;
newarrey();