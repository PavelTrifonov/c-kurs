// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] RandMass()
{
    int count = 1;
    System.Console.WriteLine("Введите число строк массива: ");
    int n = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число столбцов массива: ");
    int m = int.Parse(Console.ReadLine());
    int[,] mass = new int[n, m];
    int i = 0;
    int j = 0;
    int numb = n * m;
    int k = 0;
    while (count < numb+1)
    {
        if (j < m && mass[i, j] == 0)
        {
            while (j < m && mass[i, j] == 0)
            {
                mass[i, j] = count;
                count++;
                j++;
            }
            j--;
            i++;
        }
        if (i < n && mass[i, j] == 0)
        {
            while (i < m && mass[i, j] == 0)
            {
                mass[i, j] = count;
                count++;
                i++;
            }
            i--;
            j--;
        }
        if (j > 0 && mass[i, j] == 0)
        {
            while (j > -1 && mass[i, j] == 0)
            {
                mass[i, j] = count;
                count++;
                j--;
            }
            j++;
            i--;
        }
        if (i > 0 && mass[i, j] == 0)
        {
            while (i > 0 && mass[i, j] == 0)
            {
                mass[i, j] = count;
                count++;
                i--;
            }
            i++;
            j++;
            continue;
        }
    }

    return mass;
}
void print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] < 10)
                System.Console.Write($"0{mass[i, j]}" + " ");
            else
                System.Console.Write($"{mass[i, j]}" + " ");
        }
        System.Console.WriteLine("");

    }
}
print(RandMass());