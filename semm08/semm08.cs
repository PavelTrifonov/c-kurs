// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.
// int[,] RandMass()
// {
// System.Console.WriteLine("Введите число строк массива: ");
// int n=int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов массива: ");
// int m=int.Parse(Console.ReadLine());
// int[,] mass=new int[n,m];
// for(int i =0;i<mass.GetLength(0);i++)
// for(int j =0;j<mass.GetLength(1);j++)
// mass[i,j]=new Random().Next(0,10);
// return mass;
// }
// int[,] SwapMass(int[,] NewMass)
// {
//     int[,] Swapmass=new int[NewMass.GetLength(1),NewMass.GetLength(0)];
//     for (int i =0;i<NewMass.GetLength(1);i++)
//         for (int j = 0; j < NewMass.GetLength(0); j++)
//         {
//            Swapmass[i,j] =NewMass[j,i];
//         }
//  return  Swapmass;
// }
int[,] a=RandMass();
// SwapMass(a);
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
// print(SwapMass(a));

// задача 2
int[,] RandMass()
{
    System.Console.WriteLine("Введите число строк массива: ");
    int n = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число столбцов массива: ");
    int m = int.Parse(Console.ReadLine());
    int[,] mass = new int[n, m];
    for (int i = 0; i < mass.GetLength(0); i++)
        for (int j = 0; j < mass.GetLength(1); j++)
            mass[i, j] = new Random().Next(0, 10);
    return mass;
}
void LenNunbMass(int[,] NewMass)
{
    int count = 1;
    List<int> NumbMass = new List<int>();
    for (int i = 0; i < NewMass.GetLength(0); i++)
    {
        for (int j = 0; j < NewMass.GetLength(1); j++)
        {
            if (!NumbMass.Contains(NewMass[i, j]))
                NumbMass.Add(NewMass[i, j]);
        }
    }
foreach (int elem in NumbMass)
{
    count=0;
    for (int i = 0; i < NewMass.GetLength(0); i++)
    {
    for (int j = 0; j < NewMass.GetLength(1); j++)
        {
            if (NewMass[i, j]==elem)
                count++;
        }
    }
    System.Console.WriteLine($"Значение{elem} встречается {count} раз");
}
}
LenNunbMass(a);