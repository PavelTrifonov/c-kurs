// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
List<List<double>> randomArray()
{
    List<List<double>> array = new List<List<double>>();
    System.Console.WriteLine("Введите число строк: ");
    int lines = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Введите число столбцов: ");
    int columns = int.Parse(System.Console.ReadLine());
    for (int i = 0; i < lines; i++)
    {
        array.Add(new List<double>());
        for (int j = 0; j < columns; j++)
        {
            array[i].Add(Math.Round(new Random().NextDouble() * 9, 0));
            //System.Console.Write(array[i][j] + "\t");
        }
        //System.Console.WriteLine();
    }
    return array;
}
List<List<double>> arr = randomArray();
void printArray(List<List<double>> arr2)
{
    //List<List<double>> arr2 = arr;
    for (int i = 0; i < arr2.Count; i++)
    {
        for (int j = 0; j < arr2[i].Count; j++)
        {
            System.Console.Write(arr2[i][j] + " ");
        }
        System.Console.WriteLine();
    }
}
void lineWithMinSum()
{
    double minSum = 1000000000;
    int line = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        double Sum = arr[i].Sum();
        if (Sum < minSum)
        {
            minSum = Sum;
            line = i+1;
        }
    }
    System.Console.WriteLine($"Cтрока с наименьшей суммой  элементов = {minSum}: {line} строка");
}
printArray(arr);
System.Console.WriteLine();
lineWithMinSum();
