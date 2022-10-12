/*Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B. Сделать в функции, сделать проверку 
на отрицательность.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
void stepen()
{
System.Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
// double C=Math.Pow(A,B); / готовая встроенная функция))
// System.Console.WriteLine(C);
if(B>0)
{int C=1;
for(int i=0;i<B;i++)
{C*=A;}
System.Console.WriteLine(C);
}
else
System.Console.WriteLine("Введено не натуральное число B!!");
}
stepen();