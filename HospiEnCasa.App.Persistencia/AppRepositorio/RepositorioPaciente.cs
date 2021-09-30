using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
   
    public class RepositorioPaciente : IRepositorioPaciente
    {
        ///<summary>
        ///Referencua al contexto de Paciente 
        ///</summary>
        private readonly AppContext _appContext;

        ///<summary>
        ///Metodo Constructor para indicar el contexto a utilizar 
        ///Inyeccion de dependecias para indicar el contexto a utilizar 
        ///</summary>

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente Paciente)
        {
            var pacienteAdicionado= _appContext.Pacientes.Add(Paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente Paciente)
        {
           var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p => p.Id == Paciente.Id);
           if (pacienteEncontrado !=null)
            {
                pacienteEncontrado.Nombre=Paciente.Nombre;
                pacienteEncontrado.Apellido=Paciente.Apellido;
                pacienteEncontrado.NumeroTelefono=Paciente.NumeroTelefono;
                pacienteEncontrado.Genero=Paciente.Genero;
                pacienteEncontrado.Direccion=Paciente.Direccion;
                pacienteEncontrado.Ciudad=Paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento=Paciente.FechaNacimiento;
                pacienteEncontrado.FamiliarDesignado=Paciente.FamiliarDesignado;
                pacienteEncontrado.Enfermera=Paciente.Enfermera;
                pacienteEncontrado.Medico=Paciente.Medico;

                _appContext.SaveChanges();
                
                         
           }
           return pacienteEncontrado;
       }
    }
}


