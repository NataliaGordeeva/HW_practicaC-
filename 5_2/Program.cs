// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
int size = array.Length;
int SumNeg = 0;

for(int i=0; i<size; i++)
{
array[i]=new Random().Next(0, 100);


int num=i%2;
if (num==0)
{
  SumNeg += array[i];
}
}

Console.WriteLine("[{0}]", String.Join(";", array));
Console.WriteLine("сумма нечетных элементов ="+"  "+SumNeg);

