using System;
using VasuAPI.Models;

namespace VasuAPI.Services
{
    public class MatrixGeneratorService : IMatrixGeneratorService
    {
        public int[,] GenerateRandomMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Random.Shared.Next(1, 100); // Random numbers between 1 and 100
                }
            }
            return matrix;
        }
    }
}
