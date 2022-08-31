// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a< N)
{
    Console.Write(Math.Pow(a,3)+" ");
    a++;
} 