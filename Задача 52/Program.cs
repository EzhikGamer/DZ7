// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ===================================НАЧАЛО===================================
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Arif(int[,] mat)
{
    double sum = 0;
    for (int j = 0; j < mat.GetLength(0); j++)
    {
        for (int i = 0; i < mat.GetLength(1); i++)
        {
            if (i < mat.GetLength(0))
            {
                sum += mat[i, j];
            }
        }
        System.Console.WriteLine();
        sum /= mat.GetLength(0);
        System.Console.Write($"Среднее арифметическое столбца {j} равно -> {Math.Round(sum, 2)}");
        sum = 0;
    }
}

void Main()
{
    int row = ReadInt("Число строк");
    int col = ReadInt("Число столбов");
    int[,] mat = FillMatrix(row, col, 0, 10);
    PrintMatrix(mat);
    Arif(mat);
}
// ----------------------------------------------------------------------
Main();
// ===================================КОНЕЦ===================================







