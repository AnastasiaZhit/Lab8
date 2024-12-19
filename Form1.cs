using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateMatrix(MatrixGenerator generator)
        {
            // Генерация матрицы
            int[,] matrix = generator.GenerateMatrix(3, 3); // 3x3 матрица.

            // Вывод матрицы в DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridView1.Columns.Add($"Col{i}", $"Колонка {i + 1}");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            // Вычисление характеристик
            int diagonalSum = generator.CalculateDiagonalSum(matrix);
            int totalSum = generator.CalculateTotalSum(matrix);
            int maxValue = generator.GetMaxValue(matrix);
            int minValue = generator.GetMinValue(matrix);

            // Вывод характеристик на экран
            label1.Text = $"Сумма диагонали: {diagonalSum}, Сумма всех элементов: {totalSum}\n" +
                               $"Макс: {maxValue}, Мин: {minValue}";
        }

        private void GenerateMatrix(object sender, EventArgs e)
        {

        }
    }

    // Шаблонный метод

    public abstract class MatrixGenerator
    {
        public abstract int[,] GenerateMatrix(int rows, int cols);

        public int CalculateDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        public int CalculateTotalSum(int[,] matrix)
        {
            return matrix.Cast<int>().Sum();
        }

        public int GetMaxValue(int[,] matrix)
        {
            return matrix.Cast<int>().Max();
        }

        public int GetMinValue(int[,] matrix)
        {
            return matrix.Cast<int>().Min();
        }
    }

    // Генерация единичной матрицы по диагонали
    public class DiagonalOnesGenerator : MatrixGenerator
    {
        public override int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < Math.Min(rows, cols); i++)
            {
                matrix[i, i] = 1;
            }
            return matrix;
        }
    }

    // Генерация нулевой матрицы
    public class ZeroMatrixGenerator : MatrixGenerator
    {
        public override int[,] GenerateMatrix(int rows, int cols)
        {
            return new int[rows, cols]; // Все элементы автоматически инициализируются 0.
        }
    }

    // Генерация случайной матрицы
    public class RandomMatrixGenerator : MatrixGenerator
    {
        public override int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 100); // Случайные числа от 0 до 99.
                }
            }
            return matrix;
        }
    }

    // Генерация случайной матрицы по диагонали
    public class RandomDiagonalGenerator : MatrixGenerator
    {
        public override int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random random = new Random();
            for (int i = 0; i < Math.Min(rows, cols); i++)
            {
                matrix[i, i] = random.Next(0, 100);
            }
            return matrix;
        }
    }
    // Генерация матрицы по спирали
    public class SnakeMatrixGenerator : MatrixGenerator
    {
        public override int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols]; // Матрица, которую будем заполнять
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = i % 2 == 1 ? i * cols + j + 1 : rows * (i + 1) - j;
                }
            }

            return matrix;
        }
    }
}