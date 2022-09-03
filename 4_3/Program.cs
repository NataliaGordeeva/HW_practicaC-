// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[] array = new int[8];

void GetMassiv(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index<lenght)
    {
        collection[index]=new Random().Next(0, 99);
        index++;
    }
}

GetMassiv(array);
Console.WriteLine("массив:{0} ",String.Join(" ",array));
