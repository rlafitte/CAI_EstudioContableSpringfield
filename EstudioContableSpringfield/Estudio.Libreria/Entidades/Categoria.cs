using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class Categoria
    {
        private int _idCategoria;
        private string _nombre;
        private double _sueldoBasico;
        private double _porcRetenciones;
        private bool _siConvenio;
        private string _cCT; //Convenio colectivo de trabajo

        public int IdCategoria { get => _idCategoria; }
        public double SueldoBasico { get => _sueldoBasico; }

        public Categoria(int idCategoria, string nombre, double sueldoBasico, double porcRetenciones, bool siConvenio, string cCT)
        {
            this._idCategoria = idCategoria;
            this._nombre = nombre;
            this._sueldoBasico = sueldoBasico;
            this._porcRetenciones = porcRetenciones;
            this._siConvenio = siConvenio;
            this._cCT = cCT;
        }


        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                return false;
            }
            if(!(obj is Categoria))
            {
                return false;
            }
            else
            {
                Categoria categoria = (Categoria)obj;
                return this._idCategoria == categoria._idCategoria;
            }
        }

        public override string ToString()
        {
            string convenio = "";
            if (this._siConvenio == true) { convenio = this._cCT; } 
            else { convenio = "Fuera de Convenio"; }
            return $"{this._nombre} - {convenio}";
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
