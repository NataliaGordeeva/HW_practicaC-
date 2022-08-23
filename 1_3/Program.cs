//  Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());

int a = (number % 2);
if (a == 0)
{
Console.WriteLine("четное число");
}
else
{
Console.WriteLine("нечетное число");
}
