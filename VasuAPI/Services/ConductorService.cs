using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VasuAPI.Services
{
    public class ConductorService : IConductorService
    {
        private readonly HttpClient _httpClient;

        public ConductorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> StartWorkflowAsync(string workflowName)
        {
            // Adjust this as needed for the correct API endpoint and HTTP method
            var response = await _httpClient.PostAsync(
                $"http://localhost:8080/api/workflow/{workflowName}",
                new StringContent(string.Empty, Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            // Get the ID of the new workflow instance from the response
            var responseContent = await response.Content.ReadAsStringAsync();
            var workflowId = JsonSerializer.Deserialize<string>(responseContent);

            return workflowId;
        }
    }
}
