// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки");
int rows= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int columns= Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[5,5];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]= new Random().Next(10);
        Console.Write(matrix[i,j]+" ");
    }
     Console.WriteLine();
}
if (rows<matrix.GetLength(0)&&columns<matrix.GetLength(1))
{
    Console.Write(matrix[rows-1,columns-1]);
}
else
{
    Console.Write("Такого числа в массиве нет");
}