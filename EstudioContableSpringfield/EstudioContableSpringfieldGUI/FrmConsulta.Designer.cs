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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodReadOnly = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "por código de liquidación";
            // 
            // btnConsultaLiquidaciones
            // 
            this.btnConsultaLiquidaciones.Location = new System.Drawing.Point(19, 146);
            this.btnConsultaLiquidaciones.Name = "btnConsultaLiquidaciones";
            this.btnConsultaLiquidaciones.Size = new System.Drawing.Size(100, 29);
            this.btnConsultaLiquidaciones.TabIndex = 2;
            this.btnConsultaLiquidaciones.Text = "Consultar";
            this.btnConsultaLiquidaciones.UseVisualStyleBackColor = true;
            this.btnConsultaLiquidaciones.Click += new System.EventHandler(this.btnConsultaLiquidaciones_Click);
            // 
            // list1
            // 
            this.list1.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 12;
            this.list1.Location = new System.Drawing.Point(207, 9);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(698, 316);
            this.list1.TabIndex = 3;
            // 
            // btnConsultaEmpresa
            // 
            this.btnConsultaEmpresa.Location = new System.Drawing.Point(441, 390);
            this.btnConsultaEmpresa.Name = "btnConsultaEmpresa";
            this.btnConsultaEmpresa.Size = new System.Drawing.Size(100, 29);
            this.btnConsultaEmpresa.TabIndex = 4;
            this.btnConsultaEmpresa.Text = "Empresa";
            this.btnConsultaEmpresa.UseVisualStyleBackColor = true;
            this.btnConsultaEmpresa.Click += new System.EventHandler(this.btnConsultaEmpresa_Click);
            // 
            // btnConsultaEmpleado
            // 
            this.btnConsultaEmpleado.Location = new System.Drawing.Point(620, 387);
            this.btnConsultaEmpleado.Name = "btnConsultaEmpleado";
            this.btnConsultaEmpleado.Size = new System.Drawing.Size(93, 32);
            this.btnConsultaEmpleado.TabIndex = 5;
            this.btnConsultaEmpleado.Text = "Empleado";
            this.btnConsultaEmpleado.UseVisualStyleBackColor = true;
            this.btnConsultaEmpleado.Click += new System.EventHandler(this.btnConsultaEmpleado_Click);
            // 
            // btnConsultaCategoria
            // 
            this.btnConsultaCategoria.Location = new System.Drawing.Point(794, 387);
            this.btnConsultaCategoria.Name = "btnConsultaCategoria";
            this.btnConsultaCategoria.Size = new System.Drawing.Size(93, 32);
            this.btnConsultaCategoria.TabIndex = 6;
            this.btnConsultaCategoria.Text = "Categoría";
            this.btnConsultaCategoria.UseVisualStyleBackColor = true;
            this.btnConsultaCategoria.Click += new System.EventHandler(this.btnConsultaCategoria_Click);
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
            this.label3.Location = new System.Drawing.Point(443, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "por empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "por empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(790, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "por categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Código";
            // 
            // textBoxCodReadOnly
            // 
            this.textBoxCodReadOnly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodReadOnly.Location = new System.Drawing.Point(278, 378);
            this.textBoxCodReadOnly.Name = "textBoxCodReadOnly";
            this.textBoxCodReadOnly.ReadOnly = true;
            this.textBoxCodReadOnly.Size = new System.Drawing.Size(87, 29);
            this.textBoxCodReadOnly.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 59);
            this.label7.TabIndex = 14;
            this.label7.Text = "→";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCodReadOnly);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodReadOnly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}