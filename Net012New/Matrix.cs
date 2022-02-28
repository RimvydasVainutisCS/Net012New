using System;

namespace Net012New
{
    public class Matrix<T>
    {
        public EventHandler<UniversalEventArgs> OnItemChange { get; set; }
        private int ColumnsNumber { get; }
        private int RowsNumber { get; }

        protected T[] data;
        public Matrix(int col, int row)
        {
            ColumnsNumber = col;
            RowsNumber = row;

            data = new T[col * row];
        }

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
                else if (data[GetIndex(RowsNumber, ColumnsNumber)].Equals(value))
                {
                    Console.WriteLine("Not Generated");
                }


                else
                {
                    data[(i * ColumnsNumber) + j] = value;
                }
            }
        }
        public int GetIndex(int i, int j) => (RowsNumber * i) + j;


    }
}
