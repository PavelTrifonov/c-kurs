/*Известно, что на доске 8×8 можно расставить 8 ферзей 
так, чтобы они не били друг друга. Вам дана расстановка 
8 ферзей на доске, определите, есть ли среди них пара 
бьющих друг друга.
Программа получает на вход восемь пар чисел, каждое 
число от 1 до 8 — координаты 8 ферзей. Если ферзи не 
бьют друг друга, выведите слово NO, иначе выведите YES.*/
int[,] ChessArr()
{
 int col=8;
 int[,] ArrFerz = new int[col,2];
 Console.Write("Визуализация двумерного массива: {");
 for (int i=0;i< col;i++)
 {
     Console.Write("{");
 for (int j=0;j< 2;j++)
 {
   ArrFerz[i,j] = new Random().Next(0,9);
   Console.Write(ArrFerz[i,j]);
   if(j==0)
   Console.Write(",");
 }
 if(i<7)
  Console.Write("},");
  else
  Console.Write("}");
 }
 Console.Write("}");
 return ArrFerz;
}
//ChessArr();
int[,] ArrFerz2=ChessArr();
int repetX=0;
int repetY=0;
for(int i=0;i<8;i++)
{
for(int j =0;j<8;j++)
{
if (ArrFerz2[i,0]==ArrFerz2[j,0]&&i!=j)
repetX++;
}
}
for(int i=0;i<8;i++)
{
for(int j =0;j<8;j++)
{
if (ArrFerz2[i,1]==ArrFerz2[j,1]&&i!=j)
repetY++;
}
}
if (repetX>0||repetY>0)
Console.WriteLine("YES");
else 
System.Console.WriteLine("NO");
//  for(int i =0;i<8;i++)
//  Console.WriteLine(ArrFerz[i,j]);
