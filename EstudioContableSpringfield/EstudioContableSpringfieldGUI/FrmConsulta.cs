﻿using System;
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
    public partial class FrmConsulta : Form
    {
        private List<Liquidacion> _listaLiquidaciones;
        private List<Liquidacion> _liquidacionesXCodigo;
        private LiquidacionNegocio _liqNeg;
        private EmpleadoNegocio _empleNeg;
        private EmpresaNegocio _empreNeg;
        private List<Empresa> listaEmpresas;

        public FrmConsulta(List<Liquidacion> listaLiq)
        {
            this._listaLiquidaciones = listaLiq;
            this._liquidacionesXCodigo = new List<Liquidacion>();
            this._liqNeg = new LiquidacionNegocio();
            this._empleNeg = new EmpleadoNegocio();
            this._empreNeg = new EmpresaNegocio();
            InitializeComponent();
        }

        private void btnConsultaLiquidaciones_Click(object sender, EventArgs e)
        {
            try
            {
                VaciarLista();
                ValidarCamposFormulario();
                string codTransferencia = ((Liquidacion)this.comboBox1.SelectedItem).CodigoTransferencia;
                List<Liquidacion> listaLiquidacionesXCodigo = ValidarCodigo(codTransferencia);
                this._liquidacionesXCodigo = listaLiquidacionesXCodigo;

                this.list1.DataSource = null;
                this.list1.DataSource = this._liquidacionesXCodigo;

                this.btnConsultaEmpresa.Enabled = true;
                this.btnConsultaEmpleado.Enabled = true;
                this.btnConsultaCategoria.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultaEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCodigoReadOnly();


                List<Empresa> listaSalida = new List<Empresa>();
                foreach (Liquidacion liq in this._liquidacionesXCodigo)
                {

                    foreach (Empresa emp in listaEmpresas)
                    {
                        foreach(Empleado _empleado in emp.Empleados)
                        {


                            if (_empleado.Legajo == liq.IdEmpleado)
                            {

                                if (!listaSalida.Contains(emp))
                                {
                                listaSalida.Add(emp);

                                }
                            }
                                
                
                        }
                    }
                }

                this.list1.DataSource = null;
                this.list1.DataSource = listaSalida;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultaEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCodigoReadOnly();


                List<Empleado> listaSalida = new List<Empleado>();
                List<Empleado> empleados = _empleNeg.Traer();
                foreach (Liquidacion liq in this._liquidacionesXCodigo)
                {

                    //foreach (Empresa emp in listaEmpresas)
                    //{
                        foreach (Empleado _empleado in empleados)
                        {


                            if (_empleado.Legajo == liq.IdEmpleado)
                            {

                                if (!listaSalida.Contains(_empleado))
                                {
                                    listaSalida.Add(_empleado);

                                }
                            }


                        }
                    //}
                }

                this.list1.DataSource = null;
                this.list1.DataSource = listaSalida;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    ValidarCodigoReadOnly();

            //    List<Empleado> listaEmpleados = _empleNeg.Traer();

            //    foreach (Liquidacion liq in this._liquidacionesXCodigo)
            //    {
            //        //if (!listaEmpleados.Contains(liq.IdEmpleado))
            //        //    listaEmpleados.Add(liq.Empleado);
            //    }

            //    this.list1.DataSource = null;
            //    this.list1.DataSource = listaEmpleados;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnConsultaCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCodigoReadOnly();

                List<Categoria> listaCategorias = new List<Categoria>();

                foreach (Liquidacion liq in this._liquidacionesXCodigo)
                {
                    if (!listaCategorias.Contains(liq.Categoria))
                        listaCategorias.Add(liq.Categoria);
                }

                this.list1.DataSource = null;
                this.list1.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private List<Liquidacion> ValidarCodigo(string codigo)
        {
            List<Liquidacion> liquidacionesPorCodigo = new List<Liquidacion>();

            foreach (Liquidacion liq in this._listaLiquidaciones)
            {
                if (liq.CodigoTransferencia == codigo)
                    liquidacionesPorCodigo.Add(liq);
            }

            if (liquidacionesPorCodigo.Count == 0)
                throw new Exception("No existen liquidaciones con ese código");

            return liquidacionesPorCodigo;
        }

        private void ValidarCodigoReadOnly()
        {
            if (this.comboBox1.SelectedItem == null)
                throw new Exception("Debe ingresar un código para filtrar");
        }

        private void ValidarCamposFormulario()
        {
            if (this.comboBox1.SelectedItem == null)
                throw new Exception("Los campos no deben estar vacíos");
        }

        private void VaciarLista()
        {
            this.list1.DataSource = null;
            this.list1.Items.Clear();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            _listaLiquidaciones = _liqNeg.Traer();
            comboBox1.DataSource = _listaLiquidaciones;
            comboBox1.DisplayMember = "CodigoTransferencia";
            listaEmpresas = _empreNeg.TraerConEmpleadosExistentes();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnConsultaEmpresa.Enabled = false;
            this.btnConsultaEmpleado.Enabled = false;
            this.btnConsultaCategoria.Enabled = false;
        }
    }
}
