using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class Empresa
    {
        private string _nombre;
        private string _cuit;
        private DateTime _inicioActividad;
        private string _rubro;
        private string _domicilio;
        private List<Empleado> _empleados;


        public string Nombre { get => this._nombre; }
        public string Cuit { get => _cuit; }
        public List<Empleado> Empleados { get => this._empleados; }

        public Empresa(string nombre, string cuit, string rubro, DateTime inicioActiv, string domicilio)
        {
            this._nombre = nombre;
            this._cuit = cuit;
            this._inicioActividad = inicioActiv;
            this._rubro = rubro;
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
        public string ListaEmpleados()
        {
            string str = "";
            foreach(Empleado _e in _empleados)
            {
                str += _e.Apellido + ", " + _e.Nombre + System.Environment.NewLine;
            }
            return str;
        }
        
    }
}
