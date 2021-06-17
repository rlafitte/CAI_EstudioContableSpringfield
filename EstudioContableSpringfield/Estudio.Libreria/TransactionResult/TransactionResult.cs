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

        public override string ToString()
        {
            if (IsOk)
                return $"Operación exitosa: {this.Id}";
            else
                return $"La operación no pudo realizarse: {this.Error}";
        }

    }

    
}