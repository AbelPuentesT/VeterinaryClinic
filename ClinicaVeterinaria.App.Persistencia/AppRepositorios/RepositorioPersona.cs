using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona : IRepositorioPersona
    {       
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona Persona)
        {
            var PersonaAdicionado = _appContext.Persona.Add(Persona);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;
        }

        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var PersonaEncontrado =
                _appContext.Persona.FirstOrDefault(p => p.Id == idPersona);
            if (PersonaEncontrado == null) return;
            _appContext.Persona.Remove (PersonaEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<Persona> GetAllPersonas()
        {
            return _appContext.Persona;
        }

        public Persona GetPersona(int idPersona)
        {
            return _appContext.Persona.FirstOrDefault(p => p.Id == idPersona);
        }

        public Persona UpdatePersona(Persona Persona)
        {
            var PersonaEncontrado = _appContext.Persona.FirstOrDefault(p => p.Id == Persona.Id);
                if (PersonaEncontrado! == null)
                {
                    PersonaEncontrado.Cedula=Persona.Cedula;
                    PersonaEncontrado.Nombre=Persona.Nombre;
                    PersonaEncontrado.Apellido=Persona.Apellido;
                    PersonaEncontrado.Celular=Persona.Celular;                    
                    PersonaEncontrado.Direccion=Persona.Direccion;                    
                    PersonaEncontrado.Ciudad=Persona.Ciudad;                     
                    _appContext.SaveChanges();
                    
                }
                return PersonaEncontrado;
        }
    }
}
