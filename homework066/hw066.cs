/*Дополнительно 3:
4: Отсортировать в матрице столбцы по убыванию значений
элементов в первой строке. Использовать заполнение
случайными значениями.
 3 -2  6  4    -2 3 4 6
 8  1  12 2 ->  1 8 2 12
 5  4 -8  0     4 5 0 -8 */
int[,] randomArrey()
{
    System.Console.WriteLine("Введите число строк: ");
    int lines = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число столбцов: ");
    int columns = int.Parse(Console.ReadLine());
    int[,] myArrey = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            myArrey[i, j] = new Random().Next(1, 10);
            //myArrey[i, j] = int.Parse(Console.ReadLine());
            //System.Console.Write(myArrey[i, j] + "\t");
        }
        //System.Console.WriteLine();
    }
    return myArrey;
}
int[,] myRandomArrey = randomArrey();
void printArray(int[,] myRand)
{
    int[,] arr2 = myRand;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            System.Console.Write(arr2[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("\nРандомный массив: ");
printArray(myRandomArrey);
int[,] sortArrey = myRandomArrey;
for (int i = 0; i < sortArrey.GetLength(1); i++)
{
    for (int j = 0; j < sortArrey.GetLength(1) - 1; j++)
    {
        if (sortArrey[0, j] > sortArrey[0, j + 1])
        {
            int c = 0;
            c = sortArrey[0, j];
            sortArrey[0, j] = sortArrey[0, j + 1];
            sortArrey[0, j + 1] = c;
            for (int k = 1; k < sortArrey.GetLength(0); k++)
            {
                int n = 0;
                n = sortArrey[k, j];
                sortArrey[k, j] = sortArrey[k, j + 1];
                sortArrey[k, j + 1] = n;
            }
        }
    }
}
System.Console.WriteLine("\nОтсортированный массив: ");
printArray(sortArrey);