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
        private CategoriaNegocio categoriaNegocio;
        private EstudioContable _estContable;

        public FrmCategorias(EstudioContable estudio)
        {
            this._estContable = estudio;
            this.categoriaNegocio = new CategoriaNegocio();
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
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
                Categoria categoria = null;
                ValidarCamposFormulario();
                categoria = new Categoria(txtNombre.Text, double.Parse(txtBasico.Text), double.Parse(txtPorcRet.Text), txtCCTNum.Text);
                TransactionResult resultado = categoriaNegocio.Agregar(categoria);
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
                txtBasico.Text == string.Empty ||
                txtPorcRet.Text == string.Empty
                )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
            else if (
                !double.TryParse(txtBasico.Text, out double basico )||
                !double.TryParse(txtPorcRet.Text, out double porcRet ) 
                )
            {
                throw new Exception("Debe ingresar un numero");
            }
        }

        private void ResetearFormulario()
        {
            txtNombre.Text = string.Empty;
            txtCCTNum.Text = string.Empty;
            txtBasico.Text = string.Empty;
            txtPorcRet.Text = string.Empty;
        }

    }
}
