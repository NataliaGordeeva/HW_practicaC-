// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе (452 -> 11, 
// 82 -> 10, 9012 -> 12)

Console.WriteLine("введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("сумма цифр = "+ GetSummary(num));

int GetSummary (int number)
{
   int sum = 0;
   {
   for (int i = 0; i < Ch.Count; i++)
   sum = sum + i;
   }

  return sum;
}

