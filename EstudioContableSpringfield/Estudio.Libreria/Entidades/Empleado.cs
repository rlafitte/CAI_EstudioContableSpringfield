using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class Empleado: Persona
    {
        private int _legajo;
        private string _domicilio;
        private int _cuil;
        private int _codEmpresa;
        //categoria: int idCategoria u objeto categoria? 
        List<Liquidacion> _liqEmpleado;


        public Empleado(int legajo, string domicilio, int cuil, int codEmpresa, Persona p)
        {
            this._legajo = legajo;
            this._domicilio = domicilio;
            this._cuil = cuil;
            this._codEmpresa = codEmpresa;
            this.Nombre = p.Nombre;
            this.Apellido = p.Apellido;
            this.Documento = p.Documento;
            this._liqEmpleado = new List<Liquidacion>();
        }



    }
}
