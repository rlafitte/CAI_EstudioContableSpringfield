using Estudio.Datos;
using Estudio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocio
{
    public class CategoriaNegocio
    {
        private List<Categoria> _listaCategorias;
        private CategoriaMapper _categoriaMapper;
        private Categoria _categoriaVacia;

        static string salarioMinimoVitalMovil;


        public CategoriaNegocio()
        {
            this._listaCategorias = new List<Categoria>();
            this._categoriaMapper = new CategoriaMapper();

            salarioMinimoVitalMovil = ConfigurationManager.AppSettings["SMVM"];
        }

        public List<Categoria> Traer()
        {
            _categoriaVacia = new Categoria("<SELECCION>",0,"");
            _listaCategorias.Insert(0, _categoriaVacia);
            _listaCategorias.AddRange(TraerCategoriasFiltradas());
            return this._listaCategorias;
        }


        public List<Categoria> TraerCategoriasFiltradas()
        {
            List<Categoria> categoriasFiltradas = new List<Categoria>();

            foreach (Categoria categoria in this._categoriaMapper.TraerTodos())
                if (categoria.SueldoBasico > double.Parse(salarioMinimoVitalMovil))
                    categoriasFiltradas.Add(categoria);

            return categoriasFiltradas;
        }

        public TransactionResult Agregar(Categoria nuevaCategoria)
        {
            BuscarCategoria(nuevaCategoria);
            TransactionResult resultado = this._categoriaMapper.Agregar(nuevaCategoria);
            return resultado;
        }

        private void BuscarCategoria(Categoria nuevaCategoria)
        {
            foreach (Categoria categoria in this._categoriaMapper.TraerTodos())
            {
                if (categoria.ToString() == nuevaCategoria.ToString())
                {
                    throw new Exception("La categoría ya existe");
                }
            }
        }
    }
}