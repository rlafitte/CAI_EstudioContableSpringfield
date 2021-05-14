﻿using System;
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

        public List<int> CodLiquidaciones { get => _codLiquidaciones; set => _codLiquidaciones = value; }
        public List<Empresa> Empresas { get => _empresas; set => _empresas = value; }
        public List<Categoria> Categorias { get => _categorias; set => _categorias = value; }

        public EstudioContable()
        {
            this._codLiquidaciones = new List<int>();
            this._empresas = new List<Empresa>();
            this._categorias = new List<Categoria>();
        }
    }
}
