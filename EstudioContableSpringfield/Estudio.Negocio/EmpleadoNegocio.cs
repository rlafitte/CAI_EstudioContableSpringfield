

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
        LiquidacionMapper _liquidacionMapper;
        CategoriaMapper _categoriaMapper;

        public EmpleadoNegocio()
        {
            this._listaEmpleados = new List<Empleado>();
            this._empleadoMapper = new EmpleadoMapper();
            this._liquidacionMapper = new LiquidacionMapper();
            this._categoriaMapper = new CategoriaMapper();
        }

        public List<Empleado> Traer()
        {
            this._listaEmpleados = this._empleadoMapper.TraerTodos();
            return this._listaEmpleados;
        }

        public List<Empleado> TraerConCategoria()
        {
            List <Empleado> empleados = this._empleadoMapper.TraerTodos();
            List<Categoria> categorias = this._categoriaMapper.TraerTodos();
            foreach (Empleado empleado in empleados)
            {
                foreach (Categoria categoria in categorias)
                {
                    if (empleado.IdCategoria == categoria.Id)
                        empleado.Categoria = categoria;
                }
            }
            return empleados;
        }

        public TransactionResult Agregar(Empleado nuevoEmpleado)
        {
            if(EmpleadoExiste(nuevoEmpleado))
                throw new Exception("El empleado ya existe en la empresa");

            TransactionResult resultado = this._empleadoMapper.Agregar(nuevoEmpleado);
            return resultado;
        }

        private bool EmpleadoExiste(Empleado nuevoEmpleado)
        {
            bool empleadoExiste = false;

            foreach (Empleado empleado in this._empleadoMapper.TraerTodos())
            {
                if (nuevoEmpleado.Cuil == empleado.Cuil && nuevoEmpleado.IdEmpresa == empleado.IdEmpresa)
                    empleadoExiste = true;
            }
            return empleadoExiste;
        }

        public TransactionResult Modificar(Empleado empleado)
        {
            TransactionResult resultado = this._empleadoMapper.Modificar(empleado);
            return resultado;
        }

        public TransactionResult Eliminar(Empleado empleado)
        {
            if(PoseeLiquidaciones(empleado))
                throw new Exception("El empleado no puede eliminarse, posee liquidaciones");

            TransactionResult resultado = this._empleadoMapper.Eliminar(empleado);
            return resultado;
        }

        private bool PoseeLiquidaciones(Empleado empleado)
        {
            bool poseeLiquidaciones = false;
            List <Liquidacion> liquidaciones = this._liquidacionMapper.TraerTodos();
            if (liquidaciones!=null)
            {
                foreach (Liquidacion liquidacion in liquidaciones)
                {
                    if (liquidacion.IdEmpleado == empleado.Legajo)
                        poseeLiquidaciones = true;
                }
            }
            return poseeLiquidaciones;
        }

    }
}