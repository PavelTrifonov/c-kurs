// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void lenAB()
{   
int[] A=coordA();
int[] B=coordB();
double AB=Math.Round(Convert.ToDouble(Math.Sqrt(Math.Pow((B[0]-A[0]),2)+Math.Pow((B[1]-A[1]),2)+Math.Pow((B[2]-A[2]),2))),2);
Console.WriteLine("Расстояние между точками составляет: " + AB);
}
int[] coordA()
{
int col = 3;
int[] A = new int[col];
Console.WriteLine("Введите через enter координаты точки А: ");
for (int i=0;i< col;i++)
{
    A[i] = int.Parse(Console.ReadLine());
}
return A;
}
int[] coordB()
{
int col = 3;
int[] B = new int[col];
Console.WriteLine("Введите через enter координаты точки B: ");
for (int i=0;i< col;i++)
{
    B[i] = int.Parse(Console.ReadLine());
}
return B;
}

//  double AB=Math.Round(Convert.ToDouble(Math.Sqrt((2-3)*(2-3)+(1-6)*(1-6)+(-7-8)*(-7-8))),2);
//    Console.WriteLine(AB);
lenAB();