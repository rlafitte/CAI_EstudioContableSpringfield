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

        
        private double _neto;
       
        public Empresa Empresa { get => this._empresa; }
        public Empleado Empleado { get => this._empleado; }
        public Categoria Categoria { get => this._categoria; }

        //inicio de datos de post en Swagger
        //idEmpleado
        //integer($int32)
        [DataMember(Name = "idEmpleado")]
        public int _idEmpleado { get => this._empleado.Legajo; }

        //Periodo
        //integer($int32)
        [DataMember(Name ="Periodo")]
        public int Mes { get => _mes; set => _mes = value; }
        
        
        //CodigoTransferencia
        //string

        [DataMember(Name ="CodigoTransferencia")]
        public string CodLiquidacion { get => this._codLiquidacion; }
        
        [DataMember(Name ="Bruto")]
        //Bruto
        //number($double)
        private double _bruto;

        //Descuentos
        //number($double)
        [DataMember(Name ="Descuentos")]
        private double _retenciones;

        //FechaAlta
        //string ($date-time)
        [DataMember(Name ="FechaAlta")]
        private string _fechaAlta;
        
        //id
        //integer($int32)
        [DataMember(Name = "id")]
        private int _id;
        //fin de datos de post en Swagger

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
