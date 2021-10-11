using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioDueño
    {
        IEnumerable<Dueño> GetAllDueños();

        Dueño AddDueño(Dueño Dueño);

        Dueño UpdateDueño(Dueño Dueño);

        void DeleteDueño(int idDueño);

        Dueño GetDueño(int idDueño);
    }
}
