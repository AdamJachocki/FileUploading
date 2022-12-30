using Common.Validations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace Common.Models
{
    public class FormData
    {
        [Required(ErrorMessage = "Musisz wybrać plik")]
        [MaxFileSize(1024 * 1024, ErrorMessage = "Plik jest za duży, maksymalna wielkość pliku to 1 MB")]
        public IFormFile? FileToUpload { get; set; }
        [Required(ErrorMessage = "Musisz wpisać wiadomość")]
        public string? Message { get; set; }
    }
}
