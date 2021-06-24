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
            btnEliminarLiq.Enabled = false;
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
            btnEliminarLiq.Enabled = false;

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
            CargarLiquidaciones();

        }

        private void CargarLiquidaciones()
        {
            List<Empleado> _empleados = _repoNeg.Traer().OrderBy(o=>o.IdCategoria).ToList();
            
            lstReporte.DataSource = null;
            lstReporte.Items.Clear();
            _listaLiquidaciones = _liquidacionNegocio.Traer();

            foreach (Empleado emp in _empleados)
            {

                lstReporte.Items.Add("--- Categoría: " + emp.IdCategoria + "---" + System.Environment.NewLine);
                foreach (Liquidacion liqXcat in _listaLiquidaciones)
                {
                    if (liqXcat.IdEmpleado != null && emp.Legajo != null)
                    {

                    if (liqXcat.IdEmpleado == emp.Legajo)
                    {
                        lstReporte.Items.Add(liqXcat);
                    }
                    }
                }

            }
            btnEliminarLiq.Enabled = true;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstReporte.Items.Clear();
            btnEliminarLiq.Enabled = false;
        }

        //private void btnEliminarLiq_Click(object sender, EventArgs e)
        //{
        //}

        private void btnEliminarLiq_Click_1(object sender, EventArgs e)
        {
            try
            {
            if (lstReporte.SelectedIndex < 0)
                {
                    throw new Exception("Seleccione una liquidación");
                }

                Liquidacion liqSeleccionada = (Liquidacion)lstReporte.SelectedItem;

                var confirmResult = MessageBox.Show($"¿Está seguro que desea eliminar la liquidación {liqSeleccionada.Id}?", "Confirme eliminación", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                TransactionResult resultado = this._liquidacionNegocio.Eliminar(liqSeleccionada);
                    //        TransactionResult resultado = this._empleadoNegocio.Eliminar(empleadoSeleccionado);

                    if (resultado.IsOk)
                    {
                        CargarLiquidaciones();
                        MessageBox.Show("Liquidación eliminada correctamente");
                    }         

                    else
                    {
                        MessageBox.Show("Eliminación cancelada");
                    }
                }
                CargarLiquidaciones();    

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

        }
    }
}
