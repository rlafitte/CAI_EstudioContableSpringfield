using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades.Entidades
{
    [DataContract]
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        [DataMember(Name = "nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember(Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }
        [DataMember(Name = "fechaNacimiento")]
        public DateTime FechaNacimiento { get => _fechaNacimiento; }

        public Persona(string nombre, string apellido, DateTime fechaNac)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._fechaNacimiento = fechaNac;
        }
        public Persona()
        {

        }

        public override string ToString()
        {
            return $"{ this.Apellido}, {this.Nombre}";
        }
    }
}
