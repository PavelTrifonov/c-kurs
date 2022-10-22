/*Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же 
указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
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
            array[i].Add(new Random().Next(0, 10));
            //System.Console.Write(array[i][j] + "\t");
        }
        //System.Console.WriteLine();
    }
    return array;
}
List<List<double>> myArr = metodArray();
void printArray()
{
    List<List<double>> arr = myArr;
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
void numbIndexes()
{
    List<List<double>> myList = myArr;
    System.Console.WriteLine("Введите номер строки элемента массива, который хотите увидеть: ");
    int line = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите номер столбца элемента массива, который хотите увидеть: ");
    int column = int.Parse(Console.ReadLine());
    for (int i = 0; i < myList.Count; i++)
    {
        if (i == line - 1)
        {
            for (int j = 0; j < myList[i].Count; j++)
            {
                if (j == column - 1)
                {
                    System.Console.WriteLine("Этот элемент имеет значение: " + myList[i][j]);
                    return;
                }
            }
            System.Console.WriteLine("Такого элемента нет!");
            return;
        }
    }
System.Console.WriteLine("Такого элемента нет!");   
}
numbIndexes();