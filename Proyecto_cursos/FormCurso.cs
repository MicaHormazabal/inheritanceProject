using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_cursos
{
    public partial class fCurso : Form
    {
        Coleccion datos;
        bool AgregarCurso;
        string NombreActual;
        string Tipo;
        string DuracionActual;
        DateTime FechaActual;

        private void ActualizarInstituciones()
        {
            List<string> listaNombres;

            listaNombres = datos.ListaNombresInstituciones();
            cbInstituto.Items.Clear();
            foreach (string nombre in listaNombres)
            {
                cbInstituto.Items.Add(nombre);
            }
        }

        public fCurso(Coleccion conexion, string TipoCurso)
        {
            InitializeComponent();
            datos = conexion;
            AgregarCurso = true;
            NombreActual = "";
            Tipo = TipoCurso;
        }

        public fCurso(Coleccion conexion, string NombreCurso, string TipoCurso)
        {
            InitializeComponent();
            datos = conexion;
            AgregarCurso = false;
            NombreActual = NombreCurso;
            Tipo = TipoCurso;
         
            
            if (Tipo == "reposteria")
            {
                DuracionActual = datos.DuracionReposteria(NombreActual);
                FechaActual = datos.FechaReposteria(NombreActual);                
            }
            else
            {
                DuracionActual = datos.DuracionCocina(NombreActual);
                FechaActual = datos.FechaCocina(NombreActual);
            }
        }

        private void fCurso_Load(object sender, EventArgs e)
        {
            ActualizarInstituciones();

            if (AgregarCurso)
            {
                Text = "Nuevo curso";
                pCursos.BackColor = Color.MediumAquamarine;
                bAceptar.Text = "Agregar";
                tNombre.Text = "";
            } 
            else
            {
                Text = "Modificar curso";
                pCursos.BackColor = Color.Pink;
                bAceptar.Text = "Modificar";
                tNombre.Enabled = false;
                tNombre.Text = NombreActual;
                cbDuracion.Text = DuracionActual;
                dtpFecha.Value = FechaActual;
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string NuevoNombre = tNombre.Text != "" ? tNombre.Text : "";
            string NuevaDuracion = cbDuracion.Text;
            Institucion NuevoInstituto = datos.ObjInstituto(cbInstituto.Text);
            DateTime NuevaFecha = dtpFecha.Value.Date;

            if (tNombre.Text == "")
            {
                MessageBox.Show("Falta completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tNombre.Focus();
            }
            else if (cbDuracion.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar duración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDuracion.Focus();
            } 
            else if (cbInstituto.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar instituto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbInstituto.Focus();
            } 
            else if (AgregarCurso)
            {
                if (Tipo == "reposteria")
                {
                    if (datos.ExisteReposteria(NuevoNombre))
                    {
                        MessageBox.Show("El nombre ya existe, agregar otro curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tNombre.Focus();
                    }
                    else
                    {
                        datos.InsertarReposteria(NuevaDuracion, NuevaFecha, NuevoInstituto, NuevoNombre);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (datos.ExisteCocina(NuevoNombre))
                    {
                        MessageBox.Show("El nombre ya existe, agregar otro curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tNombre.Focus();
                    }
                    else
                    {
                        datos.InsertarCocina(NuevaDuracion, NuevaFecha, NuevoInstituto, NuevoNombre);
                        DialogResult = DialogResult.OK;
                    }
                }
            } 
            else
            {
                if (Tipo == "reposteria")
                {
                    datos.ModificarReposteria(NuevaDuracion, NuevaFecha, NuevoInstituto, NuevoNombre);
                }
                else if (Tipo == "cocina")
                {
                    datos.ModificarCocina(NuevaDuracion, NuevaFecha, NuevoInstituto, NuevoNombre);
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
