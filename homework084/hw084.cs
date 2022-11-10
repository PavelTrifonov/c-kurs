// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] Rand3DMass()
{
    System.Console.WriteLine("Введите число х-элементов массива: ");
    int x = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число у-элементов массива: ");
    int y = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число z-элементов массива: ");
    int z = int.Parse(Console.ReadLine());
    int[,,] mass = new int[x, y, z];
    for (int i = 0; i < mass.GetLength(0); i++)
        for (int j = 0; j < mass.GetLength(1); j++)
            for (int k = 0; k < mass.GetLength(2); k++)
                mass[i, j, k] = new Random().Next(10, 100);
    return mass;
}
void print(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
                System.Console.Write(mass[i, j, k] + $"({i},{j},{k})" + " ");
        System.Console.WriteLine("");
        }
}
print(Rand3DMass());