using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VasuAPI.Services;

namespace VasuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatrixController : ControllerBase
    {
        private readonly ILogger<MatrixController> _logger;
        private readonly IMatrixGeneratorService _matrixGeneratorService;

        public MatrixController(ILogger<MatrixController> logger, IMatrixGeneratorService matrixGeneratorService)
        {
            _logger = logger;
            _matrixGeneratorService = matrixGeneratorService;
        }

        [HttpGet]
        [Route("GetRandomMatrixSum", Name = "GetRandomMatrixSum")]
        public int[,] Get()
        {
            var matrix1 = _matrixGeneratorService.GenerateRandomMatrix(10, 10);
            var matrix2 = _matrixGeneratorService.GenerateRandomMatrix(10, 10);

            var resultMatrix = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return resultMatrix;
        }
    }
}
