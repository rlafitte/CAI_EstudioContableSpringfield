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
    }
}
