// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] array = new int[8];
int size = array.Length;
int plusQ=0;
for(int i=0; i<size; i++)
{
    array[i]=new Random().Next(-20, 21);
    int a= array[i];
    if (a>0)
    {
        plusQ++;
    }

}
Console.WriteLine("[{0}]", String.Join(";", array));
Console.WriteLine("колличество чисел > 0 = "+plusQ);

