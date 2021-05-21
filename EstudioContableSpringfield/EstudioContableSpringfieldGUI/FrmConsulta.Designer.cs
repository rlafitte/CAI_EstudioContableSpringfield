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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultaLiquidaciones = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.btnConsultaEmpresa = new System.Windows.Forms.Button();
            this.btnConsultaEmpleado = new System.Windows.Forms.Button();
            this.btnConsultaCategoria = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // btnConsultaLiquidaciones
            // 
            this.btnConsultaLiquidaciones.Location = new System.Drawing.Point(177, 427);
            this.btnConsultaLiquidaciones.Name = "btnConsultaLiquidaciones";
            this.btnConsultaLiquidaciones.Size = new System.Drawing.Size(100, 29);
            this.btnConsultaLiquidaciones.TabIndex = 2;
            this.btnConsultaLiquidaciones.Text = "Consultar";
            this.btnConsultaLiquidaciones.UseVisualStyleBackColor = true;
            this.btnConsultaLiquidaciones.Click += new System.EventHandler(this.btnConsultaLiquidaciones_Click);
            // 
            // list1
            // 
            this.list1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 15;
            this.list1.Location = new System.Drawing.Point(12, 52);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(842, 304);
            this.list1.TabIndex = 3;
            // 
            // btnConsultaEmpresa
            // 
            this.btnConsultaEmpresa.Location = new System.Drawing.Point(344, 428);
            this.btnConsultaEmpresa.Name = "btnConsultaEmpresa";
            this.btnConsultaEmpresa.Size = new System.Drawing.Size(100, 29);
            this.btnConsultaEmpresa.TabIndex = 4;
            this.btnConsultaEmpresa.Text = "Empresa";
            this.btnConsultaEmpresa.UseVisualStyleBackColor = true;
            this.btnConsultaEmpresa.Click += new System.EventHandler(this.btnConsultaEmpresa_Click);
            // 
            // btnConsultaEmpleado
            // 
            this.btnConsultaEmpleado.Location = new System.Drawing.Point(523, 425);
            this.btnConsultaEmpleado.Name = "btnConsultaEmpleado";
            this.btnConsultaEmpleado.Size = new System.Drawing.Size(93, 32);
            this.btnConsultaEmpleado.TabIndex = 5;
            this.btnConsultaEmpleado.Text = "Empleado";
            this.btnConsultaEmpleado.UseVisualStyleBackColor = true;
            this.btnConsultaEmpleado.Click += new System.EventHandler(this.btnConsultaEmpleado_Click);
            // 
            // btnConsultaCategoria
            // 
            this.btnConsultaCategoria.Location = new System.Drawing.Point(697, 425);
            this.btnConsultaCategoria.Name = "btnConsultaCategoria";
            this.btnConsultaCategoria.Size = new System.Drawing.Size(93, 32);
            this.btnConsultaCategoria.TabIndex = 6;
            this.btnConsultaCategoria.Text = "Categoría";
            this.btnConsultaCategoria.UseVisualStyleBackColor = true;
            this.btnConsultaCategoria.Click += new System.EventHandler(this.btnConsultaCategoria_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 445);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Consultas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "por empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "por empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "por categoría";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 480);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConsultaCategoria);
            this.Controls.Add(this.btnConsultaEmpleado);
            this.Controls.Add(this.btnConsultaEmpresa);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.btnConsultaLiquidaciones);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaLiquidaciones;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button btnConsultaEmpresa;
        private System.Windows.Forms.Button btnConsultaEmpleado;
        private System.Windows.Forms.Button btnConsultaCategoria;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}