/*Задача повышенной сложности
Напишите программу.
Какая сумма элементов массива больше – с первого до элемента с номером К 
или от элемента с номером К+1 до последнего.
На вход подается массив чисел. Затем вводится 
переменная K. На выход программа должна вывести или "Первая часть" или 
"Вторая часть"
Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна 
вывести 1 часть, так как 42 больше, чем 19.*/
Console.WriteLine("Введите количество элементов массива: ");
int col = int.Parse(Console.ReadLine());
int[] myArr = new int[col];
int a = 0;
Console.WriteLine("Введите через enter элементы списка: ");
while (a<col)
    {myArr[a] = int.Parse(Console.ReadLine());
    a=a+1;}
Console.WriteLine("Введите переменную K: ");
int K = int.Parse(Console.ReadLine());
int i=0;
int sum1=0;
while (i<K)
    {sum1=sum1+myArr[i];
    i=i+1;}
int j=K+1;
int sum2=0;
while (j<col)
    {sum2=sum2+myArr[j];
    j=j+1;}
if (sum1>sum2)
    Console.WriteLine("Первая часть");
else
    Console.WriteLine("Вторая часть");