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
using Estudio.Negocio;

namespace EstudioContableSpringfieldGUI
{
    public partial class FrmLiquidacion : Form
    {
        //Ya podría eliminarse lo de estudio contable
        private EstudioContable _estContable;

        private LiquidacionNegocio _liquidacionNegocio;
        private EmpresaNegocio _empresaNegocio;
        private EmpleadoNegocio _empleadoNegocio;


        public FrmLiquidacion(EstudioContable estudio)
        {
            this._estContable = estudio;

            this._liquidacionNegocio = new LiquidacionNegocio();
            this._empresaNegocio = new EmpresaNegocio();
            this._empleadoNegocio = new EmpleadoNegocio();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbEmpresas.DataSource = this._empresaNegocio.TraerConEmpleados();
            this.cmbEmpresas.ValueMember = "Cuit";
            this.cmbEmpresas.DisplayMember = "RazonSocial";

            this.dateFechaPago.Format = DateTimePickerFormat.Custom;
            this.dateFechaPago.CustomFormat = "dd/MM/yyyy";
            this.dtAnio.Format = DateTimePickerFormat.Custom;
            this.dtAnio.CustomFormat = "yyyy";
            this.dtAnio.ShowUpDown = true;
            this.dtMes.Format = DateTimePickerFormat.Custom;
            this.dtMes.CustomFormat = "MM";
            this.dtMes.ShowUpDown = true;

            txtPorcRet.Text = 17.ToString();

            ResetearFormulario();
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

                string codLiq = this.txtCodigo.Text.ToUpper();
                int mes = Convert.ToInt32(this.dtMes.Text);
                int año = Convert.ToInt32(this.dtAnio.Text);
                DateTime fechaPago = this.dateFechaPago.Value;
                Empleado empleado = (Empleado)cmbEmpleados.SelectedItem;

                //string empresaTexto = this.cmbEmpresas.Text;
                //string empleadoTexto = this.cmbEmpleados.Text;

                //Empresa empresa = BuscarEmpresa(empresaTexto);
                //Empleado empleado = BuscarEmpleado(empleadoTexto, empresa);

                Liquidacion nuevaLiq = new Liquidacion(codLiq, mes, año, fechaPago, empleado.Legajo, empleado.Categoria.SueldoBasico, double.Parse(txtPorcRet.Text));

                TransactionResult resultado = this._liquidacionNegocio.Agregar(nuevaLiq);

                MessageBox.Show(resultado.DarMensaje());
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
            this.cmbEmpresas.Text == "" ||
            this.cmbEmpleados.Text == "" 
            )
                throw new Exception("Los campos marcados con * no deben estar vacíos");
        }

        private void ResetearFormulario()
        {

            this.dateFechaPago.Value = System.DateTime.Today;
            this.txtCodigo.Text = "";
            this.cmbEmpresas.Text = "";
            this.cmbEmpleados.Text = "";
            this.txtBruto.Text = "";
            this.txtRetenciones.Text = "";
            this.txtNeto.Text = "";
            this.cmbEmpleados.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Creé un método que trae todo, se podría reemplazar lo que dejé comentado 

            //string nombreEmpresa = this.comboBox1.Text;
            //Empresa empresaSeleccionada = this._empresaNegocio.Traer().SingleOrDefault(empresa => empresa.RazonSocial.ToLower() == nombreEmpresa.ToLower());
            Empresa empresaSeleccionada = (Empresa)cmbEmpresas.SelectedItem;

            //List<Empleado> empleadosEmpresa = this._empleadoNegocio.Traer().FindAll(emp => emp.IdEmpresa == empresaSeleccionada.Id);
            List<Empleado> empleadosEmpresa = empresaSeleccionada.Empleados;

            this.cmbEmpleados.DataSource = empleadosEmpresa;
            this.cmbEmpleados.ValueMember = "Legajo";
            this.cmbEmpleados.DisplayMember = "ApellidoYNombre";
            this.cmbEmpleados.Enabled = true;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lo comenté porque me tira error y todavía no lo arreglé
            //MostrarMontosLiquidacion();
        }

        private void MostrarMontosLiquidacion()
        {
            if (cmbEmpleados.SelectedItem != null)
            {
                Empleado empleadoLiquidacion = (Empleado)cmbEmpleados.SelectedItem;

                //Hacer text box de porc retencion editable?
                Liquidacion calculoLiquidacion = new Liquidacion(empleadoLiquidacion.Categoria.SueldoBasico, double.Parse(txtPorcRet.Text));

                txtBruto.Text = calculoLiquidacion.Bruto.ToString("0.00");
                txtRetenciones.Text = calculoLiquidacion.Descuentos.ToString("0.00");
                txtNeto.Text = calculoLiquidacion.Neto.ToString("0.00");
            }
        }

        /* 
        private Empresa BuscarEmpresa(string nombreEmpresa)
        {
            Empresa empresaEncontrada = this._estContable.Empresas.SingleOrDefault(empresa => empresa.RazonSocial == nombreEmpresa);

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
        */
    }
}
