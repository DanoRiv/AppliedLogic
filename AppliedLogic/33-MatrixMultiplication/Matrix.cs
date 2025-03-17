using System.Runtime.CompilerServices;

namespace _33_MatrixMultiplication;

public class Matrix
{
    private int[,] _matrixA;
    private int[,] _matrixB;
    private int[,] _matrixC;

    public Matrix(int m, int n, int p)
    {
        if (m < 1 || n < 1 || p < 1)
        {
            throw new Exception("Las dimensiones de la matriz deben ser mayor que 0");
        }
        MatrixA = new int[m, n];
        MatrixB = new int[n, p];
        MatrixC = new int[m, p];

        PopulateMatrixA(MatrixA);
        PopulateMatrixB(MatrixB);
        Multiply();
    }

    public int[,] MatrixA { get => _matrixA; set => _matrixA = value; }
    public int[,] MatrixB { get => _matrixB; set => _matrixB = value; }
    public int[,] MatrixC { get => _matrixC; set => _matrixC = value; }

    public void Print()
    {
        Console.WriteLine("*** A ***");
        PrintMatrix(MatrixA);

        Console.WriteLine("*** B ***");
        PrintMatrix(MatrixB);

        Console.WriteLine("*** C ***");
        PrintMatrix(MatrixC);
    }

    private void Multiply()
    {
        for (int i = 0; i < MatrixA.GetLength(0); i++)
        {
            for (int j = 0; j < MatrixB.GetLength(1); j++)
            {
                MatrixC[i, j] = 0;
                for (int k = 0; k < MatrixA.GetLength(1); k++)
                {
                    MatrixC[i, j] += MatrixA[i, k] * MatrixB[k, j];
                }
            }
        }
    }

    private void PopulateMatrixA(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = (i + 1) * j;
            }
        }
    }

    private void PopulateMatrixB(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = (j + 1) * i;
            }
        }
    }

    private void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}