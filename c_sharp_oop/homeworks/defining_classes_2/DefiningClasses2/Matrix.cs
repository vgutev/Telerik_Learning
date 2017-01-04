using System;

namespace DefiningClasses2
{
    class Matrix<T>
    {
        private T[,] matrix;
        private int row, col;

        public Matrix(int Row, int Col)
        {
            this.matrix = new T[row, col];
            this.row = Row;
            this.col = Col;
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {

            if (!CompCheck(m1, m2))
            {
                throw new Exception("Matrices not compatible!");
            }
            Matrix<T> m3 = new Matrix<T>(m1.row, m1.col);
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.col; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }
            return m3;
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (!CompCheck(m1, m2))
            {
                throw new Exception("Matrices not compatible!");
            }
            Matrix<T> m3 = new Matrix<T>(m1.row, m1.col);
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.col; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }

            return m3;
        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (!CompCheck(m1, m2))
            {
                throw new Exception("Matrices not compatible!");
            }
            Matrix<T> m3 = new Matrix<T>(m1.row, m1.col);
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.col; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] * (dynamic)m2[i, j];
                }
            }

            return m3;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.col; j++)
                {
                    if (matrix[i,j].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.col; j++)
                {
                    if (matrix[i, j].Equals(0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CompCheck(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.row == m2.row && m1.col == m2.col)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
