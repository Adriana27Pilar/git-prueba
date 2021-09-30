using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;


namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            //AddPaciente();
            BuscarPaciente(1);

        }
        private static void AddPaciente()
            {
                var Paciente = new Paciente
                {
                    Nombre="Nicolay",
                    Apellido="perez",
                    NumeroTelefono="789123",
                    Genero= Genero.masculino,
                    Direccion="calle 4 # 7 -4",
                    FechaNacimiento= "1990,04,12",
                    Ciudad="manizalez"
                
                };
                _repoPaciente.AddPaciente(Paciente);

            }
            private static void BuscarPaciente (int idPaciente)
            {
                var Paciente = _repoPaciente.GetPaciente(idPaciente);
                Console.WriteLine(Paciente.Nombre+ " "+Paciente.Apellido);
                
            }
        
    }

}