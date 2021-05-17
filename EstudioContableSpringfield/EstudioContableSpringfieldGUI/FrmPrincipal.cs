﻿using System;
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
    }
}
