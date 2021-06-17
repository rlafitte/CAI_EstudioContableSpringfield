﻿using Estudio.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Datos
{
    public class CategoriaMapper
    {
        static string rutaMapper;

        public CategoriaMapper()
        {
            rutaMapper = ConfigurationManager.AppSettings["URL_CATEGORIAS"];
        }

        public List<Categoria> TraerTodos()
        {
            string json = WebHelper.Get(rutaMapper);
            List<Categoria> resultado = MapList(json);
            return resultado;
        }

        private List<Categoria> MapList(string json)
        {
            List<Categoria> lista = JsonConvert.DeserializeObject<List<Categoria>>(json);
            return lista;
        }

        public TransactionResult Agregar (Categoria categoria)
        {
            NameValueCollection parametros = ReverseMap(categoria);
            string json = WebHelper.Post(rutaMapper, parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Categoria categoria)
        {
            NameValueCollection n = new NameValueCollection();
            
            n.Add("nombre", categoria.Nombre);
            n.Add("convenio", categoria.Convenio);
            n.Add("sueldoBasico", categoria.SueldoBasico.ToString());
            n.Add("id", categoria.Id.ToString());
            
            return n;
        }
    }
}