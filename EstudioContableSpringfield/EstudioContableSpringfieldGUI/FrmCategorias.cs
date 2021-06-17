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
    public partial class FrmCategorias : Form
    {
        private CategoriaNegocio _categoriaNegocio;
        private EstudioContable _estContable;

        public FrmCategorias(EstudioContable estudio)
        {
            this._estContable = estudio;
            this._categoriaNegocio = new CategoriaNegocio();
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            ResetearFormulario();
        }

        private void CargarCategorias()
        {
            try
            {
                cmbCategorias.DataSource = null;
                cmbCategorias.DataSource = this._categoriaNegocio.Traer();
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
                Categoria categoria = new Categoria(txtNombre.Text, double.Parse(txtBasico.Text), txtCCTNum.Text);
                TransactionResult resultado = _categoriaNegocio.Agregar(categoria);
                MessageBox.Show(resultado.ToString());
                ResetearFormulario();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void ValidarCamposFormulario()
        {
            if (
                txtNombre.Text == string.Empty ||
                txtBasico.Text == string.Empty
                )

                throw new Exception("Ningún campo puede estar vacío");

            if (
                !double.TryParse(txtBasico.Text, out double basico )
                )
                throw new Exception("Debe ingresar un numero");
        }

        private void ResetearFormulario()
        {
            txtNombre.Text = string.Empty;
            txtCCTNum.Text = string.Empty;
            txtBasico.Text = string.Empty;
        }
    }
}
