using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liquidaciones
{
    public partial class Liquidacion : Form
    {
        public Liquidacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Owner.Show();
            this.Close();
        }
    }
}
