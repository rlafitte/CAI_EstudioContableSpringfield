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

        public LiquidacionNegocio()
        {
            this._listaLiquidaciones = new List<Liquidacion>();
            this._liquidacionMapper = new LiquidacionMapper();
        }

        public List<Liquidacion> Traer()
        {
            this._listaLiquidaciones = this._liquidacionMapper.TraerTodos();
            //_listaLiquidaciones.OrderBy(o => o.Categoria);
            return this._listaLiquidaciones;
        }

        public TransactionResult Agregar (Liquidacion liquidacion)
        {
            TransactionResult resultado = this._liquidacionMapper.Insertar(liquidacion);
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
