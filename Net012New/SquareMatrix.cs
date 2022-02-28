namespace Net012New
{
    public class SquareMatrix<T> : Matrix<T>
    {
        readonly int _rank = 0;

        public SquareMatrix(int rank) : base(rank, rank)
        {
            _rank = rank;
        }
    }
}
