using CsvHelper;
using System.Globalization;
using VasuAPI.Models;


namespace VasuAPI.Services 
{

    public class CsvDataService
    {
        private readonly List<User> _data;

        public CsvDataService(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            _data = csv.GetRecords<User>().ToList();
        }

        public List<User> GetData(int count)
        {
            return _data.Take(count).ToList();
        }
    }


}


