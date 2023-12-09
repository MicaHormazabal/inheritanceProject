using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cursos
{
    internal abstract class Cursos
    {
        #region "atributos"
        string _duracion;
        Institucion _instituto;
        DateTime _inicio;
        #endregion

        #region "consultas"
        public string getDuracion()
        {
            return _duracion;
        }

        public abstract string getNombre();

        public DateTime getFechaInicio()
        {
            return _inicio;
        }

        public override string ToString()
        {
            string Cadena = "Inicia el: " + _inicio;
            return Cadena;
        }

        public Institucion getInstitucion()
        {
            return _instituto;
        }

        #endregion

        #region "comandos"
        public abstract void setNombre(string nombre);

        public void setFechaInicio(DateTime FechaInicio)
        {
            _inicio = FechaInicio;
        }

        public void setInstitucion(Institucion Instituto)
        {
            _instituto = Instituto;
        }
        #endregion

        #region "constructores"
        public Cursos()
        {
            _duracion = "";
            _inicio = new DateTime();
            _instituto = new Institucion();
        }
        public Cursos(string  duracion, DateTime FechaInicio, Institucion Instituto)
        {
            _duracion = duracion;
            _inicio = FechaInicio;
            _instituto = Instituto;
        }
        #endregion
    }
}
