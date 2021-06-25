
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

        private EmpresaNegocio _empresaNegocio;
        private EmpleadoNegocio _empleadoNegocio;
        private CategoriaNegocio _categoriaNegocio;

        public FrmEmpleados()
        {
            
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
            CargarEmpresas();
            CargarCategorias();
            ResetearFormulario();
        }

        private void CargarCategorias()
        {
            this.cmbCategorias.DataSource = this._categoriaNegocio.Traer();
            this.cmbCategorias.ValueMember = "Id";
            this.cmbCategorias.DisplayMember = "Nombre";
        }

        private void CargarEmpresas()
        {
            this.cmbEmpresas.DataSource = this._empresaNegocio.TraerConEmpleados();
            this.cmbEmpresas.ValueMember = "Cuit";
            this.cmbEmpresas.DisplayMember = "RazonSocial";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposFormulario();


                TransactionResult resultado = this._empleadoNegocio.Agregar(MapearEmpleado());
                

                if (resultado.IsOk)
                    CargarEmpresas();

                MessageBox.Show(resultado.DarMensaje());
                ResetearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Empleado MapearEmpleado()
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            DateTime fechaNacim = this.dTPFechaNacimiento.Value;
            Int64 cuil = Int64.Parse(this.txtCUIL.Text);
            Empresa empresaSeleccionada = (Empresa)cmbEmpresas.SelectedItem;
            Categoria categoriaSeleccionada = (Categoria)cmbCategorias.SelectedItem;

            Empleado nuevoEmpleado = new Empleado(nombre, apellido, fechaNacim, cuil, empresaSeleccionada.Id, categoriaSeleccionada.Id);
            return nuevoEmpleado;
        }

        private void ValidarCamposFormulario()
        {
            if (this.txtNombre.Text == "" ||
                this.txtApellido.Text == "" ||
                this.dTPFechaNacimiento.Text == "" ||
                this.txtCUIL.Text == "" ||
                this.cmbEmpresas.SelectedIndex == -1||
                this.cmbCategorias.SelectedIndex == -1)
            {
                throw new Exception("Los campos marcados con * no deben estar vacíos");
            }

            if (!Int64.TryParse(this.txtCUIL.Text, out Int64 cuil))
                throw new Exception("CUIL no numérico, corrija la entrada por favor");

            bool esMayorDeEdad = ValidarMayoriaEdad();

            if (!esMayorDeEdad)
                throw new Exception("El empleado no cumple la mayoría de edad");
        }

        private void ResetearFormulario()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.dTPFechaNacimiento.Text = "";
            this.txtCUIL.Text = "";
            this.txtLegajo.Text = "";
            this.cmbEmpresas.Text = "";
            this.cmbCategorias.Text = "";
            this.cmbEmpleados.Text = "";
            this.cmbCategorias.SelectedIndex = -1;

            this.txtNombre.Enabled = true;
            this.txtApellido.Enabled = true;
            this.dTPFechaNacimiento.Enabled = true;
            this.txtCUIL.Enabled = true;
        }

        private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpleados();
            //ResetearFormulario();
        }        

        private void CargarEmpleados()
        {
            if (cmbEmpresas.DataSource != null)
            {
                Empresa empresaSeleccionada = (Empresa)cmbEmpresas.SelectedItem;
                cmbEmpleados.DataSource = null;
                cmbEmpleados.DataSource = empresaSeleccionada.Empleados;
                this.cmbEmpleados.ValueMember = "Legajo";
                this.cmbEmpleados.DisplayMember = "ApellidoYNombre";
                
                CargarDatosEmpleado();


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            CargarDatosEmpleado();
        }

        private void DeshabilitarCampos()
        {
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.dTPFechaNacimiento.Enabled = false;
            this.txtCUIL.Enabled = false;
        }

        private void CargarDatosEmpleado()
        {
            if(cmbEmpleados.DataSource!=null)
            {
                Empleado empleadoSeleccionado = (Empleado)cmbEmpleados.SelectedItem;
                if (empleadoSeleccionado != null && empleadoSeleccionado.Nombre != "<<NUEVO EMPLEADO>>")
                {

                this.txtNombre.Text = empleadoSeleccionado.Nombre;
                this.txtApellido.Text = empleadoSeleccionado.Apellido;
                this.dTPFechaNacimiento.Text = empleadoSeleccionado.FechaNacimiento;
                this.txtCUIL.Text = empleadoSeleccionado.Cuil.ToString();
                this.txtLegajo.Text = empleadoSeleccionado.Legajo.ToString();
                    if (empleadoSeleccionado.Categoria != null)
                    {

                this.cmbCategorias.SelectedValue = empleadoSeleccionado.Categoria.Id;
                    }
                }
                else
                {
                    ResetearFormulario();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleados.SelectedItem == null)
                    throw new Exception("Debe seleccionar un empleado");

                Empleado empleadoSeleccionado = (Empleado)cmbEmpleados.SelectedItem;

                var confirmResult = MessageBox.Show($"¿Está seguro que desea eliminar al empleado {empleadoSeleccionado.ApellidoYNombre}?", "Confirme eliminación", MessageBoxButtons.OKCancel);
                if(confirmResult==DialogResult.OK)
                {
                    TransactionResult resultado = this._empleadoNegocio.Eliminar(empleadoSeleccionado);

                    if (resultado.IsOk)
                        CargarEmpresas();

                    MessageBox.Show(resultado.DarMensaje());
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada");
                }
                ResetearFormulario();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleados.SelectedItem == null || cmbEmpleados.SelectedIndex == 0)
                    throw new Exception("Debe seleccionar un empleado");

                ValidarCamposFormulario();

                Empleado empleadoSeleccionado = (Empleado)cmbEmpleados.SelectedItem;
                Categoria categoriaSeleccionada = (Categoria)cmbCategorias.SelectedItem;

                empleadoSeleccionado.IdCategoria = categoriaSeleccionada.Id;

                TransactionResult resultado = this._empleadoNegocio.Modificar(empleadoSeleccionado);

                if (resultado.IsOk)
                    CargarEmpresas();

                MessageBox.Show(resultado.DarMensaje());
                ResetearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool ValidarMayoriaEdad()
        {
            if (DateTime.Now.Year - dTPFechaNacimiento.Value.Year >= 18)
                return true;

            return false;
        }
    }
}
