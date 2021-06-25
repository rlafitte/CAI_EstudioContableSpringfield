using Estudio.Entidades.Entidades;
using Estudio.Libreria.Modelos;
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
    public class EmailMapper
    {
        static string rutaMapper;
        public EmailMapper()
        {
            rutaMapper = ConfigurationManager.AppSettings["URL_UTILIDADES"];
        }

        public TransactionResult Agregar(Email email)
        {
            NameValueCollection parametros = ReverseMap(email);
            string json = WebHelper.Post(rutaMapper, parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Email email)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Para", email.Para);
            n.Add("Asunto", email.Asunto);
            n.Add("Mensaje", email.Mensaje);
            return n;
        }
    }
}
