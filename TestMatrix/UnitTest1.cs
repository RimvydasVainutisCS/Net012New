using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net012New;
using System;

namespace TestMatrix
{
    [TestClass]
    public class MatrixTests
    {
        // write more tests
        [TestMethod]
        public void CheckSqMatrixNegativeIndexes()
        {
            SquareMatrix<int> sqMatrix = new SquareMatrix<int>(2);
            sqMatrix[0, 0] = 10;
            Assert.AreEqual(10, sqMatrix[0, 0]);
        }

        [TestMethod]
        public void CheckSqMatrixIndexINotOutOfBounds()
        {
            SquareMatrix<int> sqMatrix = new SquareMatrix<int>(2);
            Assert.ThrowsException<IndexOutOfRangeException>(() => sqMatrix[2, 0]);
        }
    }
}