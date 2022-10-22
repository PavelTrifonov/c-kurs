/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
List<List<double>> randomArray()
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
            array[i].Add(Math.Round(new Random().NextDouble() * 10, 0));
            //System.Console.Write(array[i][j] + "\t");
        }
        //System.Console.WriteLine();
    }
    return array;
}
List<List<double>> arr = randomArray();
void srNumColumn()
{
    List<double> srColumnList = new List<double>();
    for (int i = 0; i < arr.Count; i++)
    {
        double sum = 0;
        for (int j = 0; j < arr[i].Count; j++)
        {
            sum += arr[j][i];
        }
        srColumnList.Add(sum / arr.Count);
        System.Console.Write(Math.Round(sum / arr.Count,2)+"\t");
    }

}
void printArray ()
{
    List<List<double>> arr2 = arr;
    for (int i = 0; i < arr.Count; i++)
    {
        for (int j = 0; j < arr2[i].Count; j++)
        {
            System.Console.Write(arr2[i][j] + "\t");
        }
        System.Console.WriteLine();
    }
}
printArray();
System.Console.WriteLine("Среднеарифметическое значение элементов столбцов: ");
srNumColumn();