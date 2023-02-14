/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-15, 75);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void Average(int[,] matrix, int rows, int columns)
{
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        double avg = sum / rows;
        System.Console.Write($"{avg}\t");
    }
}
int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
int[,] matrix = CreateMatrix(rows, columns);
PrintArray(matrix);
Average(matrix, rows, columns);
System.Console.WriteLine();