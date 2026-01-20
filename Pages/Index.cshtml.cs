using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ServicioLibro _servicioLibro;
        private readonly ServicioAutor _servicioAutor;

        public List<Libro> Libros { get; set; } = new();
        public List<Autor> Autores { get; set; } = new();

        public IndexModel(
            ServicioLibro servicioLibro,
            ServicioAutor servicioAutor)
        {
            _servicioLibro = servicioLibro;
            _servicioAutor = servicioAutor;
        }

        public void OnGet()
        {
            Libros = _servicioLibro.ObtenerDatos();
            Autores = _servicioAutor.ObtenerDatos();
        }

        public string ObtenerNombreAutor(string autorId)
        {
            var autor = Autores.FirstOrDefault(a => a.Id.ToString() == autorId);
            return autor?.Name ?? "Autor desconocido";
        }
    }
}
