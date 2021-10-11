namespace ClinicaVeterinaria.App.Dominio
{
    public class Consulta
    {
        public int Id { get; set; }

        public string Anotacion { get; set; }

        public string ListaMedicamentos { get; set; }

        public Veterinario Veterinario { get; set; }

        public Auxiliar Auxiliar { get; set; }

        public string Fecha { get; set; }
    }
}
