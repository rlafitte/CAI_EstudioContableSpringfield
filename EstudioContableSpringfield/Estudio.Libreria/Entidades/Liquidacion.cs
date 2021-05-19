using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class Liquidacion
    {
        private string _codLiquidacion;
        private int _mes;
        private int _año;
        private string _tipo;
        private DateTime _fechaPago;
        private Empresa _empresa;
        private Empleado _empleado;
        private Categoria _categoria;

        //
        private double _bruto;
        private double _retenciones;
        private double _neto;

        public string CodLiquidacion { get => this._codLiquidacion; }
        public Empresa Empresa { get => this._empresa; }
        public Empleado Empleado { get => this._empleado; }
        public Categoria Categoria { get => this._categoria; }

        public Liquidacion(string codLiquidacion, int mes, int año, string tipo, DateTime fechaPago, Empresa empresa, Empleado empleado, double bruto, double retenciones, double neto)
        {
            this._codLiquidacion = codLiquidacion;
            this._mes = mes;
            this._año = año;
            this._tipo = tipo;
            this._fechaPago = fechaPago;
            this._empresa = empresa;
            this._empleado = empleado;
            this._bruto = bruto;
            this._retenciones = retenciones;
            this._neto = neto;
        }
        public Liquidacion() 
        { 
        }

        public override string ToString()
        {
            return $"Código: {this._codLiquidacion} | Fecha: {this._mes}/{this._año} | Tipo: {this._tipo} | Empresa: {this._empresa} | Empleado: {this._empleado}";
        }
    }
}
