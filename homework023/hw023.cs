// Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void tableN()
{
Console.WriteLine("Введите число (N): ");
int N = int.Parse(Console.ReadLine());
int[] myArr = new int[N];
int numb=1;
for (int i=0;i< N;i++)
{
    myArr[i] = Convert.ToInt32(Math.Pow(numb,3));
    numb++;
}
Console.WriteLine("Tаблица кубов чисел от 1 до N: "+ String.Join(", ",myArr));
}
tableN();
 