using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Modelos
{
    public class Email
    {
        private string _para;
        private string _asunto;
        private string _mensaje;

        public Email(string para, string asunto, string mensaje)
        {
            _para = para;
            _asunto = asunto;
            _mensaje = mensaje;
        }

        public string Para { get => _para; set => _para = value; }
        public string Asunto { get => _asunto; set => _asunto = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
    }
}
