namespace LigaPro.Models
{
    public class Estadio
    {
        public int Id { get; set; }
        [MaxLenght(150)]
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}
