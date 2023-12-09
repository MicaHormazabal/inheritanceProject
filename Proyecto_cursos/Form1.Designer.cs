namespace Proyecto_cursos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lTotalCursos = new System.Windows.Forms.Label();
            this.lCantCursos = new System.Windows.Forms.Label();
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.rbCocina = new System.Windows.Forms.RadioButton();
            this.rbResposteria = new System.Windows.Forms.RadioButton();
            this.rbTodosCursos = new System.Windows.Forms.RadioButton();
            this.cbDuracion = new System.Windows.Forms.ComboBox();
            this.cbInstituciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lTotalInstitutos = new System.Windows.Forms.Label();
            this.lCantInstitutos = new System.Windows.Forms.Label();
            this.lbInstituciones = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbPrivada = new System.Windows.Forms.RadioButton();
            this.rbPublica = new System.Windows.Forms.RadioButton();
            this.rbTodosInstitutos = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instituciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAgregarInstituto = new System.Windows.Forms.ToolStripMenuItem();
            this.msiModificarInstituto = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEliminarInstituto = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reposteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAgregarReposteria = new System.Windows.Forms.ToolStripMenuItem();
            this.msiModificarResposteria = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEliminarReposteria = new System.Windows.Forms.ToolStripMenuItem();
            this.cocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAgregarCocina = new System.Windows.Forms.ToolStripMenuItem();
            this.msiModificarCocina = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEliminarCocina = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lTotalCursos);
            this.groupBox1.Controls.Add(this.lCantCursos);
            this.groupBox1.Controls.Add(this.lbCursos);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(42, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lTotalCursos
            // 
            this.lTotalCursos.AutoSize = true;
            this.lTotalCursos.Location = new System.Drawing.Point(418, 214);
            this.lTotalCursos.Name = "lTotalCursos";
            this.lTotalCursos.Size = new System.Drawing.Size(92, 13);
            this.lTotalCursos.TabIndex = 3;
            this.lTotalCursos.Text = "Total de cursos: 0";
            // 
            // lCantCursos
            // 
            this.lCantCursos.AutoSize = true;
            this.lCantCursos.Location = new System.Drawing.Point(40, 214);
            this.lCantCursos.Name = "lCantCursos";
            this.lCantCursos.Size = new System.Drawing.Size(94, 13);
            this.lCantCursos.TabIndex = 2;
            this.lCantCursos.Text = "Cantidad listada: 0";
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.Location = new System.Drawing.Point(40, 125);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(498, 82);
            this.lbCursos.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bBuscar);
            this.groupBox3.Controls.Add(this.rbCocina);
            this.groupBox3.Controls.Add(this.rbResposteria);
            this.groupBox3.Controls.Add(this.rbTodosCursos);
            this.groupBox3.Controls.Add(this.cbDuracion);
            this.groupBox3.Controls.Add(this.cbInstituciones);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(40, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursos";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(395, 42);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 4;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // rbCocina
            // 
            this.rbCocina.AutoSize = true;
            this.rbCocina.Location = new System.Drawing.Point(290, 65);
            this.rbCocina.Name = "rbCocina";
            this.rbCocina.Size = new System.Drawing.Size(58, 17);
            this.rbCocina.TabIndex = 6;
            this.rbCocina.Text = "Cocina";
            this.rbCocina.UseVisualStyleBackColor = true;
            // 
            // rbResposteria
            // 
            this.rbResposteria.AutoSize = true;
            this.rbResposteria.Location = new System.Drawing.Point(290, 42);
            this.rbResposteria.Name = "rbResposteria";
            this.rbResposteria.Size = new System.Drawing.Size(76, 17);
            this.rbResposteria.TabIndex = 5;
            this.rbResposteria.Text = "Reposteria";
            this.rbResposteria.UseVisualStyleBackColor = true;
            // 
            // rbTodosCursos
            // 
            this.rbTodosCursos.AutoSize = true;
            this.rbTodosCursos.Checked = true;
            this.rbTodosCursos.Location = new System.Drawing.Point(290, 19);
            this.rbTodosCursos.Name = "rbTodosCursos";
            this.rbTodosCursos.Size = new System.Drawing.Size(55, 17);
            this.rbTodosCursos.TabIndex = 4;
            this.rbTodosCursos.TabStop = true;
            this.rbTodosCursos.Text = "Todos";
            this.rbTodosCursos.UseVisualStyleBackColor = true;
            // 
            // cbDuracion
            // 
            this.cbDuracion.FormattingEnabled = true;
            this.cbDuracion.Items.AddRange(new object[] {
            "Todas",
            "4 meses",
            "8 meses"});
            this.cbDuracion.Location = new System.Drawing.Point(117, 58);
            this.cbDuracion.Name = "cbDuracion";
            this.cbDuracion.Size = new System.Drawing.Size(121, 21);
            this.cbDuracion.TabIndex = 3;
            // 
            // cbInstituciones
            // 
            this.cbInstituciones.FormattingEnabled = true;
            this.cbInstituciones.Location = new System.Drawing.Point(117, 27);
            this.cbInstituciones.Name = "cbInstituciones";
            this.cbInstituciones.Size = new System.Drawing.Size(121, 21);
            this.cbInstituciones.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Institución";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lTotalInstitutos);
            this.groupBox2.Controls.Add(this.lCantInstitutos);
            this.groupBox2.Controls.Add(this.lbInstituciones);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(42, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 193);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lTotalInstitutos
            // 
            this.lTotalInstitutos.AutoSize = true;
            this.lTotalInstitutos.Location = new System.Drawing.Point(418, 166);
            this.lTotalInstitutos.Name = "lTotalInstitutos";
            this.lTotalInstitutos.Size = new System.Drawing.Size(120, 13);
            this.lTotalInstitutos.TabIndex = 3;
            this.lTotalInstitutos.Text = "Total de Instituciones: 0";
            // 
            // lCantInstitutos
            // 
            this.lCantInstitutos.AutoSize = true;
            this.lCantInstitutos.Location = new System.Drawing.Point(40, 166);
            this.lCantInstitutos.Name = "lCantInstitutos";
            this.lCantInstitutos.Size = new System.Drawing.Size(94, 13);
            this.lCantInstitutos.TabIndex = 2;
            this.lCantInstitutos.Text = "Cantidad listada: 0";
            // 
            // lbInstituciones
            // 
            this.lbInstituciones.FormattingEnabled = true;
            this.lbInstituciones.Location = new System.Drawing.Point(43, 78);
            this.lbInstituciones.Name = "lbInstituciones";
            this.lbInstituciones.Size = new System.Drawing.Size(495, 82);
            this.lbInstituciones.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbPrivada);
            this.groupBox4.Controls.Add(this.rbPublica);
            this.groupBox4.Controls.Add(this.rbTodosInstitutos);
            this.groupBox4.Location = new System.Drawing.Point(43, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 53);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Instituciones";
            // 
            // rbPrivada
            // 
            this.rbPrivada.AutoSize = true;
            this.rbPrivada.Location = new System.Drawing.Point(337, 19);
            this.rbPrivada.Name = "rbPrivada";
            this.rbPrivada.Size = new System.Drawing.Size(61, 17);
            this.rbPrivada.TabIndex = 2;
            this.rbPrivada.Text = "Privada";
            this.rbPrivada.UseVisualStyleBackColor = true;
            this.rbPrivada.Click += new System.EventHandler(this.rbPrivada_Click);
            // 
            // rbPublica
            // 
            this.rbPublica.AutoSize = true;
            this.rbPublica.Location = new System.Drawing.Point(200, 19);
            this.rbPublica.Name = "rbPublica";
            this.rbPublica.Size = new System.Drawing.Size(60, 17);
            this.rbPublica.TabIndex = 1;
            this.rbPublica.Text = "Pública";
            this.rbPublica.UseVisualStyleBackColor = true;
            this.rbPublica.Click += new System.EventHandler(this.rbPublica_Click);
            // 
            // rbTodosInstitutos
            // 
            this.rbTodosInstitutos.AutoSize = true;
            this.rbTodosInstitutos.Checked = true;
            this.rbTodosInstitutos.Location = new System.Drawing.Point(60, 19);
            this.rbTodosInstitutos.Name = "rbTodosInstitutos";
            this.rbTodosInstitutos.Size = new System.Drawing.Size(55, 17);
            this.rbTodosInstitutos.TabIndex = 0;
            this.rbTodosInstitutos.TabStop = true;
            this.rbTodosInstitutos.Text = "Todos";
            this.rbTodosInstitutos.UseVisualStyleBackColor = true;
            this.rbTodosInstitutos.Click += new System.EventHandler(this.rbTodosInstitutos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instituciónToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.msiSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instituciónToolStripMenuItem
            // 
            this.instituciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAgregarInstituto,
            this.msiModificarInstituto,
            this.msiEliminarInstituto});
            this.instituciónToolStripMenuItem.Name = "instituciónToolStripMenuItem";
            this.instituciónToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.instituciónToolStripMenuItem.Text = "Institución";
            // 
            // msiAgregarInstituto
            // 
            this.msiAgregarInstituto.Name = "msiAgregarInstituto";
            this.msiAgregarInstituto.Size = new System.Drawing.Size(125, 22);
            this.msiAgregarInstituto.Text = "Agregar ";
            this.msiAgregarInstituto.Click += new System.EventHandler(this.msiAgregarInstituto_Click);
            // 
            // msiModificarInstituto
            // 
            this.msiModificarInstituto.Name = "msiModificarInstituto";
            this.msiModificarInstituto.Size = new System.Drawing.Size(125, 22);
            this.msiModificarInstituto.Text = "Modificar";
            this.msiModificarInstituto.Click += new System.EventHandler(this.msiModificarInstituto_Click);
            // 
            // msiEliminarInstituto
            // 
            this.msiEliminarInstituto.Name = "msiEliminarInstituto";
            this.msiEliminarInstituto.Size = new System.Drawing.Size(125, 22);
            this.msiEliminarInstituto.Text = "Eliminar";
            this.msiEliminarInstituto.Click += new System.EventHandler(this.msiEliminarInstituto_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reposteriaToolStripMenuItem,
            this.cocinaToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // reposteriaToolStripMenuItem
            // 
            this.reposteriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAgregarReposteria,
            this.msiModificarResposteria,
            this.msiEliminarReposteria});
            this.reposteriaToolStripMenuItem.Name = "reposteriaToolStripMenuItem";
            this.reposteriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reposteriaToolStripMenuItem.Text = "Reposteria";
            // 
            // msiAgregarReposteria
            // 
            this.msiAgregarReposteria.Name = "msiAgregarReposteria";
            this.msiAgregarReposteria.Size = new System.Drawing.Size(125, 22);
            this.msiAgregarReposteria.Text = "Agregar";
            this.msiAgregarReposteria.Click += new System.EventHandler(this.msiAgregarReposteria_Click);
            // 
            // msiModificarResposteria
            // 
            this.msiModificarResposteria.Name = "msiModificarResposteria";
            this.msiModificarResposteria.Size = new System.Drawing.Size(125, 22);
            this.msiModificarResposteria.Text = "Modificar";
            this.msiModificarResposteria.Click += new System.EventHandler(this.msiModificarResposteria_Click);
            // 
            // msiEliminarReposteria
            // 
            this.msiEliminarReposteria.Name = "msiEliminarReposteria";
            this.msiEliminarReposteria.Size = new System.Drawing.Size(125, 22);
            this.msiEliminarReposteria.Text = "Eliminar";
            this.msiEliminarReposteria.Click += new System.EventHandler(this.msiEliminarReposteria_Click);
            // 
            // cocinaToolStripMenuItem
            // 
            this.cocinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAgregarCocina,
            this.msiModificarCocina,
            this.msiEliminarCocina});
            this.cocinaToolStripMenuItem.Name = "cocinaToolStripMenuItem";
            this.cocinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cocinaToolStripMenuItem.Text = "Cocina";
            // 
            // msiAgregarCocina
            // 
            this.msiAgregarCocina.Name = "msiAgregarCocina";
            this.msiAgregarCocina.Size = new System.Drawing.Size(180, 22);
            this.msiAgregarCocina.Text = "Agregar";
            this.msiAgregarCocina.Click += new System.EventHandler(this.msiAgregarCocina_Click);
            // 
            // msiModificarCocina
            // 
            this.msiModificarCocina.Name = "msiModificarCocina";
            this.msiModificarCocina.Size = new System.Drawing.Size(180, 22);
            this.msiModificarCocina.Text = "Modificar";
            this.msiModificarCocina.Click += new System.EventHandler(this.msiModificarCocina_Click);
            // 
            // msiEliminarCocina
            // 
            this.msiEliminarCocina.Name = "msiEliminarCocina";
            this.msiEliminarCocina.Size = new System.Drawing.Size(180, 22);
            this.msiEliminarCocina.Text = "Eliminar";
            this.msiEliminarCocina.Click += new System.EventHandler(this.msiEliminarCocina_Click);
            // 
            // msiSalir
            // 
            this.msiSalir.Name = "msiSalir";
            this.msiSalir.Size = new System.Drawing.Size(41, 20);
            this.msiSalir.Text = "Salir";
            this.msiSalir.Click += new System.EventHandler(this.msiSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cursos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lTotalCursos;
        private System.Windows.Forms.Label lCantCursos;
        private System.Windows.Forms.ListBox lbCursos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCocina;
        private System.Windows.Forms.RadioButton rbResposteria;
        private System.Windows.Forms.RadioButton rbTodosCursos;
        private System.Windows.Forms.ComboBox cbDuracion;
        private System.Windows.Forms.ComboBox cbInstituciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lTotalInstitutos;
        private System.Windows.Forms.Label lCantInstitutos;
        private System.Windows.Forms.ListBox lbInstituciones;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbPrivada;
        private System.Windows.Forms.RadioButton rbPublica;
        private System.Windows.Forms.RadioButton rbTodosInstitutos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instituciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAgregarInstituto;
        private System.Windows.Forms.ToolStripMenuItem msiModificarInstituto;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reposteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAgregarReposteria;
        private System.Windows.Forms.ToolStripMenuItem msiModificarResposteria;
        private System.Windows.Forms.ToolStripMenuItem cocinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAgregarCocina;
        private System.Windows.Forms.ToolStripMenuItem msiModificarCocina;
        private System.Windows.Forms.ToolStripMenuItem msiEliminarInstituto;
        private System.Windows.Forms.ToolStripMenuItem msiEliminarReposteria;
        private System.Windows.Forms.ToolStripMenuItem msiEliminarCocina;
        private System.Windows.Forms.ToolStripMenuItem msiSalir;
        private System.Windows.Forms.Button bBuscar;
    }
}

