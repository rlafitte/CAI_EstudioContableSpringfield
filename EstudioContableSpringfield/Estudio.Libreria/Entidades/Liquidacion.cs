using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades.Entidades
{
    public class Liquidacion
    {
        private LiquidacionMapper _liqMap;
        private string _codLiquidacion;
        private int _mes;
        private int _año;
        private string _tipo;
        private DateTime _fechaPago;
        private int _id;
        private double _bruto;
        private double _retenciones;

        private Empresa _empresa;
        private Empleado _empleado;
        private Categoria _categoria;

        private double _neto;

        public string CodLiquidacion { get => this._codLiquidacion; }
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
        [DataMember(Name = "Periodo")]
        public int Periodo { get => ObtenerPeriodo(this._mes, this._año); set => _mes = value; }

        //CodigoTransferencia
        //string

        [DataMember(Name = "CodigoTransferencia")]
        public string CodigoTransferencia { get => this._codLiquidacion; }

        [DataMember(Name = "Bruto")]
        //Bruto
        //number($double)
        public double Bruto { get => this._bruto; }

        //Descuentos
        //number($double)
        [DataMember(Name = "Descuentos")]
        public double Descuentos { get => this._retenciones; }

        //FechaAlta
        //string ($date-time)
        [DataMember(Name = "FechaAlta")]
        public string FechaAlta { get => this._fechaPago.ToString("yyyy-MM-dd"); }

        //id
        //integer($int32)
        [DataMember(Name = "id")]
        public int Id { get => this._id; }
        //fin de datos de post en Swagger

        public Liquidacion(string codLiquidacion, int mes, int año, string tipo, DateTime fechaPago, Empresa empresa, Empleado empleado)
        {
            _liqMap = new LiquidacionMapper();
            this._codLiquidacion = codLiquidacion;
            this._mes = mes;
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
            _liqMap = new LiquidacionMapper();
        }

        public override string ToString()
        {
            return $"Código: {this._codLiquidacion} | Período: {this.Periodo} | Tipo: {this._tipo} | Empresa: {this._empresa} | Empleado: {this._empleado} | Categoria: {this._categoria}";
        }

        public List<Liquidacion> TraerLiq()
        {
            List<Liquidacion> _lista = new List<Liquidacion>();
            _lista = _liqMap.TraerTodos();
            return _lista;
        }

        public int ObtenerPeriodo(int mes, int año)
        {
            string stringMes = $"{mes}";
            if (mes < 10)
                stringMes = $"0{mes}";

            string periodo = $"{año}{stringMes}";
            return int.Parse(periodo);
        }
    }
}
