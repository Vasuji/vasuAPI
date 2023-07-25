using System.Threading.Tasks;

namespace VasuAPI.Services
{
    public interface IConductorService
    {
        Task<string> StartWorkflowAsync(string workflowName);
    }
}
