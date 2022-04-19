using System;
using System.Threading.Tasks;

namespace Lab3_Core
{
    internal class MatrixHelper
    {
                          
        static public int[,] FillingMatrix(int height, int width) 
        {
        int[,] Matrix = new int[height, width];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = 3 * i + j;
                }
            }
            return Matrix;
        }
        static public void Print(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write(" ");
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j],-5}| ");
                }
                Console.WriteLine();
            }
        }
        static public int[,] MultiplyMatrix_Standart(int[,] matrix1, int[,] matrix2)
        {
            int[,] MultiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < MultiplyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < MultiplyMatrix.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {

                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    MultiplyMatrix[i, j] = sum;
                }
            }

            return MultiplyMatrix;
        }
        static public int[,] MultiplyMatrix_1(int[,] matrix1, int[,] matrix2)
        {
            int[,] MultiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            Parallel.For(0, MultiplyMatrix.GetLength(0), i =>
             {
                 for (int j = 0; j < MultiplyMatrix.GetLength(1); j++)
                 {
                     int sum = 0;
                     for (int k = 0; k < matrix1.GetLength(1); k++)
                     {

                         sum += matrix1[i, k] * matrix2[k, j];
                     }
                     MultiplyMatrix[i, j] = sum;
                 }
             });

            return MultiplyMatrix;
        }
       
        static public int[,] MultiplyMatrix_2(int[,] matrix1, int[,] matrix2)
        {
            int[,] MultiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            Parallel.For(0, MultiplyMatrix.GetLength(0), i =>
            {
                Parallel.For(0, MultiplyMatrix.GetLength(1), j =>
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {

                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    MultiplyMatrix[i, j] = sum;
                });
            });

            return MultiplyMatrix;
        }
        static public int[,] MultiplyMatrix_Only2(int[,] matrix1, int[,] matrix2)
        {
            int[,] MultiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < MultiplyMatrix.GetLength(0); i++)
            {
                Parallel.For(0, MultiplyMatrix.GetLength(1), j =>
                {
                    int sum = 0;

                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {

                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    MultiplyMatrix[i, j] = sum;
                });
            }

            return MultiplyMatrix;
        }
        static public int[,] MultiplyMatrix_Only3(int[,] matrix1, int[,] matrix2)
        {
            int[,] MultiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < MultiplyMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < MultiplyMatrix.GetLength(1);j++)
                {
                    int sum = 0;

                    Parallel.For(0, matrix1.GetLength(1), k =>
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    });

                    MultiplyMatrix[i, j] = sum;
                }
            }
            return MultiplyMatrix;
        }
    }
}
