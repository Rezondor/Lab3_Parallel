using Lab3_Core;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        delegate int[,] Multiply(int [,] matrix1, int[,] matrix2);
        static void Main(string[] args)
        {
            int[,] matrix1 = MatrixHelper.FillingMatrix(500,500);
            int[,] matrix2 = MatrixHelper.FillingMatrix(500,500);
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                Stopwatch stopWatch = new Stopwatch();
                Multiply[] multiplies ={
                    MatrixHelper.MultiplyMatrix_Standart,
                    MatrixHelper.MultiplyMatrix_1,
                    MatrixHelper.MultiplyMatrix_2,
                    MatrixHelper.MultiplyMatrix_Only2,
                    MatrixHelper.MultiplyMatrix_Only3
                };
                string[] name =
                {
                    "Результат умножения двух матриц (Последовательно)",
                    "Результат умножения двух матриц (Параллельно только для каждой строки)",
                    "Результат умножения двух матриц (Параллельно для строки и элемента)",
                    "Результат умножения двух матриц (Параллельно только для каждого элемента)",
                    "Результат умножения двух матриц (Параллельно только для нахождения суммы элементов)"
                };


                
                Console.WriteLine("Матрицы созданы");
                for (int i = 0; i < multiplies.Length; i++)
                {
                    stopWatch.Reset();
                    stopWatch.Start();
                    int[,] MultiplyMatrix = multiplies[i](matrix1, matrix2);
                    stopWatch.Stop();
                    Console.WriteLine(name[i]);
                    Console.WriteLine(stopWatch.Elapsed);
                }
                
            }
            else
                Console.WriteLine("Неверный размер матриц");
            
        }
    }
    
}

