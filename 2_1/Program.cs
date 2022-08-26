//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

int num = new Random().Next(100, 999);
int num2 = (num/10)%10;

Console.WriteLine(num);
Console.Write(num2);
