public class MatrixMultiplicationException : Exception
{
    public MatrixMultiplicationException(int rowsA, int colsA, int rowsB, int colsB)
        : base($"Matrice dimenzija [{rowsA}×{colsA}] i [{rowsB}×{colsB}] se ne mogu množiti.")
    {
    }
}
