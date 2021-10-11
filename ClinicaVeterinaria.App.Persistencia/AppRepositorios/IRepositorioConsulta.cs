using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioConsulta
    {
        IEnumerable<Consulta> GetAllConsultas();

        Consulta AddConsulta(Consulta Consulta);

        Consulta UpdateConsulta(Consulta Consulta);

        void DeleteConsulta(int idConsulta);

        Consulta GetConsulta(int idConsulta);

    }
}