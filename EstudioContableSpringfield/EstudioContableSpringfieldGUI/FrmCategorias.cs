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

namespace EstudioContableSpringfieldGUI
{
    public partial class FrmCategorias : Form
    {
        private EstudioContable _estContable;

        public FrmCategorias(EstudioContable estudio)
        {
            this._estContable = estudio;
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
                categoria = new Categoria(int.Parse(txtIdCategoria.Text), txtNombre.Text, double.Parse(txtBasico.Text), double.Parse(txtPorcRet.Text), chkCCTSi.Checked, txtCCTNum.Text);
                _estContable.AgregarCategoria(categoria);
                MessageBox.Show("Categoría agregada correctamente.");
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
                txtIdCategoria.Text == string.Empty ||
                txtNombre.Text == string.Empty ||
                (chkCCTSi.Checked && txtCCTNum.Text == string.Empty) ||
                txtBasico.Text == string.Empty ||
                txtPorcRet.Text == string.Empty
                )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
            else if (
                !int.TryParse(txtIdCategoria.Text, out int id) ||
                !double.TryParse(txtBasico.Text, out double basico )||
                !double.TryParse(txtPorcRet.Text, out double porcRet ) 
                )
            {
                throw new Exception("Debe ingresar un numero");
            }
        }

        private void ResetearFormulario()
        {
            txtIdCategoria.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkCCTSi.Text = string.Empty;
            txtCCTNum.Text = string.Empty;
            txtBasico.Text = string.Empty;
            txtPorcRet.Text = string.Empty;
            this.txtCCTNum.Enabled = false;
        }

        private void chkCCTSi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCCTSi.Checked)
            {
                this.txtCCTNum.Enabled = true;
            }
            if (chkCCTSi.Checked==false)
            {
                this.txtCCTNum.Enabled = false;
            }
        }
    }
}
