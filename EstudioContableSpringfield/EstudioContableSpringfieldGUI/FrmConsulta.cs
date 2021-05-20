using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estudio.Libreria.Entidades;

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnConsultaLiquidaciones_Click(object sender, EventArgs e)
        {
            try
            {
                this.list1.DataSource = null;
                this.list1.Items.Clear();
                ValidarCamposFormulario();
                string codLiquidacion = this.textBox1.Text;
                List<Liquidacion> listaLiquidaciones = ValidarCodigo(codLiquidacion);
                this._liquidacionesTotales = listaLiquidaciones;

                this.textBoxCodReadOnly.Text = codLiquidacion;
                this.list1.DataSource = null;
                this.list1.DataSource = this._liquidacionesTotales;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarCamposFormulario()
        {
            if (this.textBox1.Text == "")
                throw new Exception("Los campos no deben estar vacíos");
            this.textBox1.Text = this.textBox1.Text.ToUpper();
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

        private void btnConsultaEmpresa_Click(object sender, EventArgs e)
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            foreach (Liquidacion liq in this._liquidacionesTotales)
            {
                if (!listaEmpresas.Contains(liq.Empresa))
                    listaEmpresas.Add(liq.Empresa);
            }

            this.list1.DataSource = null;
            this.list1.DataSource = listaEmpresas;
        }

        private void btnConsultaEmpleado_Click(object sender, EventArgs e)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            foreach (Liquidacion liq in this._liquidacionesTotales)
            {
                if (!listaEmpleados.Contains(liq.Empleado))
                    listaEmpleados.Add(liq.Empleado);
            }

            this.list1.DataSource = null;
            this.list1.DataSource = listaEmpleados;
        }

        private void btnConsultaCategoria_Click(object sender, EventArgs e)
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            foreach (Liquidacion liq in this._liquidacionesTotales)
            {
                bool existe = false;
                foreach (Categoria cat in listaCategorias)
                {
                    if (cat.IdCategoria==liq.Categoria.IdCategoria)
                        existe = true;
                }
                if (!existe)
                    listaCategorias.Add(liq.Categoria);
            }

            this.list1.DataSource = null;
            this.list1.DataSource = listaCategorias;
        }
    }
}
