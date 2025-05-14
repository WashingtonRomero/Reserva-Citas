using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ReservarCitaModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public int Id { get; set; } // Id del doctor

    public DoctorDetail Doctor { get; set; }

    [BindProperty]
    public DateTime Fecha { get; set; }

    [BindProperty]
    public TimeSpan Hora { get; set; }

    public void OnGet()
    {
        // Simula la obtención de datos del doctor según su Id.
        Doctor = new DoctorDetail
        {
            Id = Id,
            Nombre = "Dr. Juan Perez",
            Especialidad = "Cardiología",
            ImagenUrl = "~/images/doc1.png",
            Descripcion = "Experto en cardiología moderna.",
            Ubicacion = "Clínica Central"
        };
    }

    public IActionResult OnPost()
    {
        // Aquí se procesaría el almacenamiento de la reserva.
        return RedirectToPage("/Index");
    }
}

