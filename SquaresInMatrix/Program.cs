int[] matrixSize = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

string[,] matrix = ReadMatrix(rows, cols);

int squaresInMatrixCount = FindSquaresInMatrix(matrix);

Console.WriteLine(squaresInMatrixCount);


static int FindSquaresInMatrix(string[,] matrix)
{
    int squaresCount = 0;

    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
    {
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            if (matrix[row, col] == matrix[row, col + 1]
                && matrix[row, col] == matrix[row + 1, col]
                && matrix[row, col] == matrix[row + 1, col + 1])
            {
                squaresCount++;
            }
        }
    }

    return squaresCount;
}

static string[,] ReadMatrix(int rows, int cols)
{
    string[,] resultMatrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] inputChars = Console.ReadLine().Split().ToArray();

        for (int col = 0; col < cols; col++)
        {
            resultMatrix[row, col] = inputChars[col];
        }
    }

    return resultMatrix;
}
