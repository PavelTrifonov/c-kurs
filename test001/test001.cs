// See https://aka.ms/new-console-template for more information
string arr = Console.ReadLine();
string[] arr2=arr.Split(" ");
Console.Write(String.Join(",", arr2));
int r=arr.Length-1;
for(int i=0; i<arr2.Length;i++)
   if(arr2[r-i]!=20) 
   Console.WriteLine(arr2[3]);