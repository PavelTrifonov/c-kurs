// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

void dchetv(int n)
{
    if (n==1)
        Console.WriteLine("x>0;y>0");
    else if (n==2)
        Console.WriteLine("x<0;y>0");
    else if (n==3)
        Console.WriteLine("x<0;y<0");
    else
        Console.WriteLine("x>0;y<0");
}
dchetv(Convert.ToInt16(Console.ReadLine()));