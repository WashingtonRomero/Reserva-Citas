using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CancelarCitaModel : PageModel
{
    public void OnGet() { }

    public IActionResult OnPost()
    {
        // Lógica para cancelar la cita.
        return RedirectToPage("/Index");
    }
}

