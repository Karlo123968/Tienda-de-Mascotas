using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Usuarios.Modelos
{
    public class Mascota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Nombre { get; set; }
        public string? Tipo { get; set; } // perro, gato, etc
        public string? Raza { get; set; }
        public int Edad { get; set; }
        public string? Dueño { get; set; }
        public string? Telefono { get; set; }
    }
}