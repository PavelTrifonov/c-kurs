// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного 
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void sortedArray()
{
    for (int i = 0; i < arr.Count; i++)
    {
        arr[i].Sort();
        arr[i].Reverse();        
    }

}
printArray(arr);
System.Console.WriteLine();
sortedArray();
printArray(arr);