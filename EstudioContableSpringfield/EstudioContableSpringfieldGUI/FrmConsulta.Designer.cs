namespace EstudioContableSpringfieldGUI
{
    partial class FrmConsulta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.listaLiquidaciones = new System.Windows.Forms.ListBox();
            this.btnConsultaEmpresa = new System.Windows.Forms.Button();
            this.btnConsultaEmpleado = new System.Windows.Forms.Button();
            this.btnConsultaCategoria = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Liquidación";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(58, 116);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // listaLiquidaciones
            // 
            this.listaLiquidaciones.FormattingEnabled = true;
            this.listaLiquidaciones.Location = new System.Drawing.Point(439, 12);
            this.listaLiquidaciones.Name = "listaLiquidaciones";
            this.listaLiquidaciones.Size = new System.Drawing.Size(349, 329);
            this.listaLiquidaciones.TabIndex = 3;
            // 
            // btnConsultaEmpresa
            // 
            this.btnConsultaEmpresa.Location = new System.Drawing.Point(448, 380);
            this.btnConsultaEmpresa.Name = "btnConsultaEmpresa";
            this.btnConsultaEmpresa.Size = new System.Drawing.Size(93, 32);
            this.btnConsultaEmpresa.TabIndex = 4;
            this.btnConsultaEmpresa.Text = "Empresa";
            this.btnConsultaEmpresa.UseVisualStyleBackColor = true;
            this.btnConsultaEmpresa.Click += new System.EventHandler(this.btnConsultaEmpresa_Click);
            // 
            // btnConsultaEmpleado
            // 
            this.btnConsultaEmpleado.Location = new System.Drawing.Point(564, 380);
            this.btnConsultaEmpleado.Name = "btnConsultaEmpleado";
            this.btnConsultaEmpleado.Size = new System.Drawing.Size(93, 32);
            this.btnConsultaEmpleado.TabIndex = 5;
            this.btnConsultaEmpleado.Text = "Empleado";
            this.btnConsultaEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnConsultaCategoria
            // 
            this.btnConsultaCategoria.Location = new System.Drawing.Point(674, 380);
            this.btnConsultaCategoria.Name = "btnConsultaCategoria";
            this.btnConsultaCategoria.Size = new System.Drawing.Size(93, 32);
            this.btnConsultaCategoria.TabIndex = 6;
            this.btnConsultaCategoria.Text = "Categoría";
            this.btnConsultaCategoria.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConsultaCategoria);
            this.Controls.Add(this.btnConsultaEmpleado);
            this.Controls.Add(this.btnConsultaEmpresa);
            this.Controls.Add(this.listaLiquidaciones);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ListBox listaLiquidaciones;
        private System.Windows.Forms.Button btnConsultaEmpresa;
        private System.Windows.Forms.Button btnConsultaEmpleado;
        private System.Windows.Forms.Button btnConsultaCategoria;
        private System.Windows.Forms.Button btnVolver;
    }
}