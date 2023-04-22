

using System.ComponentModel.DataAnnotations;

namespace L02_P02_2020VH602_2020VD602.Models
{
    public class Publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int? usuarioId { get; set; }

    }
}
