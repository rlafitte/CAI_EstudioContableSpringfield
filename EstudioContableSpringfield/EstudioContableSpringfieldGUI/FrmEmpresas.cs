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
    public partial class FrmEmpresas : Form
    {
        private EstudioContable _estContable;

        public FrmEmpresas(EstudioContable estudio)
        {
            this._estContable = estudio;
            InitializeComponent();
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

                string nombre = this.textBox1.Text;
                string cuil = this.textBox2.Text;
                string rubro = this.textBox3.Text;
                string inicioActiv = this.textBox4.Text;
                string domicilio = this.textBox5.Text;

                Empresa nuevaEmpresa = new Empresa(1, nombre, cuil, rubro, inicioActiv, domicilio);

                this._estContable.Empresas.Add(nuevaEmpresa);

                MessageBox.Show("Empresa agregada correctamente.");
                ResetearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarCamposFormulario()
        {
            if (
            this.textBox1.Text == "" ||
            this.textBox2.Text == "" ||
            this.textBox3.Text == "" ||
            this.textBox4.Text == "" ||
            this.textBox5.Text == "")
                throw new Exception("Los campos no deben estar vacíos");
        }

        private void ResetearFormulario()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
        }
    }
}