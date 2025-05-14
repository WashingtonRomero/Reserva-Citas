using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DoctorDetailsModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public int Id { get; set; }

    public DoctorDetail Doctor { get; set; }

    public void OnGet()
    {
        // Datos simulados; normalmente se consultarían de una base de datos según el Id.
        Doctor = new DoctorDetail
        {
            Id = Id,
            Nombre = "Dr. Juan Perez",
            Especialidad = "Cardiología",
            ImagenUrl = "/imagenes/doctor.jpeg",  // Ruta correcta de la imagen
          Descripcion = "Experto en cardiología moderna.",
            Ubicacion = "Clínica Central"
        };
    }
}

public class DoctorDetail
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Especialidad { get; set; }
    public string ImagenUrl { get; set; }
    public string Descripcion { get; set; }
    public string Ubicacion { get; set; }
}
