namespace EstDatos
{
    // Acá deben ir las estructuras de datos que se avanzaron de acuerdo a las prácticas
    class CListaRecursiva
    {
        private CListaRecursiva? _aSublista = null;
        private object? _aElemento = null;

        CListaRecursiva? aSublista { get => _aSublista; set => _aSublista = value; }
        public object? aElemento { get => _aElemento; set => _aElemento = value; }
        #region Constructores
        public CListaRecursiva(CListaRecursiva Sublista, object Elemento)
        {
            aSublista = Sublista;
            aElemento = Elemento;
        }
        public CListaRecursiva(object Elemento)
        {
            aSublista = new(null, null);
            aElemento = Elemento;
        }
        #endregion
        #region Methods
        public bool EsVacia()
        {
            return aElemento == null && aSublista == null;
        }
        public void Agregar(object Elemento)
        {
            if (EsVacia())
            {
                aSublista = new(null, null);
                aElemento = Elemento;
            }
            else
            {
                aSublista.Agregar(Elemento);
            }
        }
        public void Insertar(int i, object Elemento)
        {
            if (i == 0)
            {
                aSublista = new(aSublista, aElemento);
                aElemento = Elemento;
            }
            else
            {
                if (!EsVacia())
                {
                    aSublista.Insertar(i - 1, Elemento);
                }
            }
        }
        public void Listar()
        {
            if (!EsVacia())
            {
                Console.Write(aElemento.ToString() + ", ");
                aSublista.Listar();
            }
            else
            {
                Console.WriteLine(" /");
            }
        }
        public int Longitud(int k = 0)
        {
            if (EsVacia())
            {
                return k;
            }
            else
            {
                k++;
                return aSublista.Longitud(k);
            }
        }
        public string GetElement(int position, int hold = 0)
        {
            if (!EsVacia() && hold <= position)
            {
                if (hold != position)
                {
                    hold++;
                    return aSublista.GetElement(position, hold);
                }
                else
                {
                    return aElemento.ToString();
                }
            }
            else
            {
                return "NE";
            }
        }
        public int Ubicacion(object e)
        {
            if (EsVacia())
            {
                return 0;
            }
            else
            {
                if (aElemento.Equals(e))
                {
                    return 1;
                }
                else
                {
                    int k = aSublista.Ubicacion(e);
                    return (k == 0 ? 0 : k + 1);
                }
            }
        }
        #endregion
    }
}