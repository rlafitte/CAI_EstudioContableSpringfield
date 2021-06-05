using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades.Entidades
{
    [DataContract]

    public class Empleado : Persona
    {
        private int _legajo;
        private string _domicilio;
        private int _cuil;
        private Empresa _empresa;
        private Categoria _categoria;
        private DateTime _fechaAlta;

        [DataMember(Name = "id")]
        public int Legajo { get => this._legajo; }
        public Categoria Categoria { get => _categoria; }
        [DataMember(Name = "cuil")]
        public int Cuil { get => _cuil; }
        [DataMember(Name = "idEmpresa")]
        public int IdEmpresa { get => _empresa.Id; }
        [DataMember(Name = "idCategoria")]
        public int IdCategoria { get => _categoria.Id; }
        [DataMember(Name = "fechaAlta")]

        public DateTime FechaAlta { get => _fechaAlta;  }

        public Empleado(string nombre, string apellido, int legajo, string domicilio, int cuil, Empresa empresa, Categoria categoria, DateTime fechaNac) : base(nombre, apellido, fechaNac)
        {
            this._legajo = legajo;
            this._domicilio = domicilio;
            this._cuil = cuil;
            this._empresa = empresa;
            this._categoria = categoria;
            this._fechaAlta = DateTime.Now;
        }
        public Empleado()
        {

        }

        public override string ToString()
        {
            return $"{this._cuil} | {base.ToString()}";
        }

    }
}
