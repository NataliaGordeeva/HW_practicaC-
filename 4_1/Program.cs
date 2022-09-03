//  Напишите цикл, который принимает на вход два числа (A и B) и возводит 
//число A в натуральную степень ( 3, 5 -> 243 (3⁵), 2, 4 -> 16)

Console.WriteLine("введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write(Math.Pow(numA,numB)+" ");

