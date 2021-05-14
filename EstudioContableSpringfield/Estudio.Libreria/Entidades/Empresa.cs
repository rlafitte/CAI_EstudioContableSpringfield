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
        private int _cuit;
        private DateTime _inicioActividad;
        private string _rubro;
        private string _domicilio;
        private List<Empleado> _empleados;
       
        
        public int Id { get => _id; set => _id = value; }

        public Empresa(int id, string nombre, int cuit, DateTime inicioActiv, string rubro, string domicilio)
        {
            this._id = id;
            this._nombre = nombre;
            this._cuit = cuit;
            this._inicioActividad = inicioActiv;
            this._rubro = rubro;
            this._domicilio = domicilio;
            this._empleados = new List<Empleado>();
        }
    }
}
