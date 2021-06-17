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
        private int _cuit;
        private DateTime _fechaAlta;
        private string _domicilio;
        private int _usuario;
        private int _id;

        private List<Empleado> _empleados;

        [DataMember(Name = "razonSocial")]
        public string RazonSocial { get => this._nombre; }
        [DataMember(Name = "cuit")]
        public int Cuit { get => _cuit; }
        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => _fechaAlta; }
        [DataMember(Name = "usuario")]
        public int Usuario { get => _usuario;  }
        [DataMember(Name = "id")]
        public int Id { get => _id; }
        [DataMember(Name = "domicilio")]
        public string Domicilio { get => _domicilio; }

        public List<Empleado> Empleados { get => this._empleados; }

        public Empresa(string nombre, int cuit, string domicilio)
        {
            this._nombre = nombre;
            this._cuit = cuit;
            this._domicilio = domicilio;
            this._empleados = new List<Empleado>();
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
