
using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios

{
   public class RepositorioAdministrador : IRepositorioAdministrador
    {       
        private readonly AppContext _appContext;

        public RepositorioAdministrador(AppContext appContext)
        {
            _appContext = appContext;
        }

        Administrador IRepositorioAdministrador.AddAdministrador(Administrador Administrador)
        {
            var AdministradorAdicionado = _appContext.Administrador.Add(Administrador);
            _appContext.SaveChanges();
            return AdministradorAdicionado.Entity;
        }

        void IRepositorioAdministrador.DeleteAdministrador(int idAdministrador)
        {
            var AdministradorEncontrado =
                _appContext.Administrador.FirstOrDefault(p => p.Id == idAdministrador);
            if (AdministradorEncontrado == null) return;
            _appContext.Administrador.Remove (AdministradorEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<Administrador> GetAllAdministradors()
        {
            return _appContext.Administrador;
        }

        public Administrador GetAdministrador(int idAdministrador)
        {
            return _appContext.Administrador.FirstOrDefault(p => p.Id == idAdministrador);
        }

        public Administrador UpdateAdministrador(Administrador Administrador)
        {
            var AdministradorEncontrado = _appContext.Administrador.FirstOrDefault(p => p.Id == Administrador.Id);
                if (AdministradorEncontrado! == null)
                {
                    AdministradorEncontrado.Cedula=Administrador.Cedula;
                    AdministradorEncontrado.Nombre=Administrador.Nombre;
                    AdministradorEncontrado.Apellido=Administrador.Apellido;
                    AdministradorEncontrado.Celular=Administrador.Celular;                    
                    AdministradorEncontrado.Direccion=Administrador.Direccion;                    
                    AdministradorEncontrado.Ciudad=Administrador.Ciudad;                     
                    _appContext.SaveChanges();
                    
                }
                return AdministradorEncontrado;
        }
    }
}