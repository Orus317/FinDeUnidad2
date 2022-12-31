using System.Collections;
using EstDatos;

namespace ClasesGenerales
{
    public delegate void DelegadoProcesarObjeto(object O);
    public delegate bool DelegadoSeleccionarObjeto(object O);

    public class CListaObjetos
    {
        #region  ATRIBUTOS 
        private CListaRecursiva aListado;
        // ----- Delegado para procesar los objetos de la lista
        public DelegadoProcesarObjeto deProcesarObjeto = null;
        // ----- Delegado para seleccionar los objetos de la lista
        public DelegadoSeleccionarObjeto deSeleccionarObjeto = null;

        #endregion   

        #region  PROPIEDADES 
        public CListaRecursiva Listado
        {
            get { return aListado; }
            set { aListado = value; }
        }
        #endregion  PROPIEDADES 

        #region  CONSTRUCTORES 
        public CListaObjetos()
        {
            aListado = new CListaRecursiva();
        }
        #endregion  CONSTRUCTORES 


        #region    OTROS     
        public void Agregar(CObjeto Objeto)
        {
            // ----- Verificar que objeto no exista en la lista
            if (Indice(Objeto) < 0)
                Listado.Agregar(Objeto);
            else
                // ----- Objeto ya existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Objeto.Id + " ya existe en la lista, por tanto, no será agregado...");
        }

        // ==============================================================
        public int Indice(Object Objeto)
        {
            return Listado.Ubicacion(Objeto.ToString());
        }

        // ==============================================================
        public void Consultar(object pId)
        {
            // ----- Determinar Indice o ubicacion del Identificador
            int I = Indice(pId);
            if (I >= 0)
            {
                CObjeto Objeto = (Listado.Iesimo(I) as CObjeto);
                Objeto.Mostrar();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(pId + " No existe en la lista...");
        }

        // ==============================================================
        public virtual void ProcesarObjeto(Object O)
        {
            CObjeto Objeto = O as CObjeto;
            Objeto.Escribir();
        }

        // ==============================================================
        public CListaRecursiva GenerarSubLista()
        {
            // ----- Generar lista vacia
            CListaRecursiva Aux = new CListaRecursiva();
            // ----- Recorrer la lista y seleccionar objetos para la sublista
            for (int K = 0; K < Listado.Longitud(); K++)
                // ----- Procesar K-ésimo Objeto
                if ((deSeleccionarObjeto == null) || deSeleccionarObjeto(Listado.Iesimo(K)))
                    Aux.Agregar(Listado.Iesimo(K));
            // ----- Retornar sub lista
            return Aux;
        }

        // ==============================================================
        public void RecorrerListado()
        {
            // ----- Recorrer listado para procesar cada objeto de la lista
            for (int K = 0; K < Listado.Longitud(); K++)
                // ----- Procesar K-ésimo Objeto
                if (deProcesarObjeto != null)
                    deProcesarObjeto(Listado.Iesimo(K));
                else
                    ProcesarObjeto(Listado.Iesimo(K));
        }

        #endregion
    }
}
