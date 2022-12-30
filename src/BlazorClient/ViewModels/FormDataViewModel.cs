using System.ComponentModel.DataAnnotations;

namespace BlazorClient.ViewModels
{
    public class FormDataViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wybierz plik")]
        [MinLength(1, ErrorMessage = "Plik nie może być pusty")]
        [MaxLength(1024 * 1024, ErrorMessage = "Plik jest za duży")]
        public byte[]? FileContent { get; set; }
        [Required(ErrorMessage = "Musisz wpisać wiadomość")]
        public string? Message { get; set; }
    }
}
