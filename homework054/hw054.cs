/*Задача «Возведение в степень»
Условие
Дано действительное положительное число a и целое 
неотрицательное число n. Вычислите an не используя 
циклы, возведение в степень через ** и функцию 
math.pow(), а используя рекуррентное соотношение 
an=a⋅an-1.
Решение оформите в виде функции power(a, n).*/
int power(int a, int n)
{
    if(n==1) return a;
    else return a*power( a,  n-1);
}
void print(int a,int n)
{
    System.Console.WriteLine(power(a,n));
}
print(2,5);