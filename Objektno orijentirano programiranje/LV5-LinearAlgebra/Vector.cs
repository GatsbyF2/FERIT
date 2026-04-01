namespace LinearAlgebra
{
    public interface IComparable<T>
    {
        int CompareTo(T other);
    }
    public class Vector : IComparable<Vector>
    {
        public int x {get;set;}
        public int y {get;set;}
        public int z {get;set;}
        public Vector()
        {
            x = 0; y=0; z=0;
        }
        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
        public double CalculateEuclideanNorm()
        {
            return (double)Math.Sqrt((x*x)+(y*y)+(z*z));
        }
        public void MultiplyBy(int scalar)
        {
            x*= scalar;
            y*= scalar;
            z*= scalar;
        }
        public bool IsNullVector()
        {
            if (x == 0 && y == 0 && z == 0) return true;
            return false;
        }
        public int CompareTo(Vector a)
        {
            return CalculateEuclideanNorm().CompareTo(a.CalculateEuclideanNorm());
        }
    }
    
}

