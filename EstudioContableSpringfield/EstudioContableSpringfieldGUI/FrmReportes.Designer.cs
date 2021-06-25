
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
            this.lstReporte = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarLiq = new System.Windows.Forms.Button();
            this.cmbEmpresas = new System.Windows.Forms.ComboBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReporte
            // 
            this.lstReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lstReporte.FormattingEnabled = true;
            this.lstReporte.ItemHeight = 15;
            this.lstReporte.Location = new System.Drawing.Point(12, 105);
            this.lstReporte.Name = "lstReporte";
            this.lstReporte.Size = new System.Drawing.Size(776, 244);
            this.lstReporte.TabIndex = 2;
            this.lstReporte.SelectedIndexChanged += new System.EventHandler(this.lstReporte_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 413);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 25);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarLiq
            // 
            this.btnEliminarLiq.Enabled = false;
            this.btnEliminarLiq.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminarLiq.Location = new System.Drawing.Point(661, 404);
            this.btnEliminarLiq.Name = "btnEliminarLiq";
            this.btnEliminarLiq.Size = new System.Drawing.Size(127, 34);
            this.btnEliminarLiq.TabIndex = 5;
            this.btnEliminarLiq.Text = "Eliminar Liquidación";
            this.btnEliminarLiq.UseVisualStyleBackColor = true;
            this.btnEliminarLiq.Click += new System.EventHandler(this.btnEliminarLiq_Click_1);
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.Location = new System.Drawing.Point(260, 12);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(236, 29);
            this.cmbEmpresas.TabIndex = 6;
            this.cmbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresas_SelectedIndexChanged);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(260, 47);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(236, 29);
            this.cmbCategorias.TabIndex = 7;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbLiquidaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empleados por empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liquidaciones por categoría";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnviar.Location = new System.Drawing.Point(661, 355);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(127, 30);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.cmbEmpresas);
            this.Controls.Add(this.btnEliminarLiq);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstReporte);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstReporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminarLiq;
        private System.Windows.Forms.ComboBox cmbEmpresas;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
    }
}