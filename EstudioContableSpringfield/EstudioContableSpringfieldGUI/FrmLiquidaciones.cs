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
    public partial class FrmLiquidacion : Form
    {

        private EstudioContable _estContable;


        public FrmLiquidacion(EstudioContable estudio)
        {
            this._estContable = estudio;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Owner.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposFormulario();

                Empresa empre = new Empresa();
                Empleado emple = new Empleado();
                int codLiq = Convert.ToInt32(this.txtCodigo.Text);
                int mes = Convert.ToInt32(this.txtMes.Text);
                int año = Convert.ToInt32(this.txtAño.Text);
                string tipo  = this.txtTipo.Text;
                DateTime fecha = this.dateFechaPago.Value;
                //string empresa = this.txtEmpresa.Text;
                //string empleado = this.txtEmpleado.Text;
                double bruto = Convert.ToDouble(this.txtBruto.Text);
                double retenciones = Convert.ToDouble(this.txtRetenciones.Text);
                double neto = bruto * (1 - retenciones);
                Liquidacion nuevaLiq= new Liquidacion(codLiq, mes, año, tipo, fecha, empre, emple, bruto, retenciones, neto);
                {
                    //emple.LiqEmpleado.AddRange(nuevaLiq);

                    //this._estContable..Add(nuevaEmpresa);
                }

                MessageBox.Show("Liquidación agregada correctamente.");
                ResetearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarCamposFormulario()
        {
            if (
                this.dateFechaPago.Value > System.DateTime.Today)
                throw new Exception("La fecha no puede ser mayor a la fecha actual");
            if (
            this.txtCodigo.Text == "" ||
            this.txtMes.Text == "" ||
            this.txtAño.Text == "" ||
            this.txtTipo.Text == "" ||
            this.txtEmpresa.Text == "" ||
            this.txtEmpleado.Text == "" ||
            this.txtBruto.Text == "" ||
            this.txtRetenciones.Text == ""
            )
                throw new Exception("Los campos no deben estar vacíos");
        }

        private void ResetearFormulario()
        {

            this.dateFechaPago.Value = System.DateTime.Today;
            this.txtCodigo.Text = "";
            this.txtMes.Text = "";
            this.txtAño.Text = "";
            this.txtTipo.Text = "";
            this.txtEmpresa.Text = "";
            this.txtEmpleado.Text = "";
            this.txtBruto.Text = "";
            this.txtRetenciones.Text = "";
        }
    
    }
}
