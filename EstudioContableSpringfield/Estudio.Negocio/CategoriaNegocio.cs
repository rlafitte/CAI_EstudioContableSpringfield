﻿using Estudio.Datos;
using Estudio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocio
{
    public class CategoriaNegocio
    {
        private List<Categoria> _listaCategorias;
        private CategoriaMapper _categoriaMapper;

        public CategoriaNegocio()
        {
            this._listaCategorias = new List<Categoria>();
            this._categoriaMapper = new CategoriaMapper();
        }

        public List<Categoria> Traer()
        {
            this._listaCategorias = this._categoriaMapper.TraerTodos();
            return this._listaCategorias;
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