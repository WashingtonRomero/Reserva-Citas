using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Password { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        // Aquí se validan las credenciales del usuario.
        return RedirectToPage("/Index");
    }
}
