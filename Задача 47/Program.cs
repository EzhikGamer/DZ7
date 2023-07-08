// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// ===============НАЧАЛО===============
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matrixForPrint)
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

double[,] DoubleMatrix(int row, int col, double leftRange, double rightRange)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round((rightRange - leftRange) * rand.NextDouble() + leftRange, 3);
    }
    return matrix;
}

// --------------------------------------------------------------------------

int row = ReadInt("Кол-во строк");
int col = ReadInt("Кол-во столбов");
double leftRange = ReadInt("Левая граница");
double rightRange = ReadInt("Правая граница");
double[,] mat = DoubleMatrix(row, col, leftRange, rightRange);
PrintMatrix(mat);
// ===============КОНЕЦ===============