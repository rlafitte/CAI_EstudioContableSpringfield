using Estudio.Datos;
using Estudio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocio
{
    public class LiquidacionNegocio
    {
        
        private List<Liquidacion> _listaLiquidaciones;
        private LiquidacionMapper _liquidacionMapper;
        private EmpleadoNegocio _empleadoNegocio;

        public LiquidacionNegocio()
        {
            this._listaLiquidaciones = new List<Liquidacion>();
            this._liquidacionMapper = new LiquidacionMapper();
            this._empleadoNegocio = new EmpleadoNegocio();
        }

        public List<Liquidacion> Traer()
        {
            this._listaLiquidaciones = this._liquidacionMapper.TraerTodos();
            return this._listaLiquidaciones;
        }

        public List<Liquidacion> TraerConCategoria()
        {
            List<Liquidacion> liquidaciones = new List<Liquidacion>();
            List<Empleado> empleados = this._empleadoNegocio.TraerConCategoria();
            foreach (Liquidacion liquidacion in this._liquidacionMapper.TraerTodos())
            {
                foreach (Empleado empleado in empleados)
                {
                    if (liquidacion.IdEmpleado == empleado.Legajo)
                    {
                        liquidacion.Categoria = empleado.Categoria;
                        liquidacion.Empleado = empleado;
                        liquidaciones.Add(liquidacion);
                    }
                }
            }
            return liquidaciones;
        }

        public TransactionResult Agregar (Liquidacion liquidacion)
        {
            TransactionResult resultado = this._liquidacionMapper.Insertar(liquidacion);
            return resultado;
        }

        public TransactionResult Eliminar(Liquidacion liqSeleccionada)
        {
            TransactionResult resultado = this._liquidacionMapper.Eliminar(liqSeleccionada);
            return resultado;
        }

        /*
        public TransactionResult Modificar(Liquidacion liquidacion)
        {
            TransactionResult resultado = this._liquidacionMapper.Modificar(liquidacion);
            return resultado;
        }

        public TransactionResult Eliminar(Liquidacion liquidacion)
        {
            TransactionResult resultado = this._liquidacionMapper.Eliminar(liquidacion);
            return resultado;
        }
        */


    }
}
