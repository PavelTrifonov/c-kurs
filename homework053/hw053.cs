/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
List<string> KoordX(float b1, float k1, float b2, float k2)
{
    string y = Convert.ToString((b1 * k2 - b2 * k1) / (k2 - k1));
    string x = Convert.ToString((b2 - b1) / (k1 - k2));
    List<string> X = new List<string>();
    X.Add(x);
    X.Add(y);
    return X;
}
void print()
{
    List<string> XY = new List<string>(KoordX(2, 5, 4, 9));
    System.Console.WriteLine("Координаты пересечения прямых: (" + String.Join("; ", XY) + ")");
}
print();
