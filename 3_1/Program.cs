// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 23432 -> да

string num = Console.ReadLine();

for (int i = 0; i < (num.Length - 1) / 2; i++)

if (num[i] != num[num.Length - i - 1])
Console.WriteLine(false);

else
Console.WriteLine(true);

