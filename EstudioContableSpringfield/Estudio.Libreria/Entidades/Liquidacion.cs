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
        private string _codLiquidacion;
        private int _mes;
        private int _año;
        private DateTime _fechaPago;
        private int _id;
        private double _bruto;
        private double _retenciones;
        private int _idEmpleado;
        private DateTime _fechaAlta;

        private double _neto;

        private Empresa _empresa;
        private Empleado _empleado;
        private Categoria _categoria;

        public double Neto { get /*=> _neto; set*/ => _neto = this._bruto - this._retenciones; }

        public Empresa Empresa { get => this._empresa; set => this._empresa = value; }
        public Empleado Empleado { get => this._empleado; set => this._empleado = value; }
        public Categoria Categoria { get => this._categoria; set => this._categoria = value; }

        //inicio de datos de post en Swagger
        //idEmpleado
        //integer($int32)
        [DataMember(Name = "idEmpleado")]
        public int IdEmpleado { get => this._idEmpleado; set => this._idEmpleado = value; }

        //Periodo
        //integer($int32)
        [DataMember(Name = "Periodo")]
        public int Periodo { get => ObtenerPeriodo(this._mes, this._año); set => _mes = value; }

        //CodigoTransferencia
        //string

        [DataMember(Name = "CodigoTransferencia")]
        public string CodigoTransferencia { get => this._codLiquidacion; set => this._codLiquidacion = value; }

        [DataMember(Name = "Bruto")]
        //Bruto
        //number($double)
        public double Bruto { get => this._bruto; set => this._bruto = value; }

        //Descuentos
        //number($double)
        [DataMember(Name = "Descuentos")]
        public double Descuentos { get => this._retenciones; set => this._retenciones = value; }

        //FechaAlta
        //string ($date-time)
        [DataMember(Name = "FechaAlta")]
        public string FechaAlta { get => this._fechaPago.ToString("yyyy-MM-dd"); set => this._fechaAlta = DateTime.Parse(value); /*DateTime.Parse(value + " 00:00:00";*/ }

        //id
        //integer($int32)
        [DataMember(Name = "id")]
        public int Id { get => this._id; set => this._id = value; }

        //fin de datos de post en Swagger


        public Liquidacion()
        {
        }

        public Liquidacion(string codLiquidacion, int mes, int año, DateTime fechaPago, int idEmpleado, double bruto, double porcRetenciones)
        {
            this._codLiquidacion = codLiquidacion;
            this._mes = mes;
            this._año = año;
            this._fechaPago = fechaPago;
            this._bruto = bruto;
            this._retenciones = this.GetMontoRetenciones(porcRetenciones);
            this._idEmpleado = idEmpleado;
        }
        public Liquidacion(double bruto, double porcRetenciones)
        {
            this._bruto = bruto;
            this._retenciones = this.GetMontoRetenciones(porcRetenciones);
        }

        public double GetMontoRetenciones(double porcRetenciones)
        {
            return this._bruto * porcRetenciones / 100;
        }

        public override string ToString()
        {
            return $"Código: {this._codLiquidacion} | Período: {this.Periodo} | Empleado: {this._empleado.ApellidoYNombre} | Categoría: { this._categoria.NombreYConvenio} | Neto: ARS { this._neto.ToString("0.00")}" ;            
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
