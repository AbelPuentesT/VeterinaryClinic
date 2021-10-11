using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
              
        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario Veterinario)
        {
            var VeterinarioAdicionado = _appContext.Veterinario.Add(Veterinario);
            _appContext.SaveChanges();
            return VeterinarioAdicionado.Entity;
        }

        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrado =
                _appContext.Veterinario.FirstOrDefault(p => p.Id == idVeterinario);
            if (VeterinarioEncontrado == null) return;
            _appContext.Veterinario.Remove (VeterinarioEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return _appContext.Veterinario;
        }

        public Veterinario GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinario.FirstOrDefault(p => p.Id == idVeterinario);
        }

        public Veterinario UpdateVeterinario(Veterinario Veterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinario.FirstOrDefault(p => p.Id == Veterinario.Id);
                if (VeterinarioEncontrado! == null)
                {
                    VeterinarioEncontrado.Cedula=Veterinario.Cedula;
                    VeterinarioEncontrado.Nombre=Veterinario.Nombre;
                    VeterinarioEncontrado.Apellido=Veterinario.Apellido;
                    VeterinarioEncontrado.Celular=Veterinario.Celular;                    
                    VeterinarioEncontrado.Direccion=Veterinario.Direccion;                    
                    VeterinarioEncontrado.Ciudad=Veterinario.Ciudad;
                    _appContext.SaveChanges();
                    
                }
                return VeterinarioEncontrado;
        }

    }
}