using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    [DataContract]
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

        
        private double _bruto;
        private double _retenciones;
        private double _neto;
        [DataMember(Name = "apellido")]
        public string CodLiquidacion { get => this._codLiquidacion; }
        public Empresa Empresa { get => this._empresa; }
        public Empleado Empleado { get => this._empleado; }
        public Categoria Categoria { get => this._categoria; }
        [DataMember(Name ="Periodo")]
        public int Mes { get => _mes; set => _mes = value; }

        public Liquidacion(string codLiquidacion, int mes, int año, string tipo, DateTime fechaPago, Empresa empresa, Empleado empleado)
        {
            this._codLiquidacion = codLiquidacion;
            this.Mes = mes;
            this._año = año;
            this._tipo = tipo;
            this._fechaPago = fechaPago;
            this._empresa = empresa;
            this._empleado = empleado;
            this._categoria = empleado.Categoria;
            this._bruto = _categoria.SueldoBasico;
            this._retenciones = _categoria.GetMontoRetenciones();
            this._neto = _categoria.GetSueldoNeto();
        }
        public Liquidacion() 
        { 
        }

        public override string ToString()
        {
            return $"Código: {this._codLiquidacion} | Fecha: {this.Mes}/{this._año} | Tipo: {this._tipo} | Empresa: {this._empresa} | Empleado: {this._empleado} | Categoria: {this._categoria}";
        }
    }
}
