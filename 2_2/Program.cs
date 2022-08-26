// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int num = new Random().Next(1, 1000);
int num3=num%10;
if (num3 !=0)
{
Console.WriteLine(num + " " + num3);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
