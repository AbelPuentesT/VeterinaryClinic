using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();

        Veterinario AddVeterinario(Veterinario Veterinario);

        Veterinario UpdateVeterinario(Veterinario Veterinario);

        void DeleteVeterinario(int idVeterinario);

        Veterinario GetVeterinario(int idVeterinario);
    }
}
