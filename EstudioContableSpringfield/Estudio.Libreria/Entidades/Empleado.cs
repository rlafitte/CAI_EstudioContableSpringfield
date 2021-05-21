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
        private Categoria _categoria;

        public int Legajo { get => this._legajo; }
        public Categoria Categoria { get => _categoria; }
        public string Cuil { get => _cuil; }

        public Empleado(string nombre, string apellido, int dni, int legajo, string domicilio, string cuil, string empresa, Categoria categoria) : base(nombre, apellido, dni)
        {
            this._legajo = legajo;
            this._domicilio = domicilio;
            this._cuil = cuil;
            this._empresa = empresa;
            this._categoria = categoria;

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
