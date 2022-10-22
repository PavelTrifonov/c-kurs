/*2: По данным числам n и m заполните двумерный массив размером
n×m числами от 1 до n×m “змейкой”, как показано в примере.
Вводятся два числа n и m. Чтобы сделать такой большой отступ можно
использовать \t.
*/
List<List<double>> metodSnake()
{
    List<List<double>> array = new List<List<double>>();
    System.Console.WriteLine("Введите число строк: ");
    int lines = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число столбцов: ");
    int columns = int.Parse(Console.ReadLine());
    int count = 1;
    for (int i = 0; i < lines; i++)
    {
        List<double> myList = new List<double>();
        for (int k = 0; k < columns; k++)
            myList.Add(1);
        array.Add(myList);
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0)
            {
                array[i][j] = count;
                count++;
                //System.Console.Write(array[i][j] + "\t");
            }
            else if (i % 2 != 0)
            {
                array[i][columns - j - 1] = count;
                count++;
                //System.Console.Write(array[i][j] + "\t");
            }
        }
        //System.Console.WriteLine();
    }
    return array;
}
List<List<double>> arr = metodSnake();
void printArray()
{
    List<List<double>> arr2 = arr;
    for (int i = 0; i < arr2.Count; i++)
    {
        for (int j = 0; j < arr2[i].Count; j++)
        {
            System.Console.Write(arr2[i][j] + "\t");
        }
        System.Console.WriteLine();
    }
}
printArray();