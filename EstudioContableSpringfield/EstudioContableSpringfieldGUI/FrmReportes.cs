using Estudio.Libreria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudioContableSpringfieldGUI
{
    public partial class FrmReportes : Form
    {
        private EstudioContable nuevoEstudioContable;

        public FrmReportes()
        {
            InitializeComponent();
        }

        public FrmReportes(EstudioContable nuevoEstudioContable)
        {
            this.nuevoEstudioContable = nuevoEstudioContable;
            
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
            this.Owner.Show();
            this.Close();
        }

        private void btnEmpleXEmpre_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
            List<Empresa> _listA = nuevoEstudioContable.Empresas;

            foreach(Empresa _em in _listA)
            {
                
                lstReporte.Items.Add(_em.Nombre);
                lstReporte.Items.Add(_em.ListaEmpleados());
                lstReporte.Items.Add(Environment.NewLine);
            }

        }

        private void btnLiqXCat_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
            List<Categoria> _listA = nuevoEstudioContable.Categorias;
            List<Liquidacion> _listB = nuevoEstudioContable.Liquidaciones;
            foreach(Categoria _cat in _listA)
            {
                lstReporte.Items.Add("Categoría: " + _cat.IdCategoria);
                //lstReporte.Items.Add(_cat.)
                foreach(Liquidacion _liq in _listB)
                {
                    if (_cat.IdCategoria == _liq.Categoria.IdCategoria)
                    {
                    lstReporte.Items.Add("---" + _liq.CodLiquidacion);
                    }
                }
                lstReporte.Items.Add(Environment.NewLine);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
        }
    }
}
