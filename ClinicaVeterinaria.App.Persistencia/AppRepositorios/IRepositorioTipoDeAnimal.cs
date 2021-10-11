using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoDeAnimal
    {
        IEnumerable<TipoDeAnimal> GetAllTipoDeAnimals();

        TipoDeAnimal AddTipoDeAnimal(TipoDeAnimal TipoDeAnimal);

        TipoDeAnimal UpdateTipoDeAnimal(TipoDeAnimal TipoDeAnimal);

        void DeleteTipoDeAnimal(int idTipoDeAnimal);

        TipoDeAnimal GetTipoDeAnimal(int idTipoDeAnimal);
    }
}
