using Estudio.Datos;
using Estudio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocio
{
    public class ReportesNegocio
    {
        private List<Empleado> _emple;
        private List<Empresa> _empresas;
        private EmpleadoMapper _empleMap;
        private EmpresaMapper _empreMap;
        private EmpresaNegocio _empreNeg;

        public ReportesNegocio()
        {
            this._emple = new List<Empleado>();
            this._empresas = new List<Empresa>();
            this._empleMap= new EmpleadoMapper();
            this._empreMap= new EmpresaMapper();
            this._empreNeg = new EmpresaNegocio();
        }

        public List<Empleado> Traer()
        {
            this._emple = this._empleMap.TraerTodos();
            this._empresas = this._empreMap.TraerTodos(); 
            return _emple;
        }
        public object TraerEmpresas()
        {
            return _empreNeg.TraerConEmpleados();
        }
    }
}
