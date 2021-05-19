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

        public int Legajo { get => this._legajo; }


        public Empleado(string nombre, string apellido, int dni, string cuil, string domicilio, int legajo, string empresa) : base(nombre, apellido, dni)
        {
            this._cuil = cuil;
            this._domicilio = domicilio;
            this._legajo = legajo;
            this._empresa = empresa;
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
