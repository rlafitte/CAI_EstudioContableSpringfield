
namespace EstudioContableSpringfieldGUI
{
    partial class FrmPrincipal
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
            this.btnLiquidaciones = new System.Windows.Forms.Button();
            this.btnEmpresas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLiquidaciones
            // 
            this.btnLiquidaciones.BackColor = System.Drawing.Color.White;
            this.btnLiquidaciones.Location = new System.Drawing.Point(173, 157);
            this.btnLiquidaciones.Name = "btnLiquidaciones";
            this.btnLiquidaciones.Size = new System.Drawing.Size(113, 48);
            this.btnLiquidaciones.TabIndex = 4;
            this.btnLiquidaciones.Text = "Liquidaciones";
            this.btnLiquidaciones.UseVisualStyleBackColor = false;
            this.btnLiquidaciones.Click += new System.EventHandler(this.btnLiquidaciones_Click);
            this.btnLiquidaciones.MouseLeave += new System.EventHandler(this.btnLiquidaciones_MouseLeave);
            this.btnLiquidaciones.MouseHover += new System.EventHandler(this.btnLiquidaciones_MouseHover);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.BackColor = System.Drawing.Color.White;
            this.btnEmpresas.Location = new System.Drawing.Point(54, 103);
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.Size = new System.Drawing.Size(113, 48);
            this.btnEmpresas.TabIndex = 1;
            this.btnEmpresas.Text = "Empresas";
            this.btnEmpresas.UseVisualStyleBackColor = false;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            this.btnEmpresas.MouseLeave += new System.EventHandler(this.btnEmpresas_MouseLeave);
            this.btnEmpresas.MouseHover += new System.EventHandler(this.btnEmpresas_MouseHover);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(54, 157);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(113, 48);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            this.btnCategorias.MouseLeave += new System.EventHandler(this.btnCategorias_MouseLeave);
            this.btnCategorias.MouseHover += new System.EventHandler(this.btnCategorias_MouseHover);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(114, 332);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(113, 48);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.MouseLeave += new System.EventHandler(this.btnReportes_MouseLeave);
            this.btnReportes.MouseHover += new System.EventHandler(this.btnReportes_MouseHover);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(173, 103);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(113, 48);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            this.btnEmpleados.MouseLeave += new System.EventHandler(this.btnEmpleados_MouseLeave);
            this.btnEmpleados.MouseHover += new System.EventHandler(this.btnEmpleados_MouseHover);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(114, 241);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(113, 48);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estudio Contable Springfield";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnEmpresas);
            this.Controls.Add(this.btnLiquidaciones);
            this.Name = "FrmPrincipal";
            this.Text = "Estudio Contable Springfield";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLiquidaciones;
        private System.Windows.Forms.Button btnEmpresas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label1;
    }
}

