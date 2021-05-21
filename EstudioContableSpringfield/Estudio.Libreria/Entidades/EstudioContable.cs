using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio.Libreria.Entidades
{
    public class EstudioContable
    {
        private List<Empresa> _empresas;
        private List<Categoria> _categorias;
        private List<Liquidacion> _liquidaciones;

        public List<Empresa> Empresas { get => _empresas; set => _empresas = value; }
        public List<Categoria> Categorias { get => _categorias; set => _categorias = value; }
        public List<Liquidacion> Liquidaciones { get => _liquidaciones; }

        public EstudioContable()
        {
            this._empresas = new List<Empresa>();
            this._categorias = new List<Categoria>();
            this._liquidaciones = new List<Liquidacion>();
        }

        public void AgregarCategoria(Categoria nuevaCategroia)
        {
            foreach (Categoria categoria in this._categorias)
            {
                if (categoria.IdCategoria==nuevaCategroia.IdCategoria)
                {
                    throw new Exception("La categoría ya existe");
                }
            }
            this._categorias.Add(nuevaCategroia);
        }

        public void AgregarEmpresa(Empresa nuevaEmpresa)
        {
            foreach (Empresa empresa in this._empresas)
            {
                if (nuevaEmpresa.Cuit==empresa.Cuit)
                {
                    throw new Exception("La empresa ya existe");
                }
            }
            this._empresas.Add(nuevaEmpresa);
        }

        public void AgregarEmpleado(Empresa empresa, Empleado nuevoEmpleado)
        {
            foreach (Empleado empleado in empresa.Empleados)
            {
                if (nuevoEmpleado.Cuil == empleado.Cuil)
                {
                    throw new Exception("El empleado ya existe en la empresa");
                }
            }
            empresa.Empleados.Add(nuevoEmpleado);
        }

    }
}
