using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro.Models
{
    public class Jugadores
    {
       public int Id { get; set; }
        [MaxLength(100)]

        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public Equipo equipo { get; set; }
        [ForeignKey("nombre")]
        public string Edad { get; set; }


    }
}
