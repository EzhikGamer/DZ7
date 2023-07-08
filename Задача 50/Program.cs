// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// ===================================НАЧАЛО===================================
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

void Main()
{
    int row = ReadInt("Введите кол-во строк");
    int col = ReadInt("Введите кол-во столбцов");
    int x= ReadInt("Введите координату x");
    int y=ReadInt("Введите координату y");
    if(x<row&&y<col)
    {
        int[,] mat = FillMatrix(row, col, -20, 20);
        PrintMatrix(mat);
        System.Console.WriteLine();
        System.Console.WriteLine($"На строке {x} в столбце {y} находится число {mat[x,y]}");
    }
    else
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
}
// --------------------------------------------------------------------
Main();
// ===================================КОНЕЦ===================================
