using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioDueño : IRepositorioDueño
    {       
        private readonly AppContext _appContext;

        public RepositorioDueño(AppContext appContext)
        {
            _appContext = appContext;
        }

        Dueño IRepositorioDueño.AddDueño(Dueño Dueño)
        {
            var DueñoAdicionado = _appContext.Dueño.Add(Dueño);
            _appContext.SaveChanges();
            return DueñoAdicionado.Entity;
        }

        void IRepositorioDueño.DeleteDueño(int idDueño)
        {
            var DueñoEncontrado =
                _appContext.Dueño.FirstOrDefault(p => p.Id == idDueño);
            if (DueñoEncontrado == null) return;
            _appContext.Dueño.Remove (DueñoEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<Dueño> GetAllDueños()
        {
            return _appContext.Dueño;
        }

        public Dueño GetDueño(int idDueño)
        {
            return _appContext.Dueño.FirstOrDefault(p => p.Id == idDueño);
        }

        public Dueño UpdateDueño(Dueño Dueño)
        {
            var DueñoEncontrado = _appContext.Dueño.FirstOrDefault(p => p.Id == Dueño.Id);
                if (DueñoEncontrado! == null)
                {
                    DueñoEncontrado.Cedula=Dueño.Cedula;
                    DueñoEncontrado.Nombre=Dueño.Nombre;
                    DueñoEncontrado.Apellido=Dueño.Apellido;
                    DueñoEncontrado.Celular=Dueño.Celular;                    
                    DueñoEncontrado.Direccion=Dueño.Direccion;                    
                    DueñoEncontrado.Ciudad=Dueño.Ciudad;                                         
                    _appContext.SaveChanges();
                    
                }
                return DueñoEncontrado;
        }
    }
}