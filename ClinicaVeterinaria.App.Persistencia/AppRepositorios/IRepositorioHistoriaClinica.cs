using System.Collections.Generic;
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistoriaClinica
    {
        IEnumerable<HistoriaClinica> GetAllHistoriaClinicas();

        HistoriaClinica AddHistoriaClinica(HistoriaClinica HistoriaClinica);

        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica HistoriaClinica);

        void DeleteHistoriaClinica(int idHistoriaClinica);

        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);
         
    }
}