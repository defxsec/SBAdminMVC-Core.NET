using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBAdminMVC_Core.NET.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [DisplayName("Nombre de cliente")]
        [MaxLength(20)]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Column(TypeName = "nvarchar(20)")]
        public string Nombres { get; set; }

        [DisplayName("Apellidos de cliente")]
        [MaxLength(20)]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Column(TypeName = "nvarchar(20)")]
        public string Apellidos { get; set; }

        [DisplayName("Celular de cliente")]
        [MaxLength(8, ErrorMessage = "Maximo de numeros 8.")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Column(TypeName = "nvarchar(8)")]
        public string Celular { get; set; }
    }
}
