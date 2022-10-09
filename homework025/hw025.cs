// SСоздание массива из двух массивов. В итоговом массиве 
// должны быть элементы первого и второго массива.
// [1,2,3] [4,5,6] -> [1,2,3,4,5,6]

//  int[] A = { 1, 2, 3, 4 };
//  int[] B= { 5, 6, 7, 8 };
//  int[] AB = A.Concat(B).ToArray();
//  System.Console.WriteLine("Новый массив: "+String.Join(",",AB));

int[] A()
{
Console.WriteLine("Введите количество элементов массива A: ");
int col = int.Parse(Console.ReadLine());
int[] myArrA = new int[col];
Console.WriteLine("Введите через enter значение элементов массива A: ");
for (int i=0;i< col;i++)
{
    myArrA[i] = int.Parse(Console.ReadLine());
}
//System.Console.WriteLine("Массив А: "+String.Join(",",myArrA));
return myArrA;
}
int[] B()
{
Console.WriteLine("Введите количество элементов массива B: ");
int col = int.Parse(Console.ReadLine());
int[] myArrB = new int[col];
Console.WriteLine("Введите через enter значение элементов массива B: ");
for (int i=0;i< col;i++)
{
    myArrB[i] = int.Parse(Console.ReadLine());
}
//System.Console.WriteLine("Массив B: "+String.Join(",",myArrB));
return myArrB;
}
void AB()
{
int[]myArrA=A();
int[]myArrB=B();
int col = myArrA.Length+myArrB.Length;
int[] myArrAB = new int[col];
int j=0;
for (int i=0; i<myArrA.Length; i++)
{
    myArrAB[j] = myArrA[i];
    j++;
}
for (int i=0; i<myArrB.Length; i++)
{
    myArrAB[j] = myArrB[i];
    j++;
}
System.Console.WriteLine("Массив А: "+String.Join(",",myArrA));
System.Console.WriteLine("Массив B: "+String.Join(",",myArrB));
System.Console.WriteLine("Новый массив AB: "+String.Join(",",myArrAB));
}
AB();