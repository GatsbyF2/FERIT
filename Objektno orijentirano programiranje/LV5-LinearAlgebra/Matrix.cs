namespace LinearAlgebra
{
    public class Matrix
    {
        public int[,] a { get; set; }

        public int GetRows()
        {
            return a.GetLength(0); 
        }
        public int GetColumns()
        {
            return a.GetLength(1); 
        }

        public Matrix(int x, int y)
        {
            a = new int[x,y];
            for(int i=0; i < x; i++){
                for(int j=0; j<y; j++)
                {
                    a[i,j] = 0;
                }
            }
        }
        public void SetElement(int x, int y, int n)
        {
            a[x, y] = n;
        }
        public int GetElement(int x, int y)
        {
            return a[x, y];
        }
        public override string ToString()
        {
            string matrix = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    matrix += a[i, j] +" ";
                }
                matrix += "\n";
            }
            return matrix;
        }
        public static Matrix Create(int x, int y, Random generator, int min, int max)
        {
            Matrix newMatrix = new Matrix(x, y);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    newMatrix.SetElement(i,j, generator.Next(min, max + 1));
                }
            }
            return newMatrix;
        }
        public void Transpose()
        {
            int x = a.GetLength(0);
            int y = a.GetLength(1);
            int[,] newMatrix = new int[y, x];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    newMatrix[j,i]=a[i,j];
                }
            }
            a = newMatrix;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            int x1 = m1.a.GetLength(0);
            int y1 = m1.a.GetLength(1);
            int x2 = m2.a.GetLength(0);
            int y2 = m2.a.GetLength(1);


            if (y1 != x2)
                throw new MatrixMultiplicationException(x1, y1, x2, y2);

            Matrix newMatrix = new Matrix(x1, y2);



            for(int i=0; i<x1; i++)
            {
                for(int j=0; j<y2; j++)
                {
                    int sum = 0;
                    for(int k=0; k<y1; k++)
                    {
                        sum += m1.a[i, k] * m2.a[k, j];
                        
                    }
                    newMatrix.SetElement(i, j, sum);
                }
            }
            return newMatrix;
        }
        
    }
}
