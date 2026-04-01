namespace LinearAlgebra.Operations
{
    public static class VectorMath
    {
        public static double CalculateAngleBetween(Vector a, Vector b)
        {
            double radians = Math.Acos(CalculateDotProduct(a, b) / (a.CalculateEuclideanNorm() * b.CalculateEuclideanNorm()));
            return (radians * 180) / Math.PI;
        }
        public static double CalculateDotProduct(Vector a, Vector b)
        {
            return (double)((a.x * b.x) + (a.y * b.y) + (a.z * b.z));
        }
        public static Vector CalculateCrossProduct(Vector a, Vector b)
        {
            return new Vector(
                a.y * b.z - a.z * b.y,
                a.z * b.x - a.x * b.z,
                a.x * b.y - a.y * b.x
            );
        }
        public static bool AreColinear(Vector a, Vector b)
        {
            if (a.IsNullVector() || b.IsNullVector())
                return false;

            Vector cross = CalculateCrossProduct(a, b);
            return cross.IsNullVector();
        }
    }
}
