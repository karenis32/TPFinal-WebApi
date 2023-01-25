using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_FINAL_WEB_API.Models
{
    [Table ("Ciudad")]
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [ForeignKey("IdProvincia")]
        public int IdProvincia { get; set; }

        public Provincia provincia { get; set; }
    }
}
