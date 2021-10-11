using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();

        Mascota AddMascota(Mascota Mascota);

        Mascota UpdateMascota(Mascota Mascota);

        void DeleteMascota(int idMascota);

        Mascota GetMascota(int idMascota);
         
    }
}