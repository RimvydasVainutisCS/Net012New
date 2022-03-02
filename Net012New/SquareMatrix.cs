namespace Net012New
{
    /// <summary>
    /// I create this class and access the base class from here.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SquareMatrix<T> : Matrix<T>
    {
        /// <summary>
        /// Constructor to create a square.
        /// </summary>
        /// <param name="rank"></param>
        public SquareMatrix(int rank) : base(rank, rank)
        {

        }
        // allocating memory for DiagonalMatrix

        protected SquareMatrix(int col, int row) : base(col, 1)
        {

        }
    }
}