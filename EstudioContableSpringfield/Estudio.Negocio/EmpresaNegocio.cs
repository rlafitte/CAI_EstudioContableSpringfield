using Estudio.Datos;
using Estudio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Negocio
{
    public class EmpresaNegocio
    {
        private List<Empresa> _listaEmpresas;
        private EmpresaMapper _empresaMapper;

        public EmpresaNegocio()
        {
            this._listaEmpresas = new List<Empresa>();
            this._empresaMapper = new EmpresaMapper();
        }

        public List<Empresa> Traer()
        {
            _listaEmpresas = _empresaMapper.TraerTodos();
            return _listaEmpresas;
        }


        public TransactionResult Agregar(Empresa nuevaEmpresa)
        {
            BuscarEmpresa(nuevaEmpresa);
            TransactionResult resultado = this._empresaMapper.Agregar(nuevaEmpresa);
            return resultado;
        }

        private void BuscarEmpresa(Empresa nuevaEmpresa)
        {
            foreach (Empresa empresa in this._empresaMapper.TraerTodos())
            {
                if (nuevaEmpresa.Cuit == empresa.Cuit)
                {
                    throw new Exception("La empresa ya existe");
                }
            }
        }

        public TransactionResult Modificar(Empresa empresa)
        {
            TransactionResult resultado = this._empresaMapper.Modificar(empresa);
            return resultado;
        }

    }
}
