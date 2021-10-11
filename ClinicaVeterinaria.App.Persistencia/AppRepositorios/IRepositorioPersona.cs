using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();

        Persona AddPersona(Persona Persona);

        Persona UpdatePersona(Persona Persona);

        void DeletePersona(int idPersona);

        Persona GetPersona(int idPersona);
    }
}
