using Lab3_Core;
using System;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = MatrixHelper.FillingMatrix(5,3);
            int[,] matrix2 = MatrixHelper.FillingMatrix(3,4);
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                int[,] MultiplyMatrix = MatrixHelper.MultiplyMatrix_Standart(matrix1, matrix2);
                int[,] MultiplyMatrix1 = MatrixHelper.MultiplyMatrix_1(matrix1, matrix2);
                int[,] MultiplyMatrix2 = MatrixHelper.MultiplyMatrix_2(matrix1, matrix2);
                int[,] MultiplyMatrix3 = MatrixHelper.MultiplyMatrix_3(matrix1, matrix2);
                int[,] MultiplyMatrix_Only2 = MatrixHelper.MultiplyMatrix_Only2(matrix1, matrix2);
                int[,] MultiplyMatrix_Only3 = MatrixHelper.MultiplyMatrix_Only3(matrix1, matrix2);

                Console.WriteLine("1 матрица");
                MatrixHelper.Print(matrix1);
                Console.WriteLine("2 матрица");
                MatrixHelper.Print(matrix2);
                Console.WriteLine("Результат умножения двух матриц (Последовательно)");
                MatrixHelper.Print(MultiplyMatrix);
                Console.WriteLine("Результат умножения двух матриц (Параллельно только для каждой строки)");
                MatrixHelper.Print(MultiplyMatrix1);
                Console.WriteLine("Результат умножения двух матриц (Параллельно для строки и элемента)");
                MatrixHelper.Print(MultiplyMatrix2);
                Console.WriteLine("Результат умножения двух матриц (Параллельно для строки, элемента и нахождения суммы для элемента)");
                MatrixHelper.Print(MultiplyMatrix3);
                Console.WriteLine("Результат умножения двух матриц (Параллельно только для каждого элемента)");
                MatrixHelper.Print(MultiplyMatrix_Only2);
                Console.WriteLine("Результат умножения двух матриц (Параллельно только для нахождения суммы элементов)");
                MatrixHelper.Print(MultiplyMatrix_Only3);
            }
            else
                Console.WriteLine("Неверный размер матриц");
            
        }
    }
    
}

