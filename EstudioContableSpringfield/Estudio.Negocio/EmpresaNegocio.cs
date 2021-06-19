using Estudio.Datos;
using Estudio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocio
{
    public class EmpresaNegocio
    {
        private List<Empresa> _listaEmpresas;
        private EmpresaMapper _empresaMapper;
        private EmpleadoNegocio _empleadoNegocio;

        public EmpresaNegocio()
        {
            this._listaEmpresas = new List<Empresa>();
            this._empresaMapper = new EmpresaMapper();
            this._empleadoNegocio = new EmpleadoNegocio();
        }

        public List<Empresa> Traer()
        {
            _listaEmpresas = _empresaMapper.TraerTodos();
            return _listaEmpresas;
        }


        public TransactionResult Agregar(Empresa nuevaEmpresa)
        {
            if(EmpresaExiste(nuevaEmpresa))
                throw new Exception("No puede darse de alta, la empresa ya existe"); 
            
            TransactionResult resultado = this._empresaMapper.Agregar(nuevaEmpresa);
            return resultado;
        }

        private bool EmpresaExiste(Empresa nuevaEmpresa)
        {
            bool empresaExiste = false;
            foreach (Empresa empresa in this._empresaMapper.TraerTodos())
            {
                if (nuevaEmpresa.Cuit == empresa.Cuit)
                    empresaExiste = true;
            }
            return empresaExiste;
        }

        public TransactionResult Modificar(Empresa empresa)
        {
            TransactionResult resultado = this._empresaMapper.Modificar(empresa);
            return resultado;
        }

        public object TraerConEmpleados()
        {
            List<Empresa> empresas = _empresaMapper.TraerTodos();
            List<Empleado> empleados = this._empleadoNegocio.TraerConCategoria();

            foreach (Empresa empresa in empresas)
            {
                foreach (Empleado empleado in empleados)
                {
                    if (empresa.Id == empleado.IdEmpresa)
                        empresa.Empleados.Add(empleado);
                }
            }
            return empresas;
        }
    }
}