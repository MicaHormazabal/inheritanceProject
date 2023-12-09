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
    public partial class Form1 : Form
    {
        Coleccion datos;

        public Form1()
        {
            InitializeComponent();
            datos = new Coleccion();
        }

       
        private void ActualizarInstituciones()
        {
            List<string> lista, listaNombres;

            listaNombres = datos.ListaNombresInstituciones();
            cbInstituciones.Items.Clear();
            cbInstituciones.Items.Add("Todas");
            foreach (string nombre in listaNombres)
            {
                cbInstituciones.Items.Add(nombre);
            }
            cbInstituciones.SelectedIndex = 0;

            lbInstituciones.Items.Clear();
            if (rbTodosInstitutos.Checked)
            {
                lista = datos.ListarInstituciones();
            }
            else
            {
                lista = datos.ListarInstituciones(rbPrivada.Checked);
            }
            foreach (string detalleInstituto in lista)
            {
                lbInstituciones.Items.Add(detalleInstituto);
            }

            lCantInstitutos.Text = "Cantidad listada: " + lista.Count.ToString();
            lTotalInstitutos.Text = "Total de instituciones: " + datos.CantidadInstituciones;
        }

        private void ActualizarCursos()
        {
            List<string> lista;
            string SeleccionTipo;
            string SeleccionDuracion;
            int SeleccionInstitucion;

            if (rbTodosCursos.Checked)
            {
                SeleccionTipo = "";
            }
            else if (rbResposteria.Checked)
            {
                SeleccionTipo = "reposteria";
            }
            else
            {
                SeleccionTipo = "cocina";
            }

            if (cbInstituciones.SelectedIndex == 0)
            {
                SeleccionInstitucion = 0;
            }
            else
            {
                SeleccionInstitucion = datos.CodigoInstituto(cbInstituciones.Text);
            }

            SeleccionDuracion = cbDuracion.Text;

            lista = datos.ListarCursos(SeleccionTipo, SeleccionInstitucion, SeleccionDuracion);
            lbCursos.Items.Clear();
            foreach (string curso in lista)
            {
                lbCursos.Items.Add(curso);
            }

            lCantCursos.Text = "Cantidad listada: " + lista.Count.ToString();
            lTotalCursos.Text = "Total de cursos: " + datos.CantidadCursos;
        }

        private void msiAgregarInstituto_Click(object sender, EventArgs e)
        {
            fInstitucion fCargarInstituto = new fInstitucion(datos);
            fCargarInstituto.ShowDialog();
            if (fCargarInstituto.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Nueva institución agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarInstituciones();
            }
            else
            {
                MessageBox.Show("Nueva institución cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void msiModificarInstituto_Click(object sender, EventArgs e)
        {
            if (lbInstituciones.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbInstituciones.Focus();
            }
            else
            {
                //obtener nombre de la institucion
                string cadena = lbInstituciones.SelectedItem.ToString();
                int largo = cadena.IndexOf(" ");
                string nombre = cadena.Substring(0, largo);

                int ModCodigo = datos.CodigoInstituto(nombre);
                fInstitucion fModificarInstituto = new fInstitucion(datos, ModCodigo);
                fModificarInstituto.ShowDialog();

                if (fModificarInstituto.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Institución actualizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarInstituciones();
                }
                else
                {
                    MessageBox.Show("Actualizar institución cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void msiEliminarInstituto_Click(object sender, EventArgs e)
        {
            if (lbInstituciones.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbInstituciones.Focus();
            }
            else
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar la institución?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    //obtener nombre de la institucion
                    string cadena = lbInstituciones.SelectedItem.ToString();
                    int largo = cadena.IndexOf(" ");
                    string nombre = cadena.Substring(0, largo);
                    int codigo = datos.CodigoInstituto(nombre);

                    datos.EliminarInstituto(codigo);
                    ActualizarInstituciones();
                }
            }
        }

        private void msiAgregarReposteria_Click(object sender, EventArgs e)
        {
            if (datos.CantidadInstituciones == 0)
            {
                MessageBox.Show("Se requiere agregar al menos una institución", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fCurso fCargarCurso = new fCurso(datos, "reposteria");
                fCargarCurso.ShowDialog();
                if (fCargarCurso.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Nuevo curso de reposteria agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarCursos();
                }
                else
                {
                    MessageBox.Show("Nuevo curso cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void msiAgregarCocina_Click(object sender, EventArgs e)
        {
            if (datos.CantidadInstituciones == 0)
            {
                MessageBox.Show("Se requiere agregar al menos una institución", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fCurso fCargarCurso = new fCurso(datos, "cocina");
                fCargarCurso.ShowDialog();
                if (fCargarCurso.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Nuevo curso de cocina agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarCursos();
                }
                else
                {
                    MessageBox.Show("Nuevo curso cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void msiModificarResposteria_Click(object sender, EventArgs e)
        {
            if (lbCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //obtener nombre del curso
                string cadena = lbCursos.SelectedItem.ToString();
                int largo = cadena.IndexOf(",");
                string nombreCurso = cadena.Substring(0, largo);
                fCurso fModificarCurso = new fCurso(datos,nombreCurso, "reposteria");
                fModificarCurso.ShowDialog();
                if (fModificarCurso.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Curso de reposteria actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarInstituciones();
                }
                else
                {
                    MessageBox.Show("Modificar curso cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }            
        }

        private void msiModificarCocina_Click(object sender, EventArgs e)
        {
            if (lbCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //obtener nombre del curso
                string cadena = lbCursos.SelectedItem.ToString();
                int largo = cadena.IndexOf(",");
                string nombreCurso = cadena.Substring(0, largo);

                fCurso fModificarCurso = new fCurso(datos, nombreCurso, "cocina");
                fModificarCurso.ShowDialog();
                if (fModificarCurso.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Curso de cocina actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarInstituciones();
                }
                else
                {
                    MessageBox.Show("Modificar curso cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void msiEliminarReposteria_Click(object sender, EventArgs e)
        {
            if (lbCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar el curso?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    //obtener nombre del curso
                    string cadena = lbCursos.SelectedItem.ToString();
                    int largo = cadena.IndexOf(",");
                    string nombreCurso = cadena.Substring(0, largo);

                    datos.EliminarReposteria(nombreCurso);
                    ActualizarCursos();
                }
            }
            
        }

        private void msiEliminarCocina_Click(object sender, EventArgs e)
        {
            if (lbCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar el curso?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    //obtener nombre del curso
                    string cadena = lbCursos.SelectedItem.ToString();
                    int largo = cadena.IndexOf(",");
                    string nombreCurso = cadena.Substring(0, largo);

                    datos.EliminarCocina(nombreCurso);
                    ActualizarCursos();
                }
            }
        }

        private void rbTodosInstitutos_Click(object sender, EventArgs e)
        {
            ActualizarInstituciones();
        }

        private void rbPublica_Click(object sender, EventArgs e)
        {
            ActualizarInstituciones();
        }

        private void rbPrivada_Click(object sender, EventArgs e)
        {
            ActualizarInstituciones();
        }

        private void msiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if ((cbInstituciones.SelectedIndex != -1) && (cbDuracion.SelectedIndex != -1) && (rbCocina.Checked || rbResposteria.Checked || rbTodosCursos.Checked))
            {
                ActualizarCursos();
            }
            else
            {
                MessageBox.Show("Falta seleccionar algún campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

            if (rbCocina.Checked)
            {
                refreshCocinaFields();
                msiModificarResposteria.Enabled = false;
                msiEliminarReposteria.Enabled = false;
            }
            else if (rbResposteria.Checked)
            {
                refreshReposteriaFields();
                msiModificarCocina.Enabled = false;
                msiEliminarCocina.Enabled = false;
            }
            
        }

        private void refreshReposteriaFields() {
            msiModificarResposteria.Enabled = true;
            msiEliminarReposteria.Enabled = true;
        }
        private void refreshCocinaFields()
        {
            msiModificarCocina.Enabled = true;
            msiEliminarCocina.Enabled = true;
        }

    }
}
