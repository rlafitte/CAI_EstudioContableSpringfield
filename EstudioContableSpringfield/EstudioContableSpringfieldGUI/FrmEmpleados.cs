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
    public partial class FrmEmpleados : Form
    {
        private EstudioContable _estContable;
        private EmpresaNegocio _empresaNegocio;
        private EmpleadoNegocio _empleadoNegocio;
        private CategoriaNegocio _categoriaNegocio;

        public FrmEmpleados(EstudioContable estudio)
        {
            this._estContable = estudio;
            this._empresaNegocio = new EmpresaNegocio();
            this._empleadoNegocio = new EmpleadoNegocio();
            this._categoriaNegocio = new CategoriaNegocio();
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = this._empresaNegocio.Traer();
            this.comboBox1.ValueMember = "Cuit";
            this.comboBox1.DisplayMember = "RazonSocial";

            this.comboBox2.DataSource = this._categoriaNegocio.Traer();
            this.comboBox2.ValueMember = "Id";
            this.comboBox2.DisplayMember = "Nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposFormulario();

                string nombre = this.textBox1.Text;
                string apellido = this.textBox2.Text;
                DateTime fechaNacim = this.dateTimePicker1.Value;
                string direccion = this.textBox5.Text;
                string empresa = this.comboBox1.Text;


                if (!long.TryParse(this.textBox4.Text, out long cuil))
                    throw new Exception("CUIL no numérico, corrija la entrada por favor");

                if (!int.TryParse(this.textBox6.Text, out int legajo))
                    throw new Exception("CUIL no numérico, corrija la entrada por favor");

                Categoria categoria = (Categoria)comboBox2.SelectedItem;
                Empresa empresaEmpleado = this._estContable.Empresas.SingleOrDefault(emp => emp.RazonSocial.ToLower() == empresa.ToLower());

                Empleado nuevoEmpleado = new Empleado(nombre, apellido, legajo, direccion, cuil, empresaEmpleado, categoria, fechaNacim);

                TransactionResult resultado = this._empleadoNegocio.Agregar(nuevoEmpleado);

                MessageBox.Show($"Empleado agregado correctamente: {resultado.Id}");
                ResetearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarCamposFormulario()
        {
            if (this.textBox1.Text == "" ||
                this.textBox2.Text == "" ||
                this.dateTimePicker1.Text == "" ||
                this.textBox4.Text == "" ||
                this.textBox5.Text == "" ||
                this.textBox6.Text == "" ||
                this.comboBox1.SelectedIndex == -1||
                this.comboBox2.SelectedIndex == -1)
            {
                throw new Exception("Los campos marcados con * no deben estar vacíos");
            }
        }

        private void ResetearFormulario()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.dateTimePicker1.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
        }
    }
}
