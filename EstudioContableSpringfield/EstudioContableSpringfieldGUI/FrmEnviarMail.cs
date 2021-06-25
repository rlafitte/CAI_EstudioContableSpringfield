using Estudio.Entidades.Entidades;
using Estudio.Libreria.Modelos;
using Estudio.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudioContableSpringfieldGUI
{
    public partial class FrmEnviarMail : Form
    {
        LiquidacionNegocio _liquidacionNegocio;
        string _cuerpoMensaje;

        public FrmEnviarMail(string cuerpoMensaje)
        {
            this._liquidacionNegocio = new LiquidacionNegocio();
            this._cuerpoMensaje = cuerpoMensaje;
            InitializeComponent();
        }

        private void FrmEnviarMail_Load(object sender, EventArgs e)
        {
            CargarMensaje();
        }

        private void CargarMensaje()
        {
            txtMensaje.Text = this._cuerpoMensaje;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                Email email = new Email(txtPara.Text, txtAsunto.Text, txtMensaje.Text);
                TransactionResult resultado = this._liquidacionNegocio.EnviarReporte(email);
                MessageBox.Show(resultado.DarMensaje());
                this.Owner.Show();
                this.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void ValidarCampos()
        {
            if (txtAsunto.Text == string.Empty)
                throw new Exception("Asunto: El campo no puede estar vacío");

            if (txtPara.Text == string.Empty)
                throw new Exception("Para: Debe ingresar un email");

            if (txtMensaje.Text == string.Empty)
                throw new Exception("Mensaje: El campo no puede estar vacío");
        }
    }
}
