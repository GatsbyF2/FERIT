using LinearAlgebra;
using LinearAlgebra.Operations;
using System;


static class Program
{
    static void Main()
    {
        //Vector a = new Vector();
        //Vector b = new Vector(1, 2, 3);
        //Vector c = new Vector(2, 4, 6);
        //Vector d = new Vector(7, 11, 13);

        //Vector[] vectors = new Vector[] { a, b, c, d };

        //foreach (Vector vector in vectors)
        //{
        //    Console.WriteLine($"Vector: {vector}");
        //    Console.WriteLine($"\tIs null vector? : {vector.IsNullVector()}");
        //    Console.WriteLine($"\tEuclidean norm: {vector.CalculateEuclideanNorm()}");
        //}

        //Console.WriteLine($"Angle between {c} and {d} is {VectorMath.CalculateAngleBetween(c, d)} degrees.");
        //Console.WriteLine($"Dot product of {c} and {d} is {VectorMath.CalculateDotProduct(c, d)}.");
        //Console.WriteLine($"Cross product of {c} and {d} is {VectorMath.CalculateCrossProduct(c, d)}.");

        //// For this to work, place cursor in the Assert class, hit Alt + Enter and install the MsTest library package.
        //double delta = 0.001;
        //Assert.AreEqual(136, VectorMath.CalculateDotProduct(c, d));
        //Assert.AreEqual(9.2261, VectorMath.CalculateAngleBetween(c, d), delta);
        //Assert.AreEqual(0.0000, VectorMath.CalculateAngleBetween(b, c), delta);

        //Assert.IsTrue(VectorMath.CalculateCrossProduct(b, c).IsNullVector());
        //Assert.IsFalse(VectorMath.CalculateCrossProduct(b, d).IsNullVector());

        //Assert.IsTrue(VectorMath.AreColinear(b, c));
        //Assert.IsFalse(VectorMath.AreColinear(b, d));

        //Console.WriteLine("After multiplication:");

        //int scalar = 3;
        //foreach (Vector vector in vectors)
        //{
        //    vector.MultiplyBy(scalar);
        //    Console.WriteLine($"Vector: {vector}");
        //}

        //DRUGIIIIIIIIIIII ZADATAK
        // Random generator = new Random();
        // Matrix A = new Matrix(5, 5);
        // Console.WriteLine($"A:{Environment.NewLine}{A.ToString()}{Environment.NewLine}");
        // Matrix B = Matrix.Create(4, 3, generator, 1, 5);
        //Console.WriteLine($"B:{Environment.NewLine}{B.ToString()}{Environment.NewLine}");
        // Console.WriteLine($"Size of B: {B.GetRows()} by {B.GetColumns()}");
        // Console.WriteLine($"Element at [0,0]: {B.GetElement(0, 0)}");

        // Console.WriteLine("\nTestiranje [2x3]*[3x2]...\n");

        // A = Matrix.Create(2, 3, generator,1,5);
        // B = Matrix.Create(3, 2, generator,1,5);
        // Console.WriteLine(A.ToString());
        // Console.WriteLine(B.ToString());
        // Console.WriteLine((A * B).ToString());

        Random rnd = new Random();

        // Test s cijelim brojevima
        int[] intArray = new int[10];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = rnd.Next(0, 100);
        }
        Console.WriteLine("Int array: " + string.Join(", ", intArray));
        Console.WriteLine("Number of spikes: " + Utilities.CountSpikes(intArray));

        // Test s vektorima
        Vector[] vectors = new Vector[5];
        for (int i = 0; i < vectors.Length; i++)
        {
            vectors[i] = new Vector(rnd.Next(0,100), rnd.Next(0, 100), rnd.Next(0, 100));
        }

        Console.WriteLine("\nVector array:");
        foreach (var v in vectors)
        {
            Console.WriteLine(v + " Norm: " + v.CalculateEuclideanNorm());
        }

        Console.WriteLine("Number of vector spikes: " + Utilities.CountSpikes(vectors));
    }
}


