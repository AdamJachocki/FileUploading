using Microsoft.AspNetCore.Http;

namespace Common.Models
{
    public class WebApiFormData
    {
        public IFormFile File { get; set; }
        public string Message { get; set; }
    }
}
