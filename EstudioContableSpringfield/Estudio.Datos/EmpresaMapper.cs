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
    public class EmpresaMapper
    {
        static string rutaMapper;

        public EmpresaMapper()
        {
            rutaMapper = ConfigurationManager.AppSettings["URL_EMPRESAS"];
        }

        public List<Empresa> TraerTodos()
        {
            string json = WebHelper.Get(rutaMapper);
            List<Empresa> resultado = MapList(json);
            return resultado;
        }

        private List<Empresa> MapList(string json)
        {
            List<Empresa> lista = JsonConvert.DeserializeObject<List<Empresa>>(json);
            return lista;
        }

        public TransactionResult Agregar (Empresa empresa)
        {
            NameValueCollection parametros = ReverseMap(empresa);
            string json = WebHelper.Post(rutaMapper, parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Empresa empresa)
        {
            
            NameValueCollection n = new NameValueCollection();
            
            n.Add("razonSocial", empresa.RazonSocial);
            n.Add("cuit", empresa.Cuit.ToString());
            n.Add("domicilio", empresa.Domicilio);
            n.Add("fechaAlta", empresa.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("usuario", "999999");
            n.Add("id", empresa.Id.ToString());
            
            return n;
            
        }

        public TransactionResult Modificar(Empresa empresa)
        {
            NameValueCollection parametros = ReverseMap(empresa);
            string json = WebHelper.Put(rutaMapper, parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }
    }
}
