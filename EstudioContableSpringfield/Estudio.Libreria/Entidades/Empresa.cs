using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio.Entidades.Entidades
{
    [DataContract]
    public class Empresa
    {
        private string _nombre;
        private long _cuit;
        private DateTime _fechaAlta;
        private string _domicilio;
        private int _usuario;
        private int _id;

        private List<Empleado> _empleados;

        [DataMember(Name = "razonSocial")]
        public string RazonSocial { get => this._nombre; set => this._nombre = value; }
        [DataMember(Name = "cuit")]
        public long Cuit { get => _cuit; }
        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => _fechaAlta; }
        [DataMember(Name = "usuario")]
        public int Usuario { get => _usuario;  }
        [DataMember(Name = "id")]
        public int Id { get => _id; }
        [DataMember(Name = "domicilio")]
        public string Domicilio { get => _domicilio; }

        public List<Empleado> Empleados { get => this._empleados; set => this.Empleados = value; }

        public Empresa(string nombre, long cuit, string domicilio)
        {
            this._nombre = nombre;
            this._cuit = cuit;
            this._domicilio = domicilio;
            this._empleados = new List<Empleado>();
            this._usuario = 898049;
        }

        public Empresa()
        {

        }

        public override string ToString()
        {
            return $"{this._nombre}";
        }
        public void ListaEmpleados(ListBox lst)
        {
            string str = "";
            foreach(Empleado _e in _empleados)
            {
                lst.Items.Add(_e.ToString() + Environment.NewLine);
                //str += _e.ToString() + ";";
            }
            return;
        }
        
    }
}
