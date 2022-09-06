// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе (452 -> 11, 
// 82 -> 10, 9012 -> 12)

Console.WriteLine("введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(num);

int sum = result[0];
Console.WriteLine(sum);

// int GetSummary (int number)
// {
//    int sum = 0;
//    {
//    for (int i = 0; i < Ch.Count; i++)
//    sum = sum + i;
//    }

//   return sum;
// }

