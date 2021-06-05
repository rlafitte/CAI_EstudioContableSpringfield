using Estudio.Datos;
using Estudio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocio
{
    public class EmpleadoNegocio
    {
        List<Empleado> _listaEmpleados;
        EmpleadoMapper _empleadoMapper;

        public EmpleadoNegocio()
        {
            this._listaEmpleados = new List<Empleado>();
            this._empleadoMapper = new EmpleadoMapper();
        }

        public List<Empleado> Traer()
        {
            this._listaEmpleados = this._empleadoMapper.TraerTodos();
            return this._listaEmpleados;
        }


        public TransactionResult Agregar(Empleado nuevoEmpleado)
        {
            BuscarEmpleado(nuevoEmpleado);
            TransactionResult resultado = this._empleadoMapper.Agregar(nuevoEmpleado);
            return resultado;
        }

        private void BuscarEmpleado(Empleado nuevoEmpleado)
        {
            foreach (Empleado empleado in this._empleadoMapper.TraerTodos())
            {
                if (nuevoEmpleado.Cuil == empleado.Cuil /*&& nuevoEmpleado.IdEmpresa == empleado.IdEmpresa*/)
                {
                    throw new Exception("El empleado ya existe en la empresa");
                }
            }
        }

        public TransactionResult Modificar(Empleado empleado)
        {
            TransactionResult resultado = this._empleadoMapper.Agregar(empleado);
            return resultado;
        }
        public TransactionResult Eliminar(Empleado empleado)
        {
            BuscarLiquidaciones(empleado);
            TransactionResult resultado = this._empleadoMapper.Eliminar(empleado);
            return resultado;
        }

        private void BuscarLiquidaciones(Empleado empleado)
        {
            /*
            foreach (Liquidacion liquidacion in this._liquidacionMapper.TraerTodos())
            {
                if (liquidacion.Empleado.Legajo == empleado.Legajo)
                {
                    throw new Exception("El empleado no puede eliminarse, posee liquidaciones a su nombre");
                }
            }
            */
        }

    }
}
