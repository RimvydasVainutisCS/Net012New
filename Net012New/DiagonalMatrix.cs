using System;

namespace Net012New
{
    /// <summary>
    /// We create DiagoneMatrix of any Type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        readonly int _rank = 0;
        /// <summary>
        /// Create a rank of a given rank.
        /// </summary>
        /// <param name="rank"></param>
        public DiagonalMatrix(int rank) : base(rank, 1)
        {
            // memory allocated already in base class
            //data = new T[rank];
        }
        /// <summary>
        /// We override the Indexer from the Base class
        /// and fill all non-diagonal items with default
        /// values.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns>Returns array with the diagonal values set.</returns>
        /// <exception cref="Exception"></exception>
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
                if (i < 0 || j < 0 || i != j)
                {
                    throw new Exception("Wrong index.");
                }
                else if (data[i].Equals(value))
                {
                    Console.WriteLine("Values for this index is the same. We do not overwrite it.");
                }

                else if (i == j)
                {
                    data[i] = value;
                    OnItemChange?.Invoke(this, new UniversalEventArgs(i, j, value));
                }
            }
        }
    }
}
