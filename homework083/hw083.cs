// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] array1 = RandMass();
int[,] array2 = RandMass();

void print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
            System.Console.Write(mass[i, j] + " ");
        System.Console.WriteLine("");

    }
}
print(array1);
System.Console.WriteLine(" * ");
print(array2);
int[,] NewArray()
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            // for (int j = 0; j < newArray.GetLength(1); j++)
            // {
            for (int n = 0; n < array1.GetLength(0); n++)
            {
                int sum = 0;
                for (int m = 0; m < array1.GetLength(1); m++)
                {
                    sum += array1[i, m] * array2[m, n];
                    // System.Console.WriteLine($"{array1[i, m]} и {array2[m, n]}");
                }
                newArray[i, n] = sum;
                // System.Console.WriteLine(newArray[i, n]);
            }
        }
    }
    return newArray;
}
System.Console.WriteLine(" = ");
print(NewArray());