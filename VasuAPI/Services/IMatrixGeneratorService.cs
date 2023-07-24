using System;

namespace VasuAPI.Services
{
    public interface IMatrixGeneratorService
    {
        int[,] GenerateRandomMatrix(int rows, int cols);
    }
}
