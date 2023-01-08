namespace EstDatos
{
    public class cPila
    {
        #region ************* ATRIBUTOS ****************
        private Object aElemento;
        private cPila aSubPila;
        #endregion ATRIBUTOS

        #region ************* CONSTRUCTORES***************
        public cPila()
        {
            aElemento = null;
            aSubPila = null;
        }
        /* -------------------------------------------- */
        protected cPila(Object pElemento, cPila pSubPila)
        {
            aElemento = pElemento;
            aSubPila = pSubPila;
        }

        #endregion CONSTRUCTORES


        #region *********** METODOS ESTATICOS *************
        public static cPila Crear()
        {
            return new cPila();
        }
        /* -------------------------------------------- */
        public static cPila Crear(Object pElemento, cPila pSubPila)

        {
            return new cPila(pElemento, pSubPila);
        }

        #endregion METODOS ESTATICOS

        #region *********** PROPIEDADES *************
        private object Elemento
        {
            get
            {
                return aElemento;
            }
            set
            {
                aElemento = value;
            }
        }
        /* --------------------------------------------- */
        private cPila SubPila
        {
            get
            {
                return aSubPila;
            }
            set
            {
                aSubPila = value;
            }
        }

        #endregion PROPIEDADES


        #region *********** OTROS METODOS *************
        /* --------------------------------------------- */
        public bool EsVacia()
        {
            return ((aElemento == null) && (aSubPila == null));
        }

        /* --------------------------------------------*/

        public object Cima()
        {
            return aElemento;
        }
        /* --------------------------------------------- */
        public void Apilar(Object pElemento)
        {
            aSubPila = new cPila(aElemento, aSubPila);
            aElemento = pElemento;
        }

        /* --------------------------------------------- */
        public void Desapilar()
        {
            if (!EsVacia())
            {
                aElemento = aSubPila.Elemento;
                aSubPila = aSubPila.SubPila;
            }
            //else if (!EsVacia() && returnElement)
            //{
            //    string _ = aElemento.ToString() ?? "";
            //    aElemento = aSubPila.Elemento;
            //    aSubPila = aSubPila.SubPila;
            //    return _;
            //}
        }
        public object? Desapilar(bool returnElement)
        {
            if (!EsVacia() && returnElement)
            {
                string? _ = aElemento.ToString();
                aElemento = aSubPila.Elemento;
                aSubPila = aSubPila.SubPila;
                return _;
            }
            return null;
        }
        public void Listar()
        {
            if (!EsVacia())
            {
                Console.Write($"{aElemento}");
                aSubPila.Listar();
            }
        }
        public string Listar(bool toString = true, string Sum = "")
        {
            if (!EsVacia() && toString)
            {
                Sum += Cima();
                return aSubPila.Listar(true, Sum);
            }
            return Sum;
        }
        public int Longitud(int k = 0)
        {
            if (!EsVacia())
            {
                k += 1;
                return aSubPila.Longitud(k);
            }
            return k;
        }
        #endregion OTROS METODOS
    }
}
