// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1= ");
Console.WriteLine("Введите число 2= ");
Console.WriteLine("Введите число 3= ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    if (number1 > number3)
    {
      Console.WriteLine("Число 1 - max");   
    }
    else
     Console.WriteLine("Число 3 - max");
}
else
{
 if (number2 > number3)
 Console.WriteLine("Число 2 - max");
 else
 {
    Console.WriteLine("Число 3 - max");
 }
}