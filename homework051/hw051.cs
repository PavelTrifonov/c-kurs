
System.Console.WriteLine("Задайте размер массива: ");
int num=int.Parse(Console.ReadLine());
int [,] Saper=new int[num,num];
for(int i=0;i<num;i++)
 {
 for(int j =0;j<num;j++)
{ if (j<i)
 Saper[i,j]=j+1;
 else if(j>=i)
 Saper[i,j]=i+1;
System.Console.Write(Saper[i,j]+" ");
 }
 System.Console.WriteLine("");
}
