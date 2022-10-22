/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

List<List<double>> metodArray()
{
    List<List<double>> array = new List<List<double>>();
    System.Console.WriteLine("Введите число строк: ");
    int lines = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число столбцов: ");
    int columns = int.Parse(Console.ReadLine());
    for (int i = 0; i < lines; i++)
    {
        array.Add(new List<double>());
        for (int j = 0; j < columns; j++)
        {
            array[i].Add(Math.Round(new Random().NextDouble() * 10, 2));
            //System.Console.Write(array[i][j] + "\t");
        }
        //System.Console.WriteLine();
    }
    return array;
}
void printArray ()
{
    List<List<double>> arr = metodArray();
    for (int i = 0; i < arr.Count; i++)
    {
        for (int j = 0; j < arr[i].Count; j++)
        {
            System.Console.Write(arr[i][j] + "\t");
        }
        System.Console.WriteLine();
    }
}
printArray();