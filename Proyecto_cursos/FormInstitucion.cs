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
    public partial class fInstitucion : Form
    {
        Coleccion datos;
        bool AgregaInstitucion;
        int CodigoActual;
        string NombreActual;
        public fInstitucion(Coleccion conexion)
        {
            InitializeComponent();
            datos = conexion;
            AgregaInstitucion = true;
            CodigoActual = 0;
        }

        public fInstitucion(Coleccion conexion, int codigo)
        {
            InitializeComponent();
            datos = conexion;
            AgregaInstitucion = false;
            CodigoActual = codigo;
            NombreActual = datos.NombreInstitucion(CodigoActual);
        }

        private void fInstitucion_Load(object sender, EventArgs e)
        {
            if (AgregaInstitucion)
            {
                Text = "Nuevo instituto";
                pInstituto.BackColor = Color.PowderBlue;
                bAceptar.Text = "Agregar";
                tNombre.Text = "";
                tDireccion.Text = "";
                mtCodigo.Text = "";
                chPrivada.Checked = false;
                mtCodigo.Enabled = true;
            }
            else
            {
                Text = "Modificar instituto";
                pInstituto.BackColor = Color.Thistle;
                bAceptar.Text = "Modificar";
                mtCodigo.Enabled = false;
                mtCodigo.Text = CodigoActual.ToString();
                tNombre.Text = NombreActual;
                tDireccion.Text = datos.DireccionInstitucion(CodigoActual);
                chPrivada.Checked = datos.InstitutoEsPrivado(CodigoActual);
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string NuevoCodigo = mtCodigo.MaskCompleted ? mtCodigo.Text : "";
            string NuevoNombre = tNombre.Text.Trim();
            string NuevaDireccion = tDireccion.Text.Trim();
            bool NuevoPrivada = chPrivada.Checked;

            if (NuevoNombre == "")
            {
                MessageBox.Show("Falta agregar el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tNombre.Focus();
            }
            else if (NuevaDireccion == "")
            {
                MessageBox.Show("Falta agregar la dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tDireccion.Focus();
            }
            else if (!mtCodigo.MaskCompleted && !AgregaInstitucion)
            {
                MessageBox.Show("Falta agregar el código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtCodigo.Focus();
            }
            else if (AgregaInstitucion)
            {
                if (datos.ExisteCodigoInstitucion(Convert.ToInt32(NuevoCodigo)))
                {
                    MessageBox.Show("Código existente, ingrese otra institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtCodigo.Focus();
                }
                else if (datos.ExisteDireccionInstituto(NuevaDireccion))
                {
                    MessageBox.Show("Dirección existente, ingrese otra institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tDireccion.Focus();
                }
                else if (datos.ExisteNombreInstituto(NuevoNombre))
                {
                    MessageBox.Show("Nombre existente, ingrese otra institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tNombre.Focus();
                }
                else
                {
                    datos.InsertarInstituto(NuevoNombre, NuevaDireccion, NuevoPrivada, Convert.ToInt32(NuevoCodigo));
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string AnteriorNombre = datos.NombreInstitucion(CodigoActual);
                string AnteriorDireccion = datos.DireccionInstitucion(CodigoActual);

                if ((AnteriorNombre != NuevoNombre) && (datos.ExisteNombreInstituto(NuevoNombre)))
                {
                    MessageBox.Show("Nombre existente, ingrese otra institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tNombre.Focus();
                }
                else if ((AnteriorDireccion != NuevaDireccion) && (datos.ExisteDireccionInstituto(NuevaDireccion)))
                {
                    MessageBox.Show("Dirección existente, ingrese otra institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tDireccion.Focus();
                }
                else
                {
                    datos.ModificarInstituto(NuevoNombre, NuevaDireccion, NuevoPrivada, Convert.ToInt32(NuevoCodigo));
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
