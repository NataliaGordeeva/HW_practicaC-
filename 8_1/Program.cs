// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//  каждой строки двумерного массива. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix =new int[rows,columns];
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0; j<matrix.GetLength(1);j++)
    {
        matrix[i,j]=new Random().Next(-10,11);
                
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
    }
Console.WriteLine("второй массив");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1)-1; k++)
        {
            if (matrix[i,k] < matrix[i,k-1])
            {
                int count=matrix[i,k];
                matrix[i,k]=matrix[i,k+1];
                matrix[i,k+1]=count;
            }
        }
        Console.Write(matrix[i,j]+"\t");
    }
Console.WriteLine();
}

