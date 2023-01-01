using System.Diagnostics.Contracts;

namespace EstDatos
{
    public interface ILista
    {
        /// <summary>
        /// Método para determinar si un nodo/elemento de la lista es vacío
        /// </summary>
        /// <returns>True or False</returns>
        bool EsVacia();
        /// <summary>
        /// Método para calcular la cantidad de elementos
        /// </summary>
        /// <param name="k">Contador</param>
        /// <returns></returns>
        int Longitud(int k = 0);
        /// <summary>
        /// Método para agregar un elemento a la lista (al final)
        /// </summary>
        void Agregar(object Element);
        /// <summary>
        /// Método para insertar un elemento en una posición determinada
        /// </summary>
        /// <param name="Element">Elemento a colocar</param>
        /// <param name="Position">Posición en la que colocar</param>
        void Insertar(object Element, int Position);
        /// <summary>
        /// Retornar el elemento de la posición "Position"
        /// </summary>
        /// <param name="Position">Posición solicitada</param>
        /// <returns></returns>
        object Iesimo(int Position, int hold);
        /// <summary>
        /// Método para buscar un elemento
        /// </summary>
        /// <param name="Element">Elemento a ser buscado</param>
        /// <returns></returns>
        int Ubicacion(object Element);
        /// <summary>
        /// Elimina un elemento de la lista
        /// </summary>
        /// <param name="Position">Elemento a eliminar</param>
        void Eliminar(int Position);
        /// <summary>
        /// Lista todos los elementos
        /// </summary>
        void Listar();
    }
    // Acá deben ir las estructuras de datos que se avanzaron de acuerdo a las prácticas
    public class CListaRecursiva : ILista
    {
        #region Atributos y Campos
        // Se declaran los atributos de una lista recursiva: la sublista y el elemento que contiene
        private CListaRecursiva? _aSublista;
        private object? _aElemento;
        private CListaRecursiva? ASublista { get => _aSublista; set => _aSublista = value; }
        public object? AElemento { get => _aElemento; set => _aElemento = value; }
        #endregion
        #region Constructores
        public CListaRecursiva()
        {
            // Constructor predeterminado
            _aSublista = null;
            _aElemento = null;
        }
        public CListaRecursiva(object Elemento)
        {
            // Constructor que crea una sublista nula y almacena un elemento en la lista actual
            ASublista = new(null, null);
            AElemento = Elemento;
        }
        public CListaRecursiva(CListaRecursiva Sublista, object Elemento)
        {
            // Constructor que enlaza una sublista y contiene un elemento
            ASublista = Sublista;
            AElemento = Elemento;
        }
        #endregion
        #region Methods
        public bool EsVacia()
        {
            return AElemento == null && ASublista == null;
        }
        public void Agregar(object Elemento)
        {
            if (EsVacia())
            {
                ASublista = new(null, null);
                AElemento = Elemento;
            }
            else
            {
                // Ejecución recursiva para acceder a la siguiente sublista hasta encontrar la que esté vacía
                ASublista.Agregar(Elemento);
            }
        }
        public void Insertar(object Elemento, int Position)
        {
            if (Position == 0)
            {
                // Se crea un apuntador que replique el elemento y se enlace tanto con el elemento que se inserta como con el que presigue al que está siendo desplazado
                ASublista = new(ASublista, AElemento);
                // Se reemplaza el elemento
                AElemento = Elemento;
            }
            else
            {
                // Verificar que el elemento no sea nulo para la inserción
                if (!EsVacia())
                {
                    // Se hace el llamado recursivo y se avanza en la lista
                    ASublista.Insertar(Elemento, Position - 1);
                }
            }
        }
        public void Listar()
        {
            // 
            if (!EsVacia())
            {
                Console.Write(AElemento.ToString() + ", ");
                ASublista.Listar();
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
                // Si la lista está vacía retornará cero
                return k;
            }
            else
            {
                // se adiciona uno y se adentra un nivel más en la recursión de la lista
                k++;
                return ASublista.Longitud(k);
            }
        }
        public object Iesimo(int position, bool returnSubList, int hold = 0)
        {
            // Este método privado de localización de objetos esta dotado de poder devolver el objeto sublista 
            if (!EsVacia() && hold <= position)
            {

                if (hold != position)
                {
                    hold++;
                    return ASublista.Iesimo(position, returnSubList, hold);
                }
                else
                {
                    return returnSubList ? this : AElemento;
                }
            }
            else
            {
                return null;
            }
        }
        public object Iesimo(int position, int hold = 0)
        {
            if (!EsVacia() && hold <= position)
            {

                if (hold != position)
                {
                    hold++;
                    return ASublista.Iesimo(position, hold);
                }
                else
                {
                    return AElemento;
                }
            }
            else
            {
                return "NE";
            }
        }
        private int ubicacion(object e)
        {
            if (EsVacia())
            {
                return 0;
            }
            else
            {
                if (AElemento.Equals(e))
                {
                    return 1;
                }
                else
                {
                    int k = ASublista.ubicacion(e);
                    return (k == 0 ? 0 : k + 1);
                }
            }
        }
        public int Ubicacion(object e)
        {
            // Retorna el índice del elemento pasado
            return ubicacion(e) - 1;
        }
        public void Eliminar(int Position)
        {
            if (!EsVacia())
            {
                if (Position == 0)
                {
                    AElemento = ASublista.AElemento;
                    ASublista = ASublista.ASublista;
                }
                else
                {
                    CListaRecursiva previousElement = (CListaRecursiva)Iesimo(Position - 1, true);
                    previousElement.ASublista = previousElement.ASublista.ASublista;
                }
            }
        }
        #endregion
    }
}