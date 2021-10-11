using System.Collections.Generic;
using System.Linq;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public class RepositorioConsulta : IRepositorioConsulta
    {       
        private readonly AppContext _appContext;

        public RepositorioConsulta(AppContext appContext)
        {
            _appContext = appContext;
        }

        Consulta IRepositorioConsulta.AddConsulta(Consulta Consulta)
        {
            var ConsultaAdicionado = _appContext.Consulta.Add(Consulta);
            _appContext.SaveChanges();
            return ConsultaAdicionado.Entity;
        }

        void IRepositorioConsulta.DeleteConsulta(int idConsulta)
        {
            var ConsultaEncontrado =
                _appContext.Consulta.FirstOrDefault(p => p.Id == idConsulta);
            if (ConsultaEncontrado == null) return;
            _appContext.Consulta.Remove (ConsultaEncontrado);
            _appContext.SaveChanges();
            
        }

        public IEnumerable<Consulta> GetAllConsultas()
        {
            return _appContext.Consulta;
        }

        public Consulta GetConsulta(int idConsulta)
        {
            return _appContext.Consulta.FirstOrDefault(p => p.Id == idConsulta);
        }

        public Consulta UpdateConsulta(Consulta Consulta)
        {
            var ConsultaEncontrado = _appContext.Consulta.FirstOrDefault(p => p.Id == Consulta.Id);
                if (ConsultaEncontrado! == null)
                {
                    ConsultaEncontrado.Anotacion=Consulta.Anotacion;
                    ConsultaEncontrado.ListaMedicamentos=Consulta.ListaMedicamentos;
                    ConsultaEncontrado.Veterinario=Consulta.Veterinario;
                    ConsultaEncontrado.Auxiliar=Consulta.Auxiliar;
                    ConsultaEncontrado.Fecha=Consulta.Fecha;
                    _appContext.SaveChanges();
                    
                }
                return ConsultaEncontrado;
        }

    }
}