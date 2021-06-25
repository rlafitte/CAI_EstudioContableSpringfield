
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
        
        private LiquidacionNegocio _liquidacionNegocio;
        private EmpresaNegocio _empresaNegocio;
        private List<Liquidacion> _listaLiquidaciones;
        private List<string> _listaDatosVacios;


        public FrmReportes()
        {
            
            this._liquidacionNegocio = new LiquidacionNegocio();
            this._empresaNegocio = new EmpresaNegocio();
            this._listaLiquidaciones = new List<Liquidacion>();

            this._listaDatosVacios = new List<string>();
            this._listaDatosVacios.Add("No hay datos para mostrar.");
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
            CargarLiquidaciones();
            CargarCategorias();
            cmbEmpresas.Enabled = false;
            cmbCategorias.Enabled = false;
            btnEliminarLiq.Enabled = false;
            btnEliminarLiq.Hide();
        }

        private void CargarLiquidaciones()
        {
            this._listaLiquidaciones = this._liquidacionNegocio.TraerConCategoria();
        }

        private void CargarCategorias()
        {
            try
            {
                List<Categoria> categoriasConLiquidaciones = new List<Categoria>();
                categoriasConLiquidaciones.Add(new Categoria("  Seleccione", 0, ""));

                foreach (Liquidacion liquidacion in this._listaLiquidaciones)
                    if (!categoriasConLiquidaciones.Contains(liquidacion.Categoria))
                        categoriasConLiquidaciones.Add(liquidacion.Categoria);


                cmbCategorias.DataSource = null;
                cmbCategorias.DataSource = categoriasConLiquidaciones;
                cmbCategorias.DisplayMember = "NombreYConvenio";
                cmbCategorias.ValueMember = "Id";

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void CargarEmpresas()
        {
            try
            {
                cmbEmpresas.DataSource = null;
                cmbEmpresas.DataSource = this._empresaNegocio.TraerConEmpleadosExistentes();
                cmbEmpresas.DisplayMember = "RazonSocial";
                cmbEmpresas.ValueMember = "Cuit";
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListaEmpleados();
        }

        private void CargarListaEmpleados()
        {
            if (cmbEmpresas.DataSource != null)
            {
                Empresa empresaSeleccionada = (Empresa)cmbEmpresas.SelectedItem;
                lstReporte.DataSource = null;
                lstReporte.DataSource = empresaSeleccionada.Empleados;
                this.lstReporte.ValueMember = "Legajo";

                if (lstReporte.Items.Count == 0 && cmbEmpresas.SelectedIndex != 0)
                    CargarMensajeDatosVacios();
            }
        }


        private void cmbLiquidaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListaLiquidaciones();
            btnEliminarLiq.Enabled = false;
        }

        private void CargarListaLiquidaciones()
        {
            if (cmbCategorias.DataSource != null)
            {
                Categoria categoriaSeleccionada = (Categoria)cmbCategorias.SelectedItem;

                List<Liquidacion> liquidacionesPorCategoria = new List<Liquidacion>();
                foreach (Liquidacion liquidacion in this._listaLiquidaciones)
                    if (liquidacion.Categoria.Id == categoriaSeleccionada.Id)
                        liquidacionesPorCategoria.Add(liquidacion);

                lstReporte.DataSource = null;
                lstReporte.DataSource = liquidacionesPorCategoria;

                if (lstReporte.Items.Count == 0 && cmbEmpresas.SelectedIndex != 0)
                    CargarMensajeDatosVacios();
            }
        }

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
                CargarCategorias();
                LimpiarLista();
                btnEliminarLiq.Enabled = false;

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void LimpiarLista()
        {
            lstReporte.DataSource = null;
        }

        private void lstReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxLiq.Checked && cmbCategorias.SelectedIndex != 0)
                btnEliminarLiq.Enabled = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {            
            try
            {
                if (lstReporte.DataSource == null)
                    throw new Exception("Debe seleccionar un reporte");

                string cuerpoMensaje = "";
                foreach (object obj in lstReporte.Items)
                    cuerpoMensaje = cuerpoMensaje + obj.ToString() + "\n";

                FrmEnviarMail frmEnviar = new FrmEnviarMail(cuerpoMensaje);
                frmEnviar.Owner = this;
                frmEnviar.Show();
                this.Hide();

                CargarLiquidaciones();
                CargarCategorias();
                LimpiarLista();
                btnEliminarLiq.Enabled = false;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

        }

        private void checkBoxEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEmpleados.Checked)
            {
                cmbEmpresas.Enabled = true;
                cmbCategorias.SelectedIndex = 0;
                checkBoxLiq.Checked = false;
                cmbCategorias.Enabled = false;
                btnEliminarLiq.Hide();
            }
            else
                cmbEmpresas.Enabled = false;

            lstReporte.DataSource = null;
        }

        private void checkBoxLiq_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLiq.Checked)
            {
                cmbCategorias.Enabled = true;
                cmbEmpresas.SelectedIndex = 0;
                checkBoxEmpleados.Checked = false;
                cmbEmpresas.Enabled = false;
                btnEliminarLiq.Show();
            }
            else
            {
                cmbCategorias.Enabled = false;
                btnEliminarLiq.Hide();
            }

            lstReporte.DataSource = null;
        }

        private void CargarMensajeDatosVacios()
        {
            lstReporte.DataSource = _listaDatosVacios;
        }
    }
}
