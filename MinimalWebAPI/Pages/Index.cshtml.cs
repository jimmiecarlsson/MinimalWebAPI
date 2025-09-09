using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MinimalWebAPI.Pages
{
    public class IndexModel : PageModel
    {
        // Property som kan användas i cshtml
        public string Meddelande { get; private set; } = "Tjena ifrån PageModel-klassen!";
    
    // Körs när sidan laddas med GET
        public void OnGet()
        {
            Meddelande = $"Sidan laddades {DateTime.Now}";
        }

    }
}
