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
    public partial class FrmEmpleados : Form
    {
        private EstudioContable _estContable;

        public FrmEmpleados(EstudioContable estudio)
        {
            this._estContable = estudio;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = this._estContable.Empresas;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.ValueMember = "Cuit";

            this.comboBox2.DataSource = this._estContable.Categorias;
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.ValueMember = "IdCategoria";

            ResetearFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposFormulario();

                string nombre = this.textBox1.Text;
                string apellido = this.textBox2.Text;
                int dni;
                int legajo;
                try
                {
                dni = int.Parse(this.textBox3.Text);
                }
                catch
                {
                    throw new Exception("DNI no numérico, corrija la entrada por favor");
                }
                try
                {
                legajo = int.Parse(this.textBox6.Text);
                }
                catch
                {
                    throw new Exception("Legajo no numérico, corrija la entrada por favor");
                }
                string direccion = this.textBox5.Text;
                string cuil = this.textBox4.Text;
                string empresa = this.comboBox1.Text;

                Categoria categoria = (Categoria)comboBox2.SelectedItem;

                Empleado nuevoEmpleado = new Empleado(nombre, apellido, dni, legajo, direccion, cuil, empresa, categoria);

                Empresa empresaEmpleado = this._estContable.Empresas.SingleOrDefault(emp => emp.Nombre.ToLower() == empresa.ToLower());

                empresaEmpleado.Empleados.Add(nuevoEmpleado);

                MessageBox.Show("Empleado agregado correctamente.");
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
                this.textBox3.Text == "" ||
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
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
        }
    }
}
