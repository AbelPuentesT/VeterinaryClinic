using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAdministrador
    {
        IEnumerable<Administrador> GetAllAdministradors();

        Administrador AddAdministrador(Administrador Administrador);

        Administrador UpdateAdministrador(Administrador Administrador);

        void DeleteAdministrador(int idAdministrador);

        Administrador GetAdministrador(int idAdministrador);
    }
}