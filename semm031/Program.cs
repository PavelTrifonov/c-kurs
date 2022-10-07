// Выводит все элементы массива пока не встретится элемент -1
//-3 2
//3 функции
int numRand()
{
   int numb = new Random().Next(-3, 2);
    return numb;
}
void elementk(int numb)
{
    Console.WriteLine(numb);
}
void stopRes()
{
    int k=numRand();
    while(k!=-1)
    {
        k=numRand();
        elementk(k);
    }
}
//numRand(numb);
stopRes();