using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {       
        private readonly AppContext _appContext;

        public RepositorioHistoriaClinica(AppContext appContext)
        {
            _appContext = appContext;
        }

        HistoriaClinica IRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica HistoriaClinica)
        {
            var HistoriaClinicaAdicionado = _appContext.HistoriaClinica.Add(HistoriaClinica);
            _appContext.SaveChanges();
            return HistoriaClinicaAdicionado.Entity;
        }

        void IRepositorioHistoriaClinica.DeleteHistoriaClinica(int idHistoriaClinica)
        {
            var HistoriaClinicaEncontrado =
                _appContext.HistoriaClinica.FirstOrDefault(p => p.Id == idHistoriaClinica);
            if (HistoriaClinicaEncontrado == null) return;
            _appContext.HistoriaClinica.Remove (HistoriaClinicaEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<HistoriaClinica> GetAllHistoriaClinicas()
        {
            return _appContext.HistoriaClinica;
        }

        public HistoriaClinica GetHistoriaClinica(int idHistoriaClinica)
        {
            return _appContext.HistoriaClinica.FirstOrDefault(p => p.Id == idHistoriaClinica);
        }

        public HistoriaClinica UpdateHistoriaClinica(HistoriaClinica HistoriaClinica)
        {
            var HistoriaClinicaEncontrado = _appContext.HistoriaClinica.FirstOrDefault(p => p.Id == HistoriaClinica.Id);
                if (HistoriaClinicaEncontrado! == null)
                {
                    HistoriaClinicaEncontrado.Historia=HistoriaClinica.Historia;
                    _appContext.SaveChanges();
                    
                }
                return HistoriaClinicaEncontrado;
        }
    }
}