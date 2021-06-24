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
    public partial class FrmEmpresas : Form
    {
        private EstudioContable _estContable;
        private EmpresaNegocio _empresaNegocio;

        public FrmEmpresas()
        {
            this._empresaNegocio = new EmpresaNegocio();
            
            InitializeComponent();
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            this.dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";

            CargarEmpresas();
        }
        private void CargarEmpresas()
        {
            try
            {
                cmbEmpresas.DataSource = null;
                cmbEmpresas.DataSource = this._empresaNegocio.Traer();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposFormulario();

                string nombre = this.textBox1.Text;
                long cuit = long.Parse(this.textBox2.Text);
                string domicilio = this.textBox5.Text;

                Empresa nuevaEmpresa = new Empresa(nombre, cuit, domicilio);

                TransactionResult resultado = this._empresaNegocio.Agregar(nuevaEmpresa);

                MessageBox.Show(resultado.DarMensaje());
                CargarEmpresas();
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
            this.textBox1.Text == "" ||
            this.textBox2.Text == "" ||
            this.textBox5.Text == "")
                throw new Exception("Los campos no deben estar vacíos");
        }

        private void ResetearFormulario()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox5.Text = "";
            this.dateTimePicker.Value = System.DateTime.Now;
        }

        private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpresas.SelectedIndex == 0)
            {
                AgregarBloqueado();
            }
            else
            {
                MapearDatos((Empresa)cmbEmpresas.SelectedItem);
                AgregarDesbloqueado();
            }
        }

        private void MapearDatos(Empresa empresaSeleccionada)
        {
            textBox1.Text = empresaSeleccionada.RazonSocial;
            textBox2.Text = empresaSeleccionada.Cuit.ToString();
            if (empresaSeleccionada.FechaAlta.Year > 1900) 
            { 
            dateTimePicker.Value = empresaSeleccionada.FechaAlta;
            }
            textBox5.Text = empresaSeleccionada.Domicilio;
        }

        private void AgregarDesbloqueado()
        {
            btnAgregar.Enabled = true;
        }

        private void AgregarBloqueado()
        {
            ResetearFormulario();
            btnAgregar.Enabled = false;
        }
    }
}
