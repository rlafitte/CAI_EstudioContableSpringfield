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
        private int _tipoDocumento;
        private int _documento;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int TipoDocumento { get => _tipoDocumento; set => _tipoDocumento = value; }
        public int Documento { get => _documento; set => _documento = value; }
        public Persona(string s1, string s2, int i1, int i2)
        {
            this.Nombre = s1;
            this.Apellido = s2;
            this.TipoDocumento = i1;
            this.Documento = i2;
        }
        public Persona()
        {

        }

        public virtual string ToStringPersona()
        {
            return $"Apellido: { this.Apellido}, Nombre: {this.Nombre}, Tipo y N° de documento:{this.TipoDocumento} - {this.Documento}";
        }
    }
}
