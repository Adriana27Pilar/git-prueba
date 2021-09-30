using System;

namespace  HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
        public int Id { get; set;}
		public string FechaHora { get; set;}
		public string Signo { get; set;}
		public string Valor { get; set;}
        public Paciente Paciente  { set; get;} 

		 
    }

}