using System;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using ClinicaVeterinaria.App.Persistencia.AppRepositorios;

namespace ClinicaVeterinaria.App.Consola
{
    class Program
    {
        private static IRepositorioPersona
            _repoPersona = new RepositorioPersona(new App.Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPersona();
            BuscarPersona(2);
        }

        private static void AddPersona()
        {
            var Persona =
                new Persona {
                    Cedula = 789,
                    Nombre = "Ana Sofia",
                    Apellido = "Puentes Arias",
                    Celular = "+1 9081235786",                    
                    Direccion = "Calle 55 90 90",                    
                    Ciudad = "Puerto Colombia",                    
                };
            _repoPersona.AddPersona (Persona);
        }
        private static void BuscarPersona(int IdPersona) 
        {
            var Persona = _repoPersona.GetPersona (IdPersona);
            Console.WriteLine (Persona.Nombre+" "+Persona.Apellido+" from "+Persona.Ciudad+" Colombia, con direccion "+Persona.Direccion);
        }
        private void DeletePersona()
        {
            
        }
    }
}