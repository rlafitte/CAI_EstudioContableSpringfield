using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class EstudioContable
    {
        List<int> _codLiquidaciones;
        private List<Empresa> _empresas;
        private List<Categoria> _categorias;
        private List<Liquidacion> _liquidaciones;

        public List<int> CodLiquidaciones { get => _codLiquidaciones; set => _codLiquidaciones = value; }
        public List<Empresa> Empresas { get => _empresas; set => _empresas = value; }
        public List<Categoria> Categorias { get => _categorias; set => _categorias = value; }
        public List<Liquidacion> Liquidaciones { get => _liquidaciones; }

        public EstudioContable()
        {
            this._codLiquidaciones = new List<int>();
            this._empresas = new List<Empresa>();
            this._categorias = new List<Categoria>();
            this._liquidaciones = new List<Liquidacion>();
        }

        public void GuardarCategoria(Categoria categoriaAgre)
        {
            foreach (Categoria categoria in this._categorias)
            {
                if (categoria.Equals(categoriaAgre))
                {
                    throw new Exception("La categoría ya existe");
                }
            }
            this._categorias.Add(categoriaAgre);
        }
    }
}
