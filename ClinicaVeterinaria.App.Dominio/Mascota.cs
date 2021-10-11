namespace ClinicaVeterinaria.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }

        public Dueño Dueño { get; set; }

        public string FechaNacimiento { get; set; }

        public string Nombre { get; set; }

        public TipoDeAnimal TipoDeAnimal { get; set; }
    }
}
