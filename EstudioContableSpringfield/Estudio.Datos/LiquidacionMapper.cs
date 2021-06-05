using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Entidades.Entidades
{
    public class LiquidacionMapper
    {
        public List<Liquidacion> TraerTodos()
        {
            string json = WebHelper.Get("Liquidaciones");
            List<Liquidacion> resultado = MapList(json);
            return resultado;
        }

        private List<Liquidacion> MapList(string json)
        {
            List<Liquidacion> lst = JsonConvert.DeserializeObject<List<Liquidacion>>(json);
            return lst;
        }


        public TransactionResult Insertar(Liquidacion liq)
        {
            NameValueCollection obj = ReverseMap(liq);

            string json = WebHelper.Post("Liquidacion", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Liquidacion liq)
        {
            NameValueCollection n = new NameValueCollection();
            //n.Add("id", cliente.id.ToString());
            //n.Add("nombre", cliente.Nombre);
            //n.Add("apellido", cliente.Ape);
            //n.Add("direccion", cliente.Direccion);
            //n.Add("DNI", cliente.DNI);
            //n.Add("fechaNacimiento", "2000-01-01");
            //n.Add("usuario", "1");
            return n;
        }
    }
}
