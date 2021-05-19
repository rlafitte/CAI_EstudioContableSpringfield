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
        private List<Liquidacion> _liquidacionesPorCodigo;

        public FrmConsulta(List<Liquidacion> listaLiq)
        {
            this._listaLiquidaciones = listaLiq;
            this._liquidacionesPorCodigo = new List<Liquidacion>();
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposFormulario();
                string codLiquidacion = this.textBox1.Text;
                CargarListaPorCodLiquidacion(codLiquidacion, "liquidaciones");
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
        }

        private void CargarListaPorCodLiquidacion(string codigo, string filtro)
        {
            this.listaLiquidaciones.Text = "";

            foreach (Liquidacion liq in this._listaLiquidaciones)
            {
                if (liq.CodLiquidacion == codigo)
                    this._liquidacionesPorCodigo.Add(liq);
            }

            if (this._liquidacionesPorCodigo.Count == 0)
                throw new Exception("No existen liquidaciones con ese código");

            this.listaLiquidaciones.DataSource = this._liquidacionesPorCodigo;
        }

        private void btnConsultaEmpresa_Click(object sender, EventArgs e)
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            foreach (Liquidacion liq in this._liquidacionesPorCodigo)
            {
                if (!listaEmpresas.Contains(liq.Empresa))
                    listaEmpresas.Add(liq.Empresa);
            }

            this.listaLiquidaciones.DataSource = null;
            this.listaLiquidaciones.DataSource = listaEmpresas;
        }
    }
}
