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
    public partial class FrmPrincipal : Form
    {
        private EstudioContable _nuevoEstudioContable;

        public FrmPrincipal()
        {
            _nuevoEstudioContable = new EstudioContable();
            InitializeComponent();

            /*
            Categoria cat1 = new Categoria("ADM A", 57000, 19.5, "130 / 75");
            Categoria cat2 = new Categoria( "VEND B", 68500, 19.5,"130 / 75");
            Categoria cat3 = new Categoria( "AUXILIAR A", 78690.78, 19, "108 / 75");
            Categoria cat4 = new Categoria( "ADM B", 95000, 17,  "");
            _nuevoEstudioContable.Categorias.Add(cat1);
            _nuevoEstudioContable.Categorias.Add(cat2);
            _nuevoEstudioContable.Categorias.Add(cat3);
            _nuevoEstudioContable.Categorias.Add(cat4);
            Empresa emp1 = new Empresa("Danonix ", Convert.ToInt32(3034200673), "Viamonte 323");
            Empresa emp2 = new Empresa("Requiem ", Convert.ToInt32(30358833314),  "Monseñor Bufano 1715");
            Empresa emp3 = new Empresa("Hachiko ", Convert.ToInt32(332133387845),  "Diagonal norte 777");
            Empresa emp4 = new Empresa("Vasere SRL ", Convert.ToInt32(333312341336),  "F. J. Oro 1744");
            _nuevoEstudioContable.Empresas.Add(emp1);
            _nuevoEstudioContable.Empresas.Add(emp2);
            _nuevoEstudioContable.Empresas.Add(emp3);
            _nuevoEstudioContable.Empresas.Add(emp4);
            Empleado emple1 = new Empleado("MAXIMO", "COSETTI", 36088123,  "SIEMPREVIVA 123", Convert.ToInt32(3034200673), emp3, cat1, DateTime.Today);
            Empleado emple2 = new Empleado("CHUCK", "NORRIS", 35123122, "DDDDDDDD", Convert.ToInt32(30324200673), emp4, cat1, DateTime.Today);
            Empleado emple3 = new Empleado("MARIO", "SANTOS", 29225241, "DDDDDDDD", Convert.ToInt32(30342500673), emp2, cat4, DateTime.Today);
            Empleado emple4 = new Empleado("PABLO", "LAMPONNE", 17293465,"DDDDDDDD", Convert.ToInt32(30344200673), emp4, cat3, DateTime.Today);
            Empleado emple5 = new Empleado("EMILIO", "RAVENNA", 20416355,  "DDDDDDDD", Convert.ToInt32(303428700673), emp1, cat1, DateTime.Today);
            Empleado emple6 = new Empleado("NATALIA", "OREIRO", 35508182, "DDDDDDDD", Convert.ToInt32(3034258500673), emp3, cat2, DateTime.Today);
            emp1.Empleados.Add(emple1);
            emp1.Empleados.Add(emple2);
            emp2.Empleados.Add(emple3);
            emp1.Empleados.Add(emple4);
            emp3.Empleados.Add(emple5);
            emp4.Empleados.Add(emple6);
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ASD", 4, 2021, "MENSUAL", DateTime.Today, emp1, emple1));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ASD", 7, 2020, "MENSUAL", DateTime.Today, emp1, emple1));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ASD", 2, 2021, "SAC", DateTime.Today, emp2, emple2));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ZXC", 7, 2020, "MENSUAL", DateTime.Today, emp3, emple3));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ZXC", 5, 2020, "MENSUAL", DateTime.Today, emp4, emple4));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("TYU", 5, 2020, "MENSUAL", DateTime.Today, emp2, emple5));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("TYU", 9, 2020, "VAC", DateTime.Today, emp3, emple6));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("BBB", 10, 2020, "MENSUAL", DateTime.Today, emp4, emple1));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("BBB", 12, 2020, "1 QUINCENA", DateTime.Today, emp1, emple2));
            */

        }

        private void btnLiquidaciones_MouseHover(object sender, EventArgs e)
        {
            btnLiquidaciones.BackColor = Color.Gray;
        }

        private void btnLiquidaciones_MouseLeave(object sender, EventArgs e)
        {

            btnLiquidaciones.BackColor = Color.White;
        }

        private void btnEmpresas_MouseHover(object sender, EventArgs e)
        {
            btnEmpresas.BackColor = Color.Gray;
        }
        private void btnEmpresas_MouseLeave(object sender, EventArgs e)
        {
            btnEmpresas.BackColor = Color.White;

        }

        private void btnCategorias_MouseHover(object sender, EventArgs e)
        {
            btnCategorias.BackColor = Color.Gray;
        }

        private void btnCategorias_MouseLeave(object sender, EventArgs e)
        {

            btnCategorias.BackColor = Color.White;
        }

        private void btnReportes_MouseHover(object sender, EventArgs e)
        {

            btnReportes.BackColor = Color.Gray;
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.White;

        }

        private void btnEmpleados_MouseHover(object sender, EventArgs e)
        {
            btnEmpleados.BackColor = Color.Gray;

        }

        private void btnEmpleados_MouseLeave(object sender, EventArgs e)
        {

            btnEmpleados.BackColor = Color.White;
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            FrmEmpresas frm = new FrmEmpresas();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm = new FrmEmpleados();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnLiquidaciones_Click(object sender, EventArgs e)
        {
            FrmLiquidacion frm = new FrmLiquidacion(_nuevoEstudioContable);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frm = new FrmCategorias (_nuevoEstudioContable);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            List<Liquidacion> listaLiquidaciones = _nuevoEstudioContable.Liquidaciones;
            FrmConsulta frm = new FrmConsulta(listaLiquidaciones);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
            FrmReportes frm = new FrmReportes(_nuevoEstudioContable);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
    }
}
