namespace Proyecto_cursos
{
    partial class fInstitucion
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
            this.pInstituto = new System.Windows.Forms.Panel();
            this.mtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.chPrivada = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pInstituto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pInstituto
            // 
            this.pInstituto.BackColor = System.Drawing.Color.Thistle;
            this.pInstituto.Controls.Add(this.mtCodigo);
            this.pInstituto.Controls.Add(this.tDireccion);
            this.pInstituto.Controls.Add(this.tNombre);
            this.pInstituto.Controls.Add(this.chPrivada);
            this.pInstituto.Controls.Add(this.label3);
            this.pInstituto.Controls.Add(this.label2);
            this.pInstituto.Controls.Add(this.label1);
            this.pInstituto.Location = new System.Drawing.Point(14, 12);
            this.pInstituto.Name = "pInstituto";
            this.pInstituto.Size = new System.Drawing.Size(269, 120);
            this.pInstituto.TabIndex = 0;
            // 
            // mtCodigo
            // 
            this.mtCodigo.Location = new System.Drawing.Point(106, 67);
            this.mtCodigo.Mask = "0000";
            this.mtCodigo.Name = "mtCodigo";
            this.mtCodigo.Size = new System.Drawing.Size(117, 20);
            this.mtCodigo.TabIndex = 6;
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(106, 41);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(117, 20);
            this.tDireccion.TabIndex = 5;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(106, 15);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(117, 20);
            this.tNombre.TabIndex = 4;
            // 
            // chPrivada
            // 
            this.chPrivada.AutoSize = true;
            this.chPrivada.Location = new System.Drawing.Point(106, 93);
            this.chPrivada.Name = "chPrivada";
            this.chPrivada.Size = new System.Drawing.Size(62, 17);
            this.chPrivada.TabIndex = 3;
            this.chPrivada.Text = "Privado";
            this.chPrivada.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(32, 150);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(173, 150);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // fInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 185);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.pInstituto);
            this.Name = "fInstitucion";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.fInstitucion_Load);
            this.pInstituto.ResumeLayout(false);
            this.pInstituto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pInstituto;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.CheckBox chPrivada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.MaskedTextBox mtCodigo;
    }
}