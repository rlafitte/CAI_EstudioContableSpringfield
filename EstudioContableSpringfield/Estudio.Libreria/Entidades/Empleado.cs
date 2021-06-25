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
        private Int64 _cuil;
        private int _idCategoria;
        private int _idEmpresa;
        private DateTime _fechaAlta;
        private Categoria _categoria;

        private Empresa _empresa;
        public Empresa Empresa { get => _empresa; set => _empresa = value; }


        public Categoria Categoria { get => _categoria; set => _categoria = value; }


        [DataMember(Name = "id")]
        public int Legajo { get => this._legajo; set => this._legajo = value; }

        [DataMember(Name = "cuil")]
        public Int64 Cuil { get => _cuil; set => this._cuil = value; }

        [DataMember(Name = "idEmpresa")]
        public int IdEmpresa { get => _idEmpresa; set => this._idEmpresa = value; }

        [DataMember(Name = "idCategoria")]
        public int IdCategoria { get => _idCategoria; set => this._idCategoria = value; }

        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => _fechaAlta; set => this._fechaAlta = value; }

        public Empleado(string nombre, string apellido, DateTime fechaNac, Int64 cuil, int idEmpresa, int idCategoria) : base(nombre, apellido, fechaNac)
        {
            this._cuil = cuil;
            this._idEmpresa = idEmpresa;
            this._idCategoria = idCategoria;
            this._fechaAlta = DateTime.Now;
        }
        public Empleado()
        {

        }

        public Empleado(string v)
        {
            this.Nombre = v;
            this.FechaNacimiento = System.DateTime.Now.ToString("yyyy-MM-dd");
        }

        public override string ToString()
        {
            return $"{this._cuil} | {base.ToString()}";
        }

    }
}
