using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estudio.Entidades.Entidades;

namespace EstudioContableSpringfieldGUI
{
    public partial class FrmConsulta : Form
    {
        private List<Liquidacion> _listaLiquidaciones;
        private List<Liquidacion> _liquidacionesTotales;

        public FrmConsulta(List<Liquidacion> listaLiq)
        {
            this._listaLiquidaciones = listaLiq;
            this._liquidacionesTotales = new List<Liquidacion>();
            InitializeComponent();
        }

        private void btnConsultaLiquidaciones_Click(object sender, EventArgs e)
        {
            try
            {
                VaciarLista();
                ValidarCamposFormulario();
                string codLiquidacion = this.comboBox1.SelectedItem.ToString();
                List<Liquidacion> listaLiquidaciones = ValidarCodigo(codLiquidacion);
                this._liquidacionesTotales = listaLiquidaciones;

                this.list1.DataSource = null;
                this.list1.DataSource = this._liquidacionesTotales;

                this.btnConsultaEmpresa.Enabled = true;
                this.btnConsultaEmpleado.Enabled = true;
                this.btnConsultaCategoria.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultaEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCodigoReadOnly();

                List<Empresa> listaEmpresas = new List<Empresa>();

                foreach (Liquidacion liq in this._liquidacionesTotales)
                {
                    if (!listaEmpresas.Contains(liq.Empresa))
                        listaEmpresas.Add(liq.Empresa);
                }

                this.list1.DataSource = null;
                this.list1.DataSource = listaEmpresas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultaEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCodigoReadOnly();

                List<Empleado> listaEmpleados = new List<Empleado>();

                foreach (Liquidacion liq in this._liquidacionesTotales)
                {
                    if (!listaEmpleados.Contains(liq.Empleado))
                        listaEmpleados.Add(liq.Empleado);
                }

                this.list1.DataSource = null;
                this.list1.DataSource = listaEmpleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultaCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCodigoReadOnly();

                List<Categoria> listaCategorias = new List<Categoria>();

                foreach (Liquidacion liq in this._liquidacionesTotales)
                {
                    if (!listaCategorias.Contains(liq.Categoria))
                        listaCategorias.Add(liq.Categoria);
                }

                this.list1.DataSource = null;
                this.list1.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private List<Liquidacion> ValidarCodigo(string codigo)
        {
            List<Liquidacion> liquidacionesPorCodigo = new List<Liquidacion>();

            foreach (Liquidacion liq in this._listaLiquidaciones)
            {
                if (liq.CodLiquidacion == codigo)
                    liquidacionesPorCodigo.Add(liq);
            }

            if (liquidacionesPorCodigo.Count == 0)
                throw new Exception("No existen liquidaciones con ese código");

            return liquidacionesPorCodigo;
        }

        private void ValidarCodigoReadOnly()
        {
            if (this.comboBox1.SelectedItem == null)
                throw new Exception("Debe ingresar un código para filtrar");
        }

        private void ValidarCamposFormulario()
        {
            if (this.comboBox1.SelectedItem == null)
                throw new Exception("Los campos no deben estar vacíos");
        }

        private void VaciarLista()
        {
            this.list1.DataSource = null;
            this.list1.Items.Clear();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            foreach (Liquidacion liq in this._listaLiquidaciones)
            {
                int i = comboBox1.FindStringExact(liq.CodLiquidacion);
                if (i < 0)
                    comboBox1.Items.Add(liq.CodLiquidacion);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnConsultaEmpresa.Enabled = false;
            this.btnConsultaEmpleado.Enabled = false;
            this.btnConsultaCategoria.Enabled = false;
        }
    }
}
