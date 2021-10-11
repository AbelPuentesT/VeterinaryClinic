using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
   public class RepositorioMascota : IRepositorioMascota
    {       
        private readonly AppContext _appContext;

        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        Mascota IRepositorioMascota.AddMascota(Mascota Mascota)
        {
            var MascotaAdicionado = _appContext.Mascota.Add(Mascota);
            _appContext.SaveChanges();
            return MascotaAdicionado.Entity;
        }

        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var MascotaEncontrado =
                _appContext.Mascota.FirstOrDefault(p => p.Id == idMascota);
            if (MascotaEncontrado == null) return;
            _appContext.Mascota.Remove (MascotaEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascota;
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascota.FirstOrDefault(p => p.Id == idMascota);
        }

        public Mascota UpdateMascota(Mascota Mascota)
        {
            var MascotaEncontrado = _appContext.Mascota.FirstOrDefault(p => p.Id == Mascota.Id);
                if (MascotaEncontrado! == null)
                {
                    MascotaEncontrado.Dueño=Mascota.Dueño;
                    MascotaEncontrado.FechaNacimiento=Mascota.FechaNacimiento;
                    MascotaEncontrado.Nombre=Mascota.Nombre;
                    MascotaEncontrado.TipoDeAnimal=Mascota.TipoDeAnimal;
                    
                    _appContext.SaveChanges();
                    
                }
                return MascotaEncontrado;
        }

    }
}