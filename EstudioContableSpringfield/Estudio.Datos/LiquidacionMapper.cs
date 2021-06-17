using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades.Entidades
{
    public class LiquidacionMapper
    {
        static string rutaMapper;

        public LiquidacionMapper()
        {
            rutaMapper = ConfigurationManager.AppSettings["URL_LIQUIDACIONES"];
        }

        public List<Liquidacion> TraerTodos()
        {
            string json = WebHelper.Get(rutaMapper);
            List<Liquidacion> resultado = MapList(json);
            return resultado;
        }

        private List<Liquidacion> MapList(string json)
        {
            List<Liquidacion> lst = JsonConvert.DeserializeObject<List<Liquidacion>>(json);
            return lst;
        }


        public TransactionResult Insertar(Liquidacion liquidacion)
        {
            NameValueCollection obj = ReverseMap(liquidacion);

            string json = WebHelper.Post(rutaMapper, obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Liquidacion liquidacion)
        {
            NameValueCollection n = new NameValueCollection();

            /*
             *Chequear!
             
            n.Add("idEmpleado", liquidacion._idEmpleado.ToString());
            n.Add("Periodo", liquidacion.Periodo.ToString());
            n.Add("CodigoTransferencia", liquidacion.CodigoTransferencia);
            n.Add("Bruto", liquidacion.Bruto.ToString("0.00"));
            n.Add("Descuentos", liquidacion.Descuentos.ToString("0.00"));
            n.Add("FechaAlta", liquidacion.FechaAlta);
            n.Add("id", "0");
            */

            return n;
        }
    }
}