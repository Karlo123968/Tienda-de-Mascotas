using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Usuarios.Modelos;

namespace Usuarios.Pages
{
    public class UsuariosModel : PageModel
    {
        private readonly DBContext _context;

        public List<Mascota> Mascotas { get; set; } = new List<Mascota>();

        [BindProperty]
        public Mascota? NuevoUsuario { get; set; }

        [BindProperty]
        public Mascota? MascotaEditar { get; set; }

        public UsuariosModel(DBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Mascotas = _context.Mascotas.ToList();
        }

        public IActionResult OnPost()
        {
            _context.Mascotas.Add(NuevoUsuario);
            _context.SaveChanges();
            return RedirectToPage();
        }

        public IActionResult OnGetEditar(int id)
        {
            MascotaEditar = _context.Mascotas.Find(id);
            return Page();
        }

        public IActionResult OnPostEditar()
        {
            if (MascotaEditar != null)
            {
                _context.Mascotas.Update(MascotaEditar);
                _context.SaveChanges();
            }

            return RedirectToPage();
        }

        public IActionResult OnPostEliminar(int id)
        {
            var mascota = _context.Mascotas.Find(id);

            if (mascota != null)
            {
                _context.Mascotas.Remove(mascota);
                _context.SaveChanges();
            }

            return RedirectToPage();
        }







    }
}