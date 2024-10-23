using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro.Models
{
    public class Jugadores
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]


        public string Nombre { get; set; }
        public string Posicion { get; set; }

        public string Edad { get; set; }
        public Equipo? equipo { get; set; }

        [ForeignKey(nameof(Equipo))]
        public int IdEquipo { get; set; }


    }
}
    