using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RegistroModel : PageModel
{
    [BindProperty]
    public string UserType { get; set; }
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Nombre { get; set; }
    [BindProperty]
    public string Telefono { get; set; }
    [BindProperty]
    public string Password { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        // Aquí se procesarían los datos del registro (validación y almacenamiento).
        return RedirectToPage("/Index");
    }
}
