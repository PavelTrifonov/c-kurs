// /*Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины. */
// List<int> treug=new List<int>();
// int num=3;
// for(int i =0;i<num;i++)
// treug.Add(int.Parse(Console.ReadLine()));
// Console.WriteLine(String.Join(" ",treug));
// int max=0;
// int sum=0;
// foreach(int i in treug)
// {if (i>max)
// max=i;}
// Console.WriteLine(max);
// foreach(int i in treug)
// {if (i!=max)
// sum+=i;}
// Console.WriteLine(sum);
// if (sum>max)
// Console.WriteLine("C такими сторонами треугольник может существовать");
// else
// Console.WriteLine("C такими сторонами треугольник не может существовать");

/*Условие
Дано нечетное число n. Создайте двумерный массив из n×n 
элементов, заполнив его символами "." (каждый элемент 
массива является строкой из одного символа). Затем 
заполните символами "*" среднюю строку массива, средний 
столбец массива, главную диагональ и побочную диагональ. 
В результате единицы в массиве должны образовывать 
изображение звездочки. Выведите полученный массив на 
экран, разделяя элементы массива пробелами. */
// System.Console.WriteLine("Задайте размер массива: ");
// int num=int.Parse(Console.ReadLine());
// string [,] Sneg=new string[num,num];
// for(int i=0;i<num;i++)
// {
// for(int j =0;j<num;j++)
// {
// Sneg[i,j]=".";
// System.Console.Write(Sneg[i,j]+" ");
// }
// System.Console.WriteLine("");
// }
// System.Console.WriteLine("\n");
// int x=0;
// for(int i=0;i<num;i++)
// {
// for(int j =0;j<num;j++)
// {if(j==i)
// Sneg[i,j]="*";
// else if(j==num-i-1)
// Sneg[i,j]="*";
// else if(j==num/2)
// Sneg[i,j]="*";
// else if(i==num/2)
// Sneg[i,j]="*";
// System.Console.Write(Sneg[i,j]+" ");
// }
// System.Console.WriteLine("");
// //x++;
//}


/*Условие
Дано число n. Создайте массив размером n×n и заполните его 
по следующему правилу. На главной диагонали должны быть 
записаны числа 0. На двух диагоналях, прилегающих к главной, 
числа 1. На следующих двух диагоналях числа 2, и т.д. */

System.Console.WriteLine("Задайте размер массива: ");
int num=int.Parse(Console.ReadLine());
int [,] Saper=new int[num,num];
for(int i=0;i<num;i++)
 {
 for(int j =0;j<num;j++)
 {
 Saper[i,j]=Math.Abs(j-(i));
System.Console.Write(Saper[i,j]+" ");
 }
 System.Console.WriteLine("");
}
