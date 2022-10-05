// Задайте значение N. Программа выводит все натуральные числа в промежутке от 1 до N: N = 5 -> "1, 2, 3, 4, 5".

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int start = 1;
if (num<start) Console.WriteLine("Введено неверное число");

string NumRange (int numStart,int numEnd)
{
     if(numStart<=numEnd) 
    return $"{numStart} "+ NumRange(numStart+1,numEnd);
    else return string.Empty;
}
Console.WriteLine(NumRange(start,num));
