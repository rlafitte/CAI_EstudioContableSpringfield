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
            this.comboBox1.DataSource = this._estContable.Empresas;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.ValueMember = "Id";
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

                string codLiq = this.txtCodigo.Text;
                int mes = Convert.ToInt32(this.txtMes.Text);
                int año = Convert.ToInt32(this.txtAño.Text);
                string tipo  = this.txtTipo.Text;
                DateTime fecha = this.dateFechaPago.Value;
                string empresaTexto = this.comboBox1.Text;
                string empleadoTexto = this.comboBox2.Text;
                double bruto = Convert.ToDouble(this.txtBruto.Text);
                double retenciones = Convert.ToDouble(this.txtRetenciones.Text);
                double neto = bruto * (1 - retenciones);

                Empresa empresa = BuscarEmpresa(empresaTexto);
                Empleado empleado = BuscarEmpleado(empleadoTexto, empresa);

                Liquidacion nuevaLiq= new Liquidacion(codLiq, mes, año, tipo, fecha, empresa, empleado , bruto, retenciones, neto);

                this._estContable.Liquidaciones.Add(nuevaLiq);

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
            this.comboBox1.Text == "" ||
            this.comboBox2.Text == "" ||
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
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
            this.txtBruto.Text = "";
            this.txtRetenciones.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEmpresa = this.comboBox1.Text;

            Empresa empresaFiltro = this._estContable.Empresas.SingleOrDefault(emp => emp.Nombre == nombreEmpresa);

            this.comboBox2.DataSource = empresaFiltro.Empleados;
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.ValueMember = "Legajo";
        }

        private Empresa BuscarEmpresa(string nombreEmpresa)
        {
            Empresa empresaEncontrada = this._estContable.Empresas.SingleOrDefault(empresa => empresa.Nombre == nombreEmpresa);

            if (empresaEncontrada is null)
                throw new Exception("No existe la empresa");

            return empresaEncontrada;
        }

        private Empleado BuscarEmpleado(string nombreEmpleado, Empresa empresa)
        {
            Empleado empleadoEncontrado = empresa.Empleados.SingleOrDefault(empleado => empleado.Nombre == nombreEmpleado);

            if (empleadoEncontrado is null)
                throw new Exception("No existe el empleado");

            return empleadoEncontrado;
        }
    }
}
