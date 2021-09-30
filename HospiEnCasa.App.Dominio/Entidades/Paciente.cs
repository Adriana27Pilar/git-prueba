using System;

namespace  HospiEnCasa.App.Dominio
{
    public class Paciente : Persona

    {
       
        
		public string Direccion { get; set;}
		public string FechaNacimiento { get; set;}
		public string Ciudad { get; set;}

        public FamiliarDesignado FamiliarDesignado{ set; get;} 
        public Medico Medico{ set; get;} 
        public Enfermera Enfermera { set; get;} 
        

		
    }

}