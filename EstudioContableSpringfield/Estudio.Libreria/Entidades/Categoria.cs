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
        private bool _siConvenio;
        private string _cCT; //Convenio colectivo de trabajo


        public Categoria(int idCategoria, string nombre, double sueldoBasico, bool siConvenio, string cCT)
        {
            this._idCategoria = idCategoria;
            this._nombre = nombre;
            this._sueldoBasico = sueldoBasico;
            this._siConvenio = siConvenio;
            this._cCT = cCT;
        }
    }
}
