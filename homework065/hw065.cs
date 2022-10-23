/*3: Дана матрица целых чисел размером n*m. Выведите
количество седловых точек. (Седловой точкой называется
элемент, который является наименьшим в своей строке и
наибольшим в своем столбце или, наоборот, наибольшим в
своей строке и наименьшим в своем столбце).
3 4 - размерность
7 1 5 3
3 2 6 4 -> 2
5 2 8 6 */
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
            //myArrey[i, j] = new Random().Next(1, 10);
            myArrey[i, j] = int.Parse(Console.ReadLine());
            //System.Console.Write(myArrey[i, j] + "\t");
        }
        //System.Console.WriteLine();
    }
    return myArrey;
}
int[,] myRandomArrey = randomArrey();
void printArray()
{
    int[,] arr2 = myRandomArrey;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            System.Console.Write(arr2[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}
printArray();
int count = 0;
for (int i = 0; i < myRandomArrey.GetLength(0); i++)
{
    int maxLine = 0;
    int minLine = 10;
    int idnexMin = 0;
    int indexMax = 0;
    for (int j = 0; j < myRandomArrey.GetLength(1); j++)
    {
        if (myRandomArrey[i, j] > maxLine)
        {
            maxLine = myRandomArrey[i, j];
            indexMax = j;
        }
        if (myRandomArrey[i, j] < minLine)
        {
            minLine = myRandomArrey[i, j];
            idnexMin = j;
        }
    }
    int maxColumn = 0;
    int minColumn = 10;
    for (int k = 0; k < myRandomArrey.GetLength(0); k++)
    {
        if (myRandomArrey[k, idnexMin] > maxColumn)
            maxColumn = myRandomArrey[k, idnexMin];
        if (myRandomArrey[k, indexMax] < minColumn)
            minColumn = myRandomArrey[k, indexMax];
    }
    if (maxColumn == minLine)
    {
        System.Console.Write(maxColumn + "-седловая точка!\n");
        count++;
    }
    else if (minColumn == maxLine)
    {
        System.Console.Write(minColumn + "-седловая точка!\n");
        count++;
    }
}
System.Console.Write("Количесвто седловых точек = " + count);