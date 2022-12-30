using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public FormData Data { get; set; } = new();    

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            EnsureFilesDirExists();
            var secureFileName = Path.GetFileName(Data.FileToUpload.FileName);
            var filePath = Path.Combine("files", secureFileName);
            
            using var stream = new FileStream(filePath, FileMode.Create);
            await Data.FileToUpload.CopyToAsync(stream);

            return Page();
        }

        private void EnsureFilesDirExists()
        {
            if (!Directory.Exists("files"))
                Directory.CreateDirectory("files");
        }
    }
}