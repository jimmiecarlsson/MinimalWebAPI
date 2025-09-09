using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MinimalWebAPI.Pages
{
    public class IndexModel : PageModel
    {
        // Property som kan anv�ndas i cshtml
        public string Meddelande { get; private set; } = "Tjena ifr�n PageModel-klassen!";
    
    // K�rs n�r sidan laddas med GET
        public void OnGet()
        {
            Meddelande = $"Sidan laddades {DateTime.Now}";
        }

    }
}
