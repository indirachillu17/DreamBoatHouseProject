using Microsoft.OpenApi.Models;

namespace FrejyaBåtHuset_WebAPI_Backend
{
    internal class Info : OpenApiInfo
    {
        public new string Title { get; set; }
        public new string Version { get; set; }
    }
}