
using System.ComponentModel.DataAnnotations;

namespace L02_P02_2020VH602_2020VD602.Models
{
    public class Usuarios
    {
        [Key]
        public int usuarioId { get; set; }
        public int? rolId { get; set; }
        public string nombreUsuario { get; set;}
        public string clave { get; set;}
        public string nombre { get; set; }
        public String apellido { get; set; }

    }
}
