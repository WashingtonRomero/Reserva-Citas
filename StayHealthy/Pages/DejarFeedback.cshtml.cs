using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DejarFeedbackModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public int ConsultaId { get; set; }
    [BindProperty]
    public int Calificacion { get; set; }
    [BindProperty]
    public string Resena { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        // Procesar y guardar el feedback.
        return RedirectToPage("/Reseñas");
    }
}
