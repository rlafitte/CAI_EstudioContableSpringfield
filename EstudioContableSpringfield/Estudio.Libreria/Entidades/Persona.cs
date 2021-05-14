using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _documento;
        private DateTime _fechaNacimiento;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Documento { get => _documento; set => _documento = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public Persona(string nombre, string apellido, int documento, DateTime fehcaNac)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Documento = documento;
            this.FechaNacimiento = fehcaNac;
        }
        public Persona()
        {

        }

        public virtual string ToStringPersona()
        {
            return $"Apellido: { this.Apellido}, Nombre: {this.Nombre}, N° de documento: {this.Documento}";
        }
    }
}
