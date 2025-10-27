int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = ReadMatrix(matrixSize);

int primaryDiagonal = FindSumOfPrimaryDiagonalElements(matrix);
int secondaryDiagonal = FindSumOfSecondaryDiagonalElements(matrix, matrixSize);

int diff = Math.Abs(primaryDiagonal - secondaryDiagonal);

Console.WriteLine($"{diff}");

static int FindSumOfSecondaryDiagonalElements(int[,] matrix, int size)
{
    int sum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        sum += matrix[row, size - 1 - row];
    }

    return sum;
}


static int FindSumOfPrimaryDiagonalElements(int[,] matrix)
{
    int sum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (row == col)
            {
                sum += matrix[row, col];
            }
        }
    }

    return sum;
}


static int[,] ReadMatrix(int matrixSize)
{
    int[,] resultMatrix = new int[matrixSize, matrixSize];

    for (int row = 0; row < matrixSize; row++)
    {
        int[] currentArray = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < matrixSize; col++)
        {
            resultMatrix[row, col] = currentArray[col];
        }
    }

    return resultMatrix;
}
