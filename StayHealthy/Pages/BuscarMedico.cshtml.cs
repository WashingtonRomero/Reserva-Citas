using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class BuscarMedicoModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string SearchTerm { get; set; }

    public List<Doctor> Doctores { get; set; }

    public void OnGet()
    {
        // Datos simulados; en un escenario real estos datos se obtendrían de una base de datos.
        var allDoctors = new List<Doctor>
        {
            new Doctor { Id = 1, Nombre = "Dr. Juan Perez", Especialidad = "Cardiología", ImagenUrl="~/images/doc1.png" },
            new Doctor { Id = 2, Nombre = "Dra. Maria Gomez", Especialidad = "Neurología", ImagenUrl="~/images/doc2.png" }
        };

        if (string.IsNullOrWhiteSpace(SearchTerm))
        {
            Doctores = allDoctors;
        }
        else
        {
            Doctores = allDoctors.Where(d =>
                d.Nombre.ToLower().Contains(SearchTerm.ToLower()) ||
                d.Especialidad.ToLower().Contains(SearchTerm.ToLower())
            ).ToList();
        }
    }
}

public class Doctor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Especialidad { get; set; }
    public string ImagenUrl { get; set; }
}

