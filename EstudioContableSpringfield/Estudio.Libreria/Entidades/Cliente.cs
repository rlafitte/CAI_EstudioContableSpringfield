using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class Cliente : Persona
    {
        private int _id;

        public int Id { get => _id; set => _id = value; }

        public Cliente(int id, Persona p)
        {
            this.Id = id;
            this.Nombre = p.Nombre;
            this.Apellido = p.Apellido;
            this.TipoDocumento = p.TipoDocumento;
            this.Documento = p.Documento;
        }
    }
}
