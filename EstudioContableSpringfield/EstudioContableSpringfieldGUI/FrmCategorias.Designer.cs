﻿
namespace EstudioContableSpringfieldGUI
{
    partial class FrmCategorias
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBasico = new System.Windows.Forms.TextBox();
            this.txtCCTNum = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.categoriasTitle = new System.Windows.Forms.Label();
            this.chkCCTSi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(19, 334);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 34);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(233, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 34);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sueldo básico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "CCT N° ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "CCT  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtBasico
            // 
            this.txtBasico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasico.Location = new System.Drawing.Point(175, 218);
            this.txtBasico.Name = "txtBasico";
            this.txtBasico.Size = new System.Drawing.Size(165, 29);
            this.txtBasico.TabIndex = 9;
            // 
            // txtCCTNum
            // 
            this.txtCCTNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCTNum.Location = new System.Drawing.Point(175, 183);
            this.txtCCTNum.Name = "txtCCTNum";
            this.txtCCTNum.Size = new System.Drawing.Size(165, 29);
            this.txtCCTNum.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // categoriasTitle
            // 
            this.categoriasTitle.AutoSize = true;
            this.categoriasTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriasTitle.Location = new System.Drawing.Point(12, 9);
            this.categoriasTitle.Name = "categoriasTitle";
            this.categoriasTitle.Size = new System.Drawing.Size(153, 40);
            this.categoriasTitle.TabIndex = 12;
            this.categoriasTitle.Text = "Categorias";
            // 
            // chkCCTSi
            // 
            this.chkCCTSi.AutoSize = true;
            this.chkCCTSi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkCCTSi.Location = new System.Drawing.Point(175, 152);
            this.chkCCTSi.Name = "chkCCTSi";
            this.chkCCTSi.Size = new System.Drawing.Size(38, 23);
            this.chkCCTSi.TabIndex = 5;
            this.chkCCTSi.Text = "Si";
            this.chkCCTSi.UseVisualStyleBackColor = true;
            this.chkCCTSi.CheckedChanged += new System.EventHandler(this.chkCCTSi_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategoria.Location = new System.Drawing.Point(175, 78);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(165, 29);
            this.txtIdCategoria.TabIndex = 1;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.chkCCTSi);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBasico);
            this.Controls.Add(this.txtCCTNum);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.categoriasTitle);
            this.Name = "FrmCategorias";
            this.Text = "FrmEmpresas";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBasico;
        private System.Windows.Forms.TextBox txtCCTNum;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label categoriasTitle;
        private System.Windows.Forms.CheckBox chkCCTSi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCategoria;
    }
}