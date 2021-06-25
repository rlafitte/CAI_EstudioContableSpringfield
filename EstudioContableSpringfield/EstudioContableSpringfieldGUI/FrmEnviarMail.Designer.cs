
namespace EstudioContableSpringfieldGUI
{
    partial class FrmEnviarMail
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
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPara.Location = new System.Drawing.Point(141, 12);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(542, 25);
            this.txtPara.TabIndex = 1;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAsunto.Location = new System.Drawing.Point(141, 51);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(542, 25);
            this.txtAsunto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asunto:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.AllowDrop = true;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMensaje.Location = new System.Drawing.Point(25, 93);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensaje.Size = new System.Drawing.Size(658, 194);
            this.txtMensaje.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEnviar.Location = new System.Drawing.Point(591, 305);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(92, 30);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 310);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 25);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmEnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 347);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label1);
            this.Name = "FrmEnviarMail";
            this.Text = "FrmEnviarMail";
            this.Load += new System.EventHandler(this.FrmEnviarMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVolver;
    }
}