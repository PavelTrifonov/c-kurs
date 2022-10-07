// Найти сумму всех элементов массива целых чисел, которые 
//меньше среднего арифметического элементов массива. 
// Размерность массива –20. Заполнение массива осуществить случайными 
// числами от 150 до 300
double srednear(int[] arr)
{
int sumarr=0;
int k=1;
for (int i=0;i<arr.Length;i++)
{
    sumarr+=arr[i];
    k++;
}
double sr=double.Parse(sumarr/k);
return sr;
}