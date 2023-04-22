using System.ComponentModel.DataAnnotations;

namespace L02_P02_2020VH602_2020VD602.Models
{
    public class comentarios
    {
        [Key]
        public int cometarioId { get; set; }
        public int? publicacionId { get; set; }
        public string? comentario { get; set; }
        public int? usuarioId { get; set; }
    }
}
