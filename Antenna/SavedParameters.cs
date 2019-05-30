
namespace Antenna
{
    class SavedParameters
    {
        public ConnectionParameter connectionParameters { get; set; }
    }

    class ConnectionParameter
    {
        public string IP { get; set; }
        public string Port { get; set; }
        public string NameDB { get; set; }
        public string IPNonCorrect { get; set; }

    }
}
