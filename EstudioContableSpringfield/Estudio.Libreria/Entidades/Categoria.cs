using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades.Entidades
{
    [DataContract]
    public class Categoria
    {
        private int _id;
        private string _nombre;
        private double _sueldoBasico;
        private string _convenio; //Convenio colectivo de trabajo

        private double _porcRetenciones;
        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }
        [DataMember(Name = "nombre")]

        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember(Name = "sueldoBasico")]

        public double SueldoBasico { get => _sueldoBasico; set => _sueldoBasico = value; }
        [DataMember(Name = "convenio")]
        public string Convenio { get => _convenio; set => _convenio = value; }

        public Categoria(string nombre, double sueldoBasico, double porcRetenciones, string cCT)
        {
            this._nombre = nombre;
            this._sueldoBasico = sueldoBasico;
            this._porcRetenciones = porcRetenciones;
            this._convenio = cCT;
        }

        public override string ToString()
        {
            return $"{this._nombre} - {this.Convenio}";
        }

        public double GetSueldoNeto()
        {
            return this._sueldoBasico - GetMontoRetenciones();
        }
        public double GetMontoRetenciones()
        {
            return this._sueldoBasico * this._porcRetenciones / 100;
        }
    }
}
