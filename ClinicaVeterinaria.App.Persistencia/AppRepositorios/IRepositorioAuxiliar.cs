using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> GetAllAuxiliars();

        Auxiliar AddAuxiliar(Auxiliar Auxiliar);

        Auxiliar UpdateAuxiliar(Auxiliar Auxiliar);

        void DeleteAuxiliar(int idAuxiliar);

        Auxiliar GetAuxiliar(int idAuxiliar);
    }
}