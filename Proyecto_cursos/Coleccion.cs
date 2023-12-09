using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cursos
{
    public class Coleccion
    {
        List<Institucion> ListaInstituciones;
        List<Cursos> ListaCursos;

        public Coleccion()
        {
            ListaInstituciones = new List<Institucion>();
            ListaCursos = new List<Cursos>();
        }

        #region "propiedades"
        public int CantidadInstituciones
        {
            get { return ListaInstituciones.Count; }
        }

        public int CantidadCursos
        {
            get { return ListaCursos.Count; }
        }
        #endregion

        #region "consultas INSTITUCIONES"
        public bool ExisteCodigoInstitucion(int codigo)
        {
            Institucion insti = new Institucion();
            insti.setCodigo(codigo);
            return ListaInstituciones.Contains(insti);
        }

        public bool ExisteDireccionInstituto(string direccion)
        {
            List<string> ListaDirecciones;
            ListaDirecciones = ListaDireccionesInstituciones();
            return ListaDirecciones.Contains(direccion);
        }

        public bool ExisteNombreInstituto(string nombre)
        {
            List<string> ListaNombres;
            ListaNombres = ListaNombresInstituciones();
            return ListaNombres.Contains(nombre);
        }
        public List<string> ListarInstituciones()
        {
            List<string> lista = new List<string>();
            foreach (Institucion Ins in ListaInstituciones)
            {
                lista.Add(Ins.ToString());
            }
            return lista;
        }

        public List<string> ListarInstituciones(bool privada)
        {
            List<string> lista = new List<string>();
            foreach (Institucion inst in ListaInstituciones)
            {
                if (inst.EsPrivada() == privada)
                {
                    lista.Add(inst.ToString());
                }
            }
            return lista;
        }

        public List<string> ListaNombresInstituciones()
        {
            List<string> lista = new List<string>();
            foreach (Institucion inst in ListaInstituciones)
            {
                lista.Add(inst.getNombre());
            }

            return lista;
        }

        public List<string> ListaDireccionesInstituciones()
        {
            List<string> lista = new List<string>();
            foreach (Institucion inst in ListaInstituciones)
            {
                lista.Add(inst.getDireccion());
            }

            return lista;
        }

        public string NombreInstitucion(int codigo)
        {
            Institucion inst = new Institucion();
            inst.setCodigo(codigo);
            int posicion = ListaInstituciones.IndexOf(inst);
            if (posicion != -1)
            {
                inst = ListaInstituciones[posicion];
            }

            return inst.getNombre();
        }

        public string DireccionInstitucion(int codigo)
        {
            Institucion inst = new Institucion();
            inst.setCodigo(codigo);
            int posicion = ListaInstituciones.IndexOf(inst);
            if (posicion != -1)
            {
                inst = ListaInstituciones[posicion];
            }

            return inst.getDireccion();
        }

        public int CodigoInstituto(string nombre)
        {
            bool encontre = false;
            int toReturn = 0;
            for (int i = 0; i < ListaInstituciones.Count && !encontre; i++) {
                if (ListaInstituciones[i].getNombre() == nombre) { 
                    encontre = true;
                    toReturn = ListaInstituciones[i].getCodigo();
                }
            }
            return toReturn;
        }

        public bool InstitutoEsPrivado(int codigo)
        {
            Institucion inst = new Institucion();
            inst.setCodigo(codigo);
            int posicion = ListaInstituciones.IndexOf(inst);
            if (posicion >= 0)
            {
                inst = ListaInstituciones[posicion];
            }
            return inst.EsPrivada();
        }

        public Institucion ObjInstituto(string nombre)
        {
            Institucion insti = new Institucion();
            insti.setNombre(nombre);
            int posicion = ListaInstituciones.IndexOf(insti);

            if (posicion != -1)
            {
                insti = ListaInstituciones[posicion];
            }

            return insti;
        }
        #endregion

        #region "consultas CURSOS"
        public bool ExisteReposteria(string nombre)
        {
            Reposteria repo = new Reposteria();
            repo.setNombre(nombre);
            return ListaCursos.Contains(repo);
        }

        public string DuracionReposteria(string nombre)
        {
            Reposteria repo = new Reposteria();
            repo.setNombre(nombre);
            int posicion = ListaCursos.IndexOf(repo);
            if (posicion != -1)
            {
                repo = (Reposteria)ListaCursos[posicion];
            }

            return repo.getDuracion();
        }

        public DateTime FechaReposteria(string nombre)
        {
            Reposteria repo = new Reposteria();
            repo.setNombre(nombre);
            int posicion = ListaCursos.IndexOf(repo);
            if (posicion != -1)
            {
                repo = (Reposteria)ListaCursos[posicion];
            }

            return repo.getFechaInicio();
        }

        public bool ExisteCocina(string nombre)
        {
            Cocina C = new Cocina();
            C.setNombre(nombre);
            return ListaCursos.Contains(C);
        }

        public string DuracionCocina(string nombre)
        {
            Cocina C = new Cocina();
            C.setNombre(nombre);
            int posicion = ListaCursos.IndexOf(C);
            if (posicion != -1)
            {
                C = (Cocina)ListaCursos[posicion];
            }

            return C.getDuracion();
        }

        public DateTime FechaCocina(string nombre)
        {
            Cocina C = new Cocina();
            C.setNombre(nombre);
            int posicion = ListaCursos.IndexOf(C);
            if (posicion != -1)
            {
                C = (Cocina)ListaCursos[posicion];
            }

            return C.getFechaInicio();
        }

        public List<string> ListarCursos(string tipo, int codigoIns, string duracion)
        {
            List<string> lista = new List<string>();
            bool filtroTipoOk;
            bool filtroInstitutoOk;
            bool filtroDuracionOk;

            foreach (Cursos C in ListaCursos)
            {
                filtroDuracionOk = false;
                filtroInstitutoOk = false;
                filtroTipoOk = false;
                //filtra tipo
                switch (tipo.ToLower())
                {
                    case "": case "todos": filtroTipoOk = true; break;
                    case "reposteria": filtroTipoOk = (C.GetType() == typeof(Reposteria)); break;
                    case "cocina": filtroTipoOk = C.GetType() == typeof(Cocina); break;
                }
                //filtra instituto
                if (codigoIns == 0)
                {
                    filtroInstitutoOk = true;
                }
                else
                {
                    Institucion inst = new Institucion();
                    inst.setCodigo(codigoIns);
                    filtroInstitutoOk = C.getInstitucion().Equals(inst);
                }
                //filtra duracion
                if (duracion == "" || duracion.ToLower() == "todas")
                {
                    filtroDuracionOk = true;
                }
                else
                {
                    filtroDuracionOk = C.getDuracion().Equals(duracion);
                }
                //agrega a la lista
                if (filtroTipoOk && filtroInstitutoOk && filtroDuracionOk)
                {
                    lista.Add(C.ToString());
                }
            }

            return lista;
        }
        #endregion

        #region "comandos INSTITUCIONES"
        public void InsertarInstituto(string nombre, string direccion, bool privada, int codigo)
        {
            Institucion instituto;
            instituto = new Institucion(nombre, direccion, privada, codigo);
            if (!ListaInstituciones.Contains(instituto))
            {
                ListaInstituciones.Add(instituto);
            }
        }

        public void ModificarInstituto(string nombre, string direccion, bool privada, int codigo)
        {
            Institucion instituto;
            int posicion;
            instituto = new Institucion(nombre, direccion, privada, codigo);
            posicion = ListaInstituciones.IndexOf(instituto);
            if (posicion != -1)
            {
                ListaInstituciones.RemoveAt(posicion);
                ListaInstituciones.Insert(posicion, instituto);
            }
        }

        public void EliminarInstituto(int codigo)
        {
            Institucion instituto = new Institucion();
            instituto.setCodigo(codigo);
            int posicion = ListaInstituciones.IndexOf(instituto);
            if (posicion != -1)
            {
                ListaInstituciones.RemoveAt(posicion);
            }
        }
        #endregion

        #region "comandos CURSOS"
        public void InsertarReposteria(string duracion, DateTime FechaInicio, Institucion Instituto, string nombre)
        {
            Reposteria repo;
            repo = new Reposteria(duracion, FechaInicio, Instituto, nombre);
            if (!ListaCursos.Contains(repo))
            {
                ListaCursos.Add(repo);
            }
        }

        public void ModificarReposteria(string duracion, DateTime FechaInicio, Institucion Instituto, string nombre)
        {
            Reposteria repo;
            int posicion;
            repo = new Reposteria(duracion, FechaInicio, Instituto, nombre);
            posicion = ListaCursos.IndexOf(repo);
            if (posicion != -1)
            {
                ListaCursos.RemoveAt(posicion);
                ListaCursos.Insert(posicion, repo);
            }
        }

        public void EliminarReposteria(string nombre)
        {
            Reposteria repos = new Reposteria();
            repos.setNombre(nombre);
            int posicion = ListaCursos.IndexOf(repos);
            if (posicion != -1)
            {
                ListaCursos.RemoveAt(posicion);
            }
        }

        public void InsertarCocina(string duracion, DateTime FechaInicio, Institucion Instituto, string nombre)
        {
            Cocina C;
            C = new Cocina(duracion, FechaInicio, Instituto, nombre);
            if (!ListaCursos.Contains(C))
            {
                ListaCursos.Add(C);
            }
        }

        public void ModificarCocina(string duracion, DateTime FechaInicio, Institucion Instituto, string nombre)
        {
            Cocina C;
            int posicion;
            C = new Cocina(duracion, FechaInicio, Instituto, nombre);
            posicion = ListaCursos.IndexOf(C);
            if (posicion != -1)
            {
                ListaCursos.RemoveAt(posicion);
                ListaCursos.Insert(posicion, C);
            }
        }
        
        public void EliminarCocina(string nombre)
        {
            Cocina C = new Cocina();
            C.setNombre(nombre);
            int posicion = ListaCursos.IndexOf(C);
            if (posicion != -1)
            {
                ListaCursos.RemoveAt(posicion);
            }
        }
        #endregion
    }
}
