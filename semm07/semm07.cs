/*Условие
Дан двумерный массив и два числа: i и j. Поменяйте в массиве 
столбцы с номерами i и j и выведите результат.

Программа получает на вход размеры массива n и m, затем 
элементы массива, затем числа i и j.

Решение оформите в виде функции swap_columns(a, i, j)*/
int[,] RandMass()
{
System.Console.WriteLine("Введите число строк массива: ");
int n=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов массива: ");
int m=int.Parse(Console.ReadLine());
int[,] mass=new int[n,m];
for(int i =0;i<mass.GetLength(0);i++)
for(int j =0;j<mass.GetLength(1);j++)
mass[i,j]=new Random().Next(0,10);
return mass;
}
int[,] SwapColumns(int[,] NewMass,int a,int b)
{
    int c=0;
for(int i =0;i<NewMass.GetLength(0);i++)
{
for(int j =0;j<NewMass.GetLength(1);j++)
if(j==a)
{
c=NewMass[i,a];
NewMass[i,a]=NewMass[i,b];
NewMass[i,b]=c;
}
}
return NewMass;
}
int[,] a=RandMass();
SwapColumns(a,1,4);
void print(int [,] mass)
{
for (int i = 0; i <mass.GetLength(0); i++)
    {
        for (int j = 0; j <mass.GetLength(1); j++)
            System.Console.Write(mass[i,j] + " ");
        System.Console.WriteLine("");

    } 
}
print(a);
System.Console.WriteLine("");
print(SwapColumns(a,1,4));