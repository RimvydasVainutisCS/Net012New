using System;

namespace Net012New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");
            Console.WriteLine("-------------\n");

            try
            {
                DiagonalMatrix<int> diagonalMatrixOne = new DiagonalMatrix<int>(2);

                diagonalMatrixOne.OnItemChange += MyMethod;
                diagonalMatrixOne[0, 0] = 11;
                diagonalMatrixOne[0, 0] = 11;
                diagonalMatrixOne[1, 1] = 22;
                diagonalMatrixOne[-1, 0] = 33;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("all fine!");
        }

        public static void MyMethod(object arg, UniversalEventArgs universalEventArgs)
        {
            Console.WriteLine("The Matrix values has changed.");
            Console.WriteLine($"The new value of index i: {universalEventArgs.i}, j: {universalEventArgs.j} now is: {universalEventArgs.value}");
        }
    }
}
