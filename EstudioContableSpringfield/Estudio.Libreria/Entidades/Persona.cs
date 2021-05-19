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
        private int _dni;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }

        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
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
