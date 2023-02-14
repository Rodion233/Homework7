/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
1, 1 -> 1 */
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
int FindIndex(int[,] matrix, int num1, int num2)
{
    if (num1 < 0 || num2 < 0 || num1 > matrix.GetLength(0) - 1 || num2 > matrix.GetLength(1) - 1)
    {
        System.Console.WriteLine("Такого числа в массиве нет");
        return 0;
    }
    return matrix[num1, num2];
}
int rows = Prompt("Введите число строк");
int columns = Prompt("Введите число столбцов");
int[,] matrix = CreateMatrix(rows, columns);
PrintArray(matrix);
int num1 = Prompt("Введите индекс строки:");
int num2 = Prompt("Введите индекс столбца:");
System.Console.WriteLine(FindIndex(matrix, num1 - 1, num2 - 1));
