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
    public class LiquidacionMapper
    {
        static string rutaMapperGET;
        static string rutaMapperPOST_PUT_DELETE;

        public LiquidacionMapper()
        {
            rutaMapperGET = ConfigurationManager.AppSettings["URL_LIQUIDACIONES"];
            rutaMapperPOST_PUT_DELETE = ConfigurationManager.AppSettings["URL_LIQUIDACION"];
        }

        public List<Liquidacion> TraerTodos()
        {
            string json = WebHelper.Get(rutaMapperGET);
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

            string json = WebHelper.Post(rutaMapperPOST_PUT_DELETE, obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Eliminar(Liquidacion liqSeleccionada)
        {
            NameValueCollection parametros = ReverseMap(liqSeleccionada);
            string json = WebHelper.Delete($"{rutaMapperPOST_PUT_DELETE}/{liqSeleccionada.Id}", parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Liquidacion liquidacion)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("idEmpleado", liquidacion.IdEmpleado.ToString());
            n.Add("Periodo", liquidacion.Periodo.ToString());
            n.Add("CodigoTransferencia", liquidacion.CodigoTransferencia);
            n.Add("Bruto", liquidacion.Bruto.ToString("0.00"));
            n.Add("Descuentos", liquidacion.Descuentos.ToString("0.00"));
            n.Add("FechaAlta", liquidacion.FechaAlta);
            n.Add("id", "0");

            return n;
        }
    }
}