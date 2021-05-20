using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class Empresa
    {
        private int _id;
        private string _nombre;
        private string _cuit;
        private DateTime _inicioActividad;
        private string _rubro;
        private string _domicilio;
        private List<Empleado> _empleados;


        public int Id { get => this._id; }
        public string Nombre { get => this._nombre; }
        public List<Empleado> Empleados { get => this._empleados; }

        public Empresa(int id, string nombre, string cuit, string rubro, DateTime inicioActiv, string domicilio)
        {
            this._id = id;
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
    }
}
