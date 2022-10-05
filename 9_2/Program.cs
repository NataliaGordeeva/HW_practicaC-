// Задайте значения M и N. Программа выводит все натуральные числа в промежутке от M до N: M = 1; N = 5 -> "1, 2, 3, 4, 5".

Console.WriteLine("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Первый вариант (только для М<=N):

string NumRange (int number1,int number2)
{
    if(number1<=number2) return $"{number1} "+ NumRange(number1+1,number2);
    else return string.Empty;
}
Console.WriteLine(NumRange(num1,num2));