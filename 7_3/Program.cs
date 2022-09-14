// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
double sum =0;

int [,] matrix =new int[rows,columns];
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0; j<matrix.GetLength(1);j++)
    {
        matrix[i,j]=new Random().Next(0,21);
                
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
    }
for (int i=0; i<rows;i++)
{
    sum += matrix[i,0]/rows;
}    
Console.WriteLine($"среднее арифметическое элементов 1 столбца = {sum}");

