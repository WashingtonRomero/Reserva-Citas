using Microsoft.AspNetCore.Mvc.RazorPages;

public class ReseñasModel : PageModel
{
    public List<Consulta> Consultas { get; set; }

    public void OnGet()
    {
        // Datos simulados.
        Consultas = new List<Consulta>
        {
            new Consulta { Id = 1, FeedbackEnviado = false },
            new Consulta { Id = 2, FeedbackEnviado = true, Calificacion = 4, Resena = "Muy buena atención." }
        };
    }
}

public class Consulta
{
    public int Id { get; set; }
    public bool FeedbackEnviado { get; set; }
    public int Calificacion { get; set; }
    public string Resena { get; set; }
}
