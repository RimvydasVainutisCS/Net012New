using System;

namespace Net012New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");
            Console.WriteLine("-------------\n");

            Matrix<int> matrixOne = new Matrix<int>(2, 2);
            matrixOne[1, 1] = 2;
            int res = matrixOne[0, 0];

            DiagonalMatrix<int> diagonalMatrixOne = new DiagonalMatrix<int>(2);
            
            diagonalMatrixOne.OnItemChange += MyMethod;
            diagonalMatrixOne[0, 0] = 11;
            //diagonalMatrixOne[0, 0] = 11;
            diagonalMatrixOne[1, 1] = 22;
            //diagonalMatrixOne[0, 0] = 33;

            ////SquareMatrix<int> squareMatrixOne = new SquareMatrix<int>(2);
            ////squareMatrixOne[0, 0] = 1;
            ////squareMatrixOne[0, 0] = 1;
            Matrix<int> matrix = new Matrix<int>(2, 2);
            matrix[1, 1] = 2;
            matrix[1, 1] = 2;


        }

        public static void MyMethod(object arg, UniversalEventArgs universalEventArgs)
        {
         


            Console.WriteLine("The Matrix values has changed.");
            Console.WriteLine($"The new value of index i: {universalEventArgs.i}, j: {universalEventArgs.j} now is: {universalEventArgs.value}");
        }
    }
}
