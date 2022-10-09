// Создать программу, которая из массива удаляется элемент 
//с позиции, которую введет пользователь.
// Первый способ
int[] myOldarrey()
{
Console.WriteLine("Введите количество элементов списка: ");
int col = int.Parse(Console.ReadLine());
int[] myArr = new int[col];
Console.WriteLine("Введите через enter значение элементов списка: ");
for (int i=0;i< col;i++)
{
    myArr[i] = int.Parse(Console.ReadLine());
}
return myArr;
}
void myNewArrey()
{
int[] myArr2=myOldarrey();
int[] myArr3= new int[myArr2.Length-1];
int j=0;
Console.WriteLine("Введите элемент который нужно удалить из списка: ");
int numDel=int.Parse(Console.ReadLine())-1;
for(int i=0;i<myArr2.Length;i++)
if (i!=numDel)
{
myArr3[j]=myArr2[i];
j++;
}
else
 continue;   
System.Console.WriteLine("Старый массив: "+String.Join(" ",myArr2));
System.Console.WriteLine("Новый массив: "+String.Join(" ",myArr3));
}
//myNewArrey();
// Второй способ
void myNewArrey2(int[] OldArr,int numDel)
{
int[] NewArr= new int[OldArr.Length-1];
int j=0;
for(int i=0;i<OldArr.Length;i++)
if (i!=numDel-1)
{
NewArr[j]=OldArr[i];
j++;
}
else
 continue;   
System.Console.WriteLine("Старый массив: "+String.Join(" ",OldArr));
System.Console.WriteLine("Новый массив: "+String.Join(" ",NewArr));
}
myNewArrey2(new int[]{1,2,0,3,4},3);