// Преобразовать массив так, чтобы сначала шли 
//нулевые элементы, а затем все остальные.
//-1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2
int col = new Random().Next(5,10);
int[] myArr = new int[col];
for (int i=0;i< col;i++)
{
    myArr[i] = new Random().Next(-3,1);
}
Console.WriteLine("Старый массив:: "+ String.Join(", ",myArr));
int j=0;
for(int i = 0;i<col;i++)
{
int c=0;
if (myArr[i]==0)
{
c=myArr[j];
myArr[j]=myArr[i];
myArr[i]=c;
j++;
}
}
Console.WriteLine("Новый массив: "+ String.Join(", ",myArr));