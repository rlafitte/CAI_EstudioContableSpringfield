﻿
namespace EstudioContableSpringfieldGUI
{
    partial class FrmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmpleXEmpre = new System.Windows.Forms.Button();
            this.btnLiqXCat = new System.Windows.Forms.Button();
            this.lstReporte = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarLiq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleXEmpre
            // 
            this.btnEmpleXEmpre.Location = new System.Drawing.Point(123, 36);
            this.btnEmpleXEmpre.Name = "btnEmpleXEmpre";
            this.btnEmpleXEmpre.Size = new System.Drawing.Size(190, 40);
            this.btnEmpleXEmpre.TabIndex = 0;
            this.btnEmpleXEmpre.Text = "Empleados por Empresas";
            this.btnEmpleXEmpre.UseVisualStyleBackColor = true;
            this.btnEmpleXEmpre.Click += new System.EventHandler(this.btnEmpleXEmpre_Click);
            // 
            // btnLiqXCat
            // 
            this.btnLiqXCat.Location = new System.Drawing.Point(439, 36);
            this.btnLiqXCat.Name = "btnLiqXCat";
            this.btnLiqXCat.Size = new System.Drawing.Size(190, 40);
            this.btnLiqXCat.TabIndex = 1;
            this.btnLiqXCat.Text = "Liquidaciones por Categorías";
            this.btnLiqXCat.UseVisualStyleBackColor = true;
            this.btnLiqXCat.Click += new System.EventHandler(this.btnLiqXCat_Click);
            // 
            // lstReporte
            // 
            this.lstReporte.FormattingEnabled = true;
            this.lstReporte.Location = new System.Drawing.Point(12, 120);
            this.lstReporte.Name = "lstReporte";
            this.lstReporte.Size = new System.Drawing.Size(776, 238);
            this.lstReporte.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(35, 395);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 25);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(145, 395);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 25);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarLiq
            // 
            this.btnEliminarLiq.Enabled = false;
            this.btnEliminarLiq.Location = new System.Drawing.Point(255, 397);
            this.btnEliminarLiq.Name = "btnEliminarLiq";
            this.btnEliminarLiq.Size = new System.Drawing.Size(161, 22);
            this.btnEliminarLiq.TabIndex = 5;
            this.btnEliminarLiq.Text = "Eliminar Liquidación";
            this.btnEliminarLiq.UseVisualStyleBackColor = true;
            this.btnEliminarLiq.Click += new System.EventHandler(this.btnEliminarLiq_Click_1);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarLiq);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstReporte);
            this.Controls.Add(this.btnLiqXCat);
            this.Controls.Add(this.btnEmpleXEmpre);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleXEmpre;
        private System.Windows.Forms.Button btnLiqXCat;
        private System.Windows.Forms.ListBox lstReporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarLiq;
    }
}