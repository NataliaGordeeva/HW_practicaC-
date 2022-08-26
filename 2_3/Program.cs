// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7 = ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>7 | num<1)
{
    Console.WriteLine("введите еще раз");
}
else
{
    if(num==6 || num==7)
    {
        Console.WriteLine("ура!, выходной");
    }
    else
    {
        Console.WriteLine("рабочий день");
    }
}
