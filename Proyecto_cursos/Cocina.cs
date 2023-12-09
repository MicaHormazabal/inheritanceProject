using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_cursos
{
    internal class Cocina : Cursos
    {
        #region "atributos"
        string _nombre;
        #endregion

        #region "consultas"
        public override string getNombre()
        {
            return _nombre;
        }

        public override bool Equals(object obj)
        {
            bool EsIgual;

            if (obj == null)
            {
                EsIgual = (this == null);
            }
            else if (obj.GetType() != typeof(Cocina))
            {
                EsIgual = false;
            }
            else
            {
                Cocina C = (Cocina)obj;
                EsIgual = (_nombre == C._nombre);
            }

            return EsIgual;
        }

        public override int GetHashCode()
        {
            int codigo = 0;
            for (int i = 0; i < _nombre.Length; i++)
            {
                char c = _nombre[i];
                codigo += Convert.ToInt32(c);
            }

            return codigo * 2500;
        }

        public override string ToString()
        {
            string Cadena = _nombre + ", ";
            Cadena += base.ToString();
            return Cadena;
        }
        #endregion

        #region "comandos"
        public override void setNombre(string nombre)
        {
            _nombre = nombre;
        }
        #endregion

        #region "constructores"
        public Cocina()
        {
            _nombre = "";
        }

        public Cocina(string duracion, DateTime FechaInicio, Institucion Instituto, string nombre) : base(duracion, FechaInicio, Instituto)
        {
            _nombre = nombre;
        }
        #endregion
    }
}
