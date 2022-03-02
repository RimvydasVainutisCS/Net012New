using System;

namespace Net012New
{
    /// <summary>
    /// Base abstract generic Matrix class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Matrix<T>
    {
        /// <summary>
        /// EventHandler to track the Matrix value changes.
        /// </summary>
        public EventHandler<UniversalEventArgs> OnItemChange { get; set; }
        private int ColumnsNumber { get; }
        private int RowsNumber { get; }

        protected T[] data;
        /// <summary>
        /// Constructor to access internal Matrix<T> fields.
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <param name="data"></param>
        public Matrix(int col, int row)
        {
            ColumnsNumber = col;
            RowsNumber = row;
            data = new T[col * row];
        }

        protected Matrix()
        {

        }

        /// <summary>
        /// A virtual Indexer with a generic Type taking two parameters i and j to define the index of a Matrix element.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns>Returns a one dimensional list of a Matrix values</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="Exception"></exception>
        public virtual T this[int i, int j]
        {
            get { return data[(i * ColumnsNumber) + j]; }
            set
            {
                // check if the index is not out of the matrix bounds (Aij: i -- row index; j -- col index)
                if (i >= RowsNumber || j >= ColumnsNumber)
                {
                    throw new ArgumentException("Your indexes i or j are out of Matrix bounds.");
                }
                else if (i < 0 || j < 0)
                {
                    throw new Exception("Indexes can't be negative values!");
                }
                else if (data[(i * ColumnsNumber) + j].Equals(value))
                {
                    Console.WriteLine("Not Generated");
                }
                else
                {
                    data[(i * ColumnsNumber) + j] = value;
                    OnItemChange?.Invoke(this, new UniversalEventArgs(i, j, value));
                }
            }
        }

        // 3*1 + 1 = 5 
        //public int GetIndex(int i, int j) => (RowsNumber * i) + j;


    }
}
