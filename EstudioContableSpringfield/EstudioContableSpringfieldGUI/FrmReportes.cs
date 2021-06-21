using Estudio.Entidades.Entidades;
using Estudio.Negocio;
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
        private LiquidacionNegocio _liquidacionNegocio;
        private List<Liquidacion> _listaLiquidaciones;
        private ReportesNegocio _repoNeg;


        public FrmReportes(EstudioContable nuevoEstudioContable)
        {
            this.nuevoEstudioContable = nuevoEstudioContable;
            this._liquidacionNegocio = new LiquidacionNegocio();
            this._repoNeg = new ReportesNegocio();
            this._listaLiquidaciones = new List<Liquidacion>();
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnEmpleXEmpre_Click(object sender, EventArgs e)
        {
            lstReporte.DataSource = null;
            lstReporte.Items.Clear();
            List<Empresa> _listA = (List<Empresa>)_repoNeg.TraerEmpresas();

            foreach(Empresa _em in _listA)
            {
                if (_em.Cuit> 0)
                {

                lstReporte.Items.Add(_em.RazonSocial);
                _em.ListaEmpleados(lstReporte);
                lstReporte.Items.Add(Environment.NewLine);
                }
            }

        }

        private void btnLiqXCat_Click(object sender, EventArgs e)
        {
            //List<Categoria> _listA = nuevoEstudioContable.Categorias;
            //List<Liquidacion> _listB = nuevoEstudioContable.Liquidaciones;
            //foreach(Categoria _cat in _listA)
            //{
            //    lstReporte.Items.Add("Categoría: " + _cat.IdCategoria);
            //    //lstReporte.Items.Add(_cat.)
            //    foreach(Liquidacion _liq in _listB)
            //    {
            //        if (_cat.IdCategoria == _liq.Categoria.IdCategoria)
            //        {
            //        lstReporte.Items.Add("---" + _liq.ToString());
            //        }
            //    }
            //    lstReporte.Items.Add(Environment.NewLine);
            //}
            List<Empleado> _empleados = _repoNeg.Traer();
            _empleados.OrderBy(o => o.Categoria);
            lstReporte.DataSource = null;
            lstReporte.Items.Clear();
            _listaLiquidaciones = _liquidacionNegocio.Traer();

            foreach (Empleado emp in _empleados)
            {

                lstReporte.Items.Add("---" + emp.IdCategoria + "---" + System.Environment.NewLine);
                foreach (Liquidacion liqXcat in _listaLiquidaciones)
                {
                    if (liqXcat.Empleado != null && emp.Cuil != null)
                    {

                    if (liqXcat.Empleado.Cuil == emp.Cuil)
                    {
                        lstReporte.Items.Add(liqXcat.ToString());
                    }
                    }
                }

            }
            //foreach (Liquidacion liq in _listaLiquidaciones)
            //{

            //    if (liq.Categoria != null)
            //    {
            //    lstReporte.Items.Add(liq.Categoria);

            //    }
            //    foreach(Liquidacion liqXcat in _listaLiquidaciones)
            //    {
            //        if (liqXcat.Categoria == liq.Categoria)
            //        {
            //            lstReporte.Items.Add(liqXcat);
            //        }
            //    }

            //}
            //lstReporte.DataSource = this._liquidacionNegocio.Traer();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
        }
    }
}
