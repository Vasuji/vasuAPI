using System;
using VasuAPI.Models;

namespace VasuAPI.Services
{
    public interface IRandomNumberService
    {
        int GenerateRandomNumber(int min, int max);
    }

    public class RandomNumberService : IRandomNumberService
    {
        public int GenerateRandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
