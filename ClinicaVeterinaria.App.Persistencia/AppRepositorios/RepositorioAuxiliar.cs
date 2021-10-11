using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;
using System;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
   public class RepositorioAuxiliar : IRepositorioAuxiliar
    {       
        private readonly AppContext _appContext;

        public RepositorioAuxiliar(AppContext appContext)
        {
            _appContext = appContext;
        }

        Auxiliar IRepositorioAuxiliar.AddAuxiliar(Auxiliar Auxiliar)
        {
            var AuxiliarAdicionado = _appContext.Auxiliar.Add(Auxiliar);
            _appContext.SaveChanges();
            return AuxiliarAdicionado.Entity;
        }

        void IRepositorioAuxiliar.DeleteAuxiliar(int idAuxiliar)
        {
            var AuxiliarEncontrado =
                _appContext.Auxiliar.FirstOrDefault(p => p.Id == idAuxiliar);
            if (AuxiliarEncontrado == null) return;
            _appContext.Auxiliar.Remove (AuxiliarEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<Auxiliar> GetAllAuxiliars()
        {
            return _appContext.Auxiliar;
        }

        public Auxiliar GetAuxiliar(int idAuxiliar)
        {
            return _appContext.Auxiliar.FirstOrDefault(p => p.Id == idAuxiliar);
        }

        public Auxiliar UpdateAuxiliar(Auxiliar Auxiliar)
        {
            var AuxiliarEncontrado = _appContext.Auxiliar.FirstOrDefault(p => p.Id == Auxiliar.Id);
                if (AuxiliarEncontrado! == null)
                {
                    AuxiliarEncontrado.Cedula=Auxiliar.Cedula;
                    AuxiliarEncontrado.Nombre=Auxiliar.Nombre;
                    AuxiliarEncontrado.Apellido=Auxiliar.Apellido;
                    AuxiliarEncontrado.Celular=Auxiliar.Celular;                    
                    AuxiliarEncontrado.Direccion=Auxiliar.Direccion;                    
                    AuxiliarEncontrado.Ciudad=Auxiliar.Ciudad;                     
                    _appContext.SaveChanges();
                    
                }
                return AuxiliarEncontrado;
        }

    }
}