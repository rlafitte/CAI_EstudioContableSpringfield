using Estudio.Libreria.Entidades;
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
    public partial class FrmReportes : Form
    {
        private EstudioContable nuevoEstudioContable;

        public FrmReportes()
        {
            InitializeComponent();
        }

        public FrmReportes(EstudioContable nuevoEstudioContable)
        {
            this.nuevoEstudioContable = nuevoEstudioContable;
            
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnEmpleXEmpre_Click(object sender, EventArgs e)
        {
            List<Empresa> _listA = nuevoEstudioContable.Empresas;

            foreach(Empresa _em in _listA)
            {
                
                lstReporte.Items.Add(_em.Nombre);
                lstReporte.Items.Add(_em.ListaEmpleados());
                lstReporte.Items.Add(Environment.NewLine);
            }

        }
    }
}
