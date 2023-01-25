using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_FINAL_WEB_API.Models
{
    [Table("Provincia")]
    public class Provincia
    {
        [Key]
        public int IdProvincia { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        public List<Ciudad> ciudades { get; set; }
    }
}
