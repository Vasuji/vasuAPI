
namespace VasuAPI.Services
{
    public class TrafficDetail
    {
        public DateTime Time { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Volume { get; set; }
    }
}