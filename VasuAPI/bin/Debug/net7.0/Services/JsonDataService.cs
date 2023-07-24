using Newtonsoft.Json;
using VasuAPI.Services;

using System.Collections.Generic;
using System.IO;


namespace VasuAPI.Services
{
    public interface IJsonDataService
    {
        List<User> Users { get; }
    }

    public class JsonDataService : IJsonDataService
    {
        private readonly string _filePath;

        public JsonDataService(string filePath)
        {
            _filePath = filePath;
        }

        public List<User> Users
        {
            get
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
    }
}
