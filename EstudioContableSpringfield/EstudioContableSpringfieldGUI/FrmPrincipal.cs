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
    public partial class FrmPrincipal : Form
    {
        private EstudioContable _nuevoEstudioContable;

        public FrmPrincipal()
        {
            _nuevoEstudioContable = new EstudioContable();
            InitializeComponent();

            
            Categoria cat1 = new Categoria(1, "ADM A", 57000, 19.5, true, "130 / 75");
            Categoria cat2 = new Categoria(2, "VEND B", 68500, 19.5, true, "130 / 75");
            Categoria cat3 = new Categoria(3, "AUXILIAR A", 78690.78, 19, true, "108 / 75");
            Categoria cat4 = new Categoria(4, "ADMINISTRATIVO", 95000, 17, false, "");
            _nuevoEstudioContable.Categorias.Add(cat1);
            _nuevoEstudioContable.Categorias.Add(cat2);
            _nuevoEstudioContable.Categorias.Add(cat3);
            _nuevoEstudioContable.Categorias.Add(cat4);
            Empresa emp1 = new Empresa(1, "EMPRESA 1 ", "33 -33333333 - 3", "COMERCIALIZACION", "01/01/0001", "DOMICILIO EMPRESA1");
            Empresa emp2 = new Empresa(2, "EMPRESA 2 ", "33 - 33333333 - 4", "FABRICACION", "01/01/0002", "DOMICILIO EMPRESA2");
            Empresa emp3 = new Empresa(3, "EMPRESA 3 ", "33 - 33333333 - 5", "IMPORTACION", "01/01/0003", "DOMICILIO EMPRESA3");
            Empresa emp4 = new Empresa(4, "EMPRESA 4 ", "33 - 33333333 - 6", "IMPORTACION", "01/01/0004", "DOMICILIO EMPRESA4");
            _nuevoEstudioContable.Empresas.Add(emp1);
            _nuevoEstudioContable.Empresas.Add(emp2);
            _nuevoEstudioContable.Empresas.Add(emp3);
            _nuevoEstudioContable.Empresas.Add(emp4);
            Empleado emple1 = new Empleado("PEDRO", "AAAAAAAAAA", 32222222, 1, "DDDDDDDD", "27322222227", "EMPRESA 1", cat1);
            Empleado emple2 = new Empleado("JOSE", "AAAAAAAAAA", 32222222, 1, "DDDDDDDD", "27322222227", "EMPRESA 1", cat1);
            Empleado emple3 = new Empleado("MARIA", "AAAAAAAAAA", 32222222, 1, "DDDDDDDD", "27322222227", "EMPRESA 2", cat4);
            Empleado emple4 = new Empleado("PABLO", "AAAAAAAAAA", 32222222, 1, "DDDDDDDD", "27322222227", "EMPRESA 1", cat3);
            Empleado emple5 = new Empleado("PEDRO", "AAAAAAAAAA", 32222222, 1, "DDDDDDDD", "27322222227", "EMPRESA 3", cat1);
            Empleado emple6 = new Empleado("JUANA", "AAAAAAAAAA", 32222222, 1, "DDDDDDDD", "27322222227", "EMPRESA 4", cat2);
            emp1.Empleados.Add(emple1);
            emp1.Empleados.Add(emple2);
            emp2.Empleados.Add(emple3);
            emp1.Empleados.Add(emple4);
            emp3.Empleados.Add(emple5);
            emp4.Empleados.Add(emple6);
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ASD", 1, 2020, "MENSUAL", DateTime.Today, emp1, emple1));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ASD", 1, 2020, "MENSUAL", DateTime.Today, emp1, emple1));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ASD", 1, 2020, "SAC", DateTime.Today, emp2, emple2));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ZXC", 1, 2020, "MENSUAL", DateTime.Today, emp3, emple3));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("ZXC", 1, 2020, "MENSUAL", DateTime.Today, emp4, emple4));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("TYU", 1, 2020, "MENSUAL", DateTime.Today, emp2, emple5));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("TYU", 1, 2020, "VAC", DateTime.Today, emp3, emple6));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("BBB", 1, 2020, "MENSUAL", DateTime.Today, emp4, emple1));
            _nuevoEstudioContable.Liquidaciones.Add(new Liquidacion("BBB", 1, 2020, "1 QUINCENA", DateTime.Today, emp1, emple2));
            

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
            FrmEmpresas frm = new FrmEmpresas(_nuevoEstudioContable);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm = new FrmEmpleados(_nuevoEstudioContable);
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
    }
}
