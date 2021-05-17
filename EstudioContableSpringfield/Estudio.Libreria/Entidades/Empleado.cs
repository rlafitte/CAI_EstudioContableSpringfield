using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class Empleado : Persona
    {
        private int _legajo;
        private string _domicilio;
        private string _cuil;
        private string _empresa;
        //categoria: int idCategoria u objeto categoria? 
        private List<Liquidacion> _liqEmpleado;

        public List<Liquidacion> LiqEmpleado { get => this._liqEmpleado; }
        public Empleado(string nombre, string apellido, int dni, string cuil, string domicilio, int legajo, string empresa) : base(nombre, apellido, dni)
        {
            this._cuil = cuil;
            this._domicilio = domicilio;
            this._legajo = legajo;
            this._empresa = empresa;
            this._liqEmpleado = new List<Liquidacion>();
        }
        public Empleado()
        {

        }
    }
}
