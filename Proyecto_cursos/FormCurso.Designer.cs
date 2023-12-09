namespace Proyecto_cursos
{
    partial class fCurso
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
            this.pCursos = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbInstituto = new System.Windows.Forms.ComboBox();
            this.cbDuracion = new System.Windows.Forms.ComboBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lDuracion = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCursos
            // 
            this.pCursos.BackColor = System.Drawing.Color.Pink;
            this.pCursos.Controls.Add(this.dtpFecha);
            this.pCursos.Controls.Add(this.cbInstituto);
            this.pCursos.Controls.Add(this.cbDuracion);
            this.pCursos.Controls.Add(this.tNombre);
            this.pCursos.Controls.Add(this.lFecha);
            this.pCursos.Controls.Add(this.label3);
            this.pCursos.Controls.Add(this.lDuracion);
            this.pCursos.Controls.Add(this.lNombre);
            this.pCursos.Location = new System.Drawing.Point(12, 12);
            this.pCursos.Name = "pCursos";
            this.pCursos.Size = new System.Drawing.Size(318, 140);
            this.pCursos.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(147, 99);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // cbInstituto
            // 
            this.cbInstituto.FormattingEnabled = true;
            this.cbInstituto.Location = new System.Drawing.Point(147, 72);
            this.cbInstituto.Name = "cbInstituto";
            this.cbInstituto.Size = new System.Drawing.Size(121, 21);
            this.cbInstituto.TabIndex = 6;
            // 
            // cbDuracion
            // 
            this.cbDuracion.FormattingEnabled = true;
            this.cbDuracion.Items.AddRange(new object[] {
            "4 meses",
            "8 meses"});
            this.cbDuracion.Location = new System.Drawing.Point(147, 45);
            this.cbDuracion.Name = "cbDuracion";
            this.cbDuracion.Size = new System.Drawing.Size(121, 21);
            this.cbDuracion.TabIndex = 5;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(147, 19);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(121, 20);
            this.tNombre.TabIndex = 4;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Location = new System.Drawing.Point(35, 101);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(82, 13);
            this.lFecha.TabIndex = 3;
            this.lFecha.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instituto:";
            // 
            // lDuracion
            // 
            this.lDuracion.AutoSize = true;
            this.lDuracion.Location = new System.Drawing.Point(35, 48);
            this.lDuracion.Name = "lDuracion";
            this.lDuracion.Size = new System.Drawing.Size(53, 13);
            this.lDuracion.TabIndex = 1;
            this.lDuracion.Text = "Duración:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(35, 22);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(38, 170);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(205, 170);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // fCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 203);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.pCursos);
            this.Name = "fCurso";
            this.Text = "Agregar Curso";
            this.Load += new System.EventHandler(this.fCurso_Load);
            this.pCursos.ResumeLayout(false);
            this.pCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCursos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbInstituto;
        private System.Windows.Forms.ComboBox cbDuracion;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lDuracion;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
    }
}