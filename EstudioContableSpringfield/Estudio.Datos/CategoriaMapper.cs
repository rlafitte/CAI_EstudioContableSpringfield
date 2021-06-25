using Estudio.Entidades.Entidades;
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
        static string rutaMapperGET;
        static string rutaMapperPOST_PUT_DELETE;

        public CategoriaMapper()
        {
            rutaMapperGET = ConfigurationManager.AppSettings["URL_CATEGORIAS"];
            rutaMapperPOST_PUT_DELETE = ConfigurationManager.AppSettings["URL_CATEGORIA"];
        }

        public List<Categoria> TraerTodos()
        {
            string json = WebHelper.Get(rutaMapperGET);
            List<Categoria> resultado = MapList(json);
            return resultado;
        }

        private List<Categoria> MapList(string json)
        {
            List<Categoria> lista = JsonConvert.DeserializeObject<List<Categoria>>(json);
            return lista;
        }

        public TransactionResult Agregar(Categoria categoria)
        {
            NameValueCollection parametros = ReverseMap(categoria);
            string json = WebHelper.Post(rutaMapperPOST_PUT_DELETE, parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Categoria categoria)
        {
            NameValueCollection n = new NameValueCollection();
            
            n.Add("nombre", categoria.Nombre);
            n.Add("convenio", categoria.Convenio);
            n.Add("sueldoBasico", categoria.SueldoBasico.ToString("0.00"));
            n.Add("id", "0");
            
            return n;
        }
    }
}