//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int size = array.Length;
int PlusQ = 0;
for(int i=0; i<size; i++)
{
array[i]=new Random().Next(100, 1000);
int a= array[i]%2;

if (a==0)
{
  PlusQ ++;
  
}
}
Console.WriteLine("[{0}]", String.Join(";", array));
Console.WriteLine("колличество четных ="+"  "+PlusQ);


