// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows,columns];
int sum=0;
int countJ=0;
for(int i=0; i<rows; i++)
{
    for(int j=0; j<columns; j++)
    {
        array[i,j]=new Random().Next(0,11);

        // for (j=0;j<columns;j++)
        // {
        //     sum+=j;
        //     countJ++;
            
        // }
        
    Console.Write(array[i,j] + "\t");
    }
Console.WriteLine();
}
Console.Write($"сумма = {sum}");


