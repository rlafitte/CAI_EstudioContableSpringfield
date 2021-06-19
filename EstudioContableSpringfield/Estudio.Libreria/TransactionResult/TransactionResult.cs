using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Estudio.Entidades.Entidades
{
   [DataContract]
    public class TransactionResult
    {
        [DataMember]
        public bool IsOk { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Error { get; set; }

        public string DarMensaje()
        {
            if (this.IsOk)
                return $"Guardado! Id: {this.Id}";

            return $"Hubo un error. Error: {this.Error}";
        }
    }
}