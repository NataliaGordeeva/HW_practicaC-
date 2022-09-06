// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[8];
int size = array.Length;

for(int i=0; i<size; i++)
{
array[i]=new Random().Next(0, 100);
}
Console.WriteLine("[{0}]", String.Join(";", array));

int max = array[1];
int min = array[1];
for (int i=0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

int a=max-min;
Console.WriteLine("max ="+"  "+max);
Console.WriteLine("mix ="+"  "+min);
Console.WriteLine("max-min ="+"  "+a);