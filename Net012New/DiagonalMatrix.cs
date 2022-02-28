using System;

namespace Net012New
{
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        readonly int _rank = 0;

        public DiagonalMatrix(int rank) : base(rank)
        {
            data = new T[rank];
        }

        public override T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0)
                {
                    throw new Exception("Indexes can't be negative values!");
                }
                else if (i != j)
                    return default(T);
                else
                {
                    return data[i];
                }
            }
            set
            {
                //if (i > _rank - 1)
                //{
                //    throw new Exception("Index i is out of Diagonal Matrix bounds!");
                //}
                //else if (j > _rank - 1)
                //{
                //    throw new Exception("Index j is out of Diagonal Matrix bounds!");
                //}
                if (i < 0 || j < 0)
                {
                    throw new Exception("Indexes can't be negative values!");
                }
                else if (data[i].Equals(value))
                {
                    Console.WriteLine("Not generate.");
                }
                else if (i == j)
                {
                    data[i] = value;
                    OnItemChange?.Invoke(this, new UniversalEventArgs(i, j, value));
                    //OnDiagMatrixIndexChanged(new DiagonalMatrixChanges<T>(i, j, value));
                }
            }
        }
        
        // public or protected???
        //public void OnDiagMatrixIndexChanged(DiagonalMatrixChanges<T> e)
        //{
        //    DiagMatrixIndexChanged?.Invoke(this, e);
        //}

        
    }
}
