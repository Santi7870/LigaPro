using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro.Models
{
    public class Jugadores
    {
        [key]
        public int Id { get; set; }
        [MaxLenght(150)]

        public string Nombre { get; set; }
        [EmailAddress]
        public string Posicion { get; set; }
        public Equipo equipo { get; set; }

        [ForeignKey("equipo")]
        public string Edad { get; set; }
        

        public int IdEquipo { get; set; }


    }
}
    