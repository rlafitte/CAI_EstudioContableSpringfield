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
        private Empresa _empresaVacia;
        private Empleado _empleadoNuevo;

        public EmpresaNegocio()
        {
            this._listaEmpresas = new List<Empresa>();
            this._empresaMapper = new EmpresaMapper();
            this._empleadoNegocio = new EmpleadoNegocio();
        }

        public List<Empresa> Traer()
        {
            EmpresasFicticias();


            //_listaEmpresas = _empresaMapper.TraerTodos();
            _listaEmpresas.AddRange(_empresaMapper.TraerTodos());
            _listaEmpresas.OrderBy(o=>o.Cuit);
            return _listaEmpresas;
        }

        private void EmpresasFicticias()
        {
            _empresaVacia = new Empresa("  Seleccione", 0, "");
            _listaEmpresas.Insert(0, _empresaVacia);
            _empresaVacia = new Empresa(" Nueva empresa", 1, "");
            _listaEmpresas.Insert(1, _empresaVacia);
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
            _empresaVacia = new Empresa("  Seleccione", 0, "");
            _empleadoNuevo = new Empleado("<<NUEVO EMPLEADO>>");
            List<Empresa> empresas = new List<Empresa>();
            empresas.Insert(0, _empresaVacia);
            empresas.AddRange(_empresaMapper.TraerTodos());
            //List<Empresa> empresas = _empresaMapper.TraerTodos();
            List<Empleado> empleados = this._empleadoNegocio.TraerConCategoria();

            foreach (Empresa empresa in empresas)
            {
                if (empresa.Id > 0)
                {
                    empresa.Empleados.Add(_empleadoNuevo);
                }
                foreach (Empleado empleado in empleados)
                {
                    
                    if (empresa.Id > 0 && empresa.Id == empleado.IdEmpresa && empleado.Nombre != "<<NUEVO EMPLEADO>>")
                        empresa.Empleados.Add(empleado);
                }
            }
            empresas.OrderBy(o => o.Cuit);
            return empresas;
        }
    }
}