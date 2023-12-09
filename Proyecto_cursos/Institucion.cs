using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cursos
{
    public class Institucion
    {
        #region "atributos"
        string _nombre;
        string _direccion;
        bool _privada;
        int _codigo;
        #endregion

        #region "consultas"
        public string getNombre()
        {
            return _nombre;
        }
        public string getDireccion() 
        {
            return _direccion; 
        }

        public bool EsPrivada()
        {
            return _privada;
        }

        public int getCodigo()
        {
            return _codigo;
        }

        public override string ToString()
        {
            string Cadena = _nombre + " dirección: " + _direccion;
            return Cadena;
        }

        public override bool Equals(object obj)
        {
            bool EsIgual;

            if (obj == null)
            {
                EsIgual = (this == null);
            }
            else if (obj.GetType() != typeof(Institucion))
            {
                EsIgual = false;
            }
            else
            {
                Institucion Ins = (Institucion)obj;
                EsIgual = (_codigo == Ins._codigo);
            }

            return EsIgual;
        }

        public override int GetHashCode()
        {
            return _codigo * 1600;
        }
        #endregion

        #region "comandos"
        public void setNombre(string nombre)
        {
            _nombre = nombre;
        }

        public void setDireccion(string direccion)
        {
            _direccion = direccion;
        }

        public void setEsPrivada(bool esPrivada)
        {
            _privada = esPrivada;
        }

        public void setCodigo(int codigo)
        {
            _codigo = codigo;
        }
        #endregion

        #region "constructores"
        public Institucion()
        {
            _nombre = "";
            _direccion = "";
            _privada = false;
            _codigo = 1;            
        }

        public Institucion(string nombre, string direccion, bool esPrivada, int codigo)
        {
            _nombre = nombre;
            _direccion = direccion;
            _privada = esPrivada;

            if (codigo > 0)
            {
                _codigo = codigo;
            }
            else
            {
                _codigo = 123;
            }
        }
        #endregion
    }
}
