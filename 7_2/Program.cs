// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix =new int[rows,columns];
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0; j<matrix.GetLength(1);j++)
    {
        matrix[i,j]=new Random().Next(-20,21);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0; j<matrix.GetLength(1);j++)
    {
        if (num == matrix[i, j])
        {
            Console.WriteLine("элемент в массиве присутствует");
        }
        else Console.WriteLine("элемента в массиве нет");
       
    }
}
