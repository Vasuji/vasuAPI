using System;
using VasuAPI.Models;

namespace VasuAPI.Services
{
    public interface IMatrixGeneratorService
    {
        int[,] GenerateRandomMatrix(int rows, int cols);
    }
}
