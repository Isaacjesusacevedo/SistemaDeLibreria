using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoDatos;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorio;
using SistemaAcademico.Servicios;


namespace SistemaAcademico.Pages.Libros
{
    public class CreateModel : PageModel
    {


        [BindProperty]
        public Libro Libro { get; set; }

        private readonly ServicioLibro servicio;
        public List<Autor> Autores { get; set; }
        public CreateModel()
        {
            IAccesoDatos<Libro> acceso = new AccesoDatosJson<Libro>("Libros");
            IRepositorio<Libro> repo = new RepositorioCrudJson<Libro>(acceso);
            servicio = new ServicioLibro(repo);
        }
        public void OnGet()
        {
            var opciones = new Helpers.OpcionesAutores();
            Autores = opciones.Autor;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Libro);

            return RedirectToPage("Index");
        }
    }
}
