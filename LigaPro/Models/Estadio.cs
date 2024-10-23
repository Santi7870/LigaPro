using System.ComponentModel.DataAnnotations;

namespace LigaPro.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}
