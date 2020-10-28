using Microsoft.OpenApi.Models;

namespace FrejyaBåtHuset_WebAPI_Backend
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}