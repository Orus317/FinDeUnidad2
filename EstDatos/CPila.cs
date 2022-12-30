namespace EstDatos
{
    internal class CPila
    {
        public interface IStack
        {
            /// <summary>
            /// Función que retorna si la pila está vacía o no en función de si existe o no un TopElement
            /// </summary>
            /// <returns>True or False</returns>
            public bool IsEmpty();
            /// <summary>
            /// Retorna el último elemento de la pila siguiendo el principio LIFO (last in first out)
            /// </summary>
            /// <returns><i>El elemento de la cima</i></returns>
            public object Top();
            /// <summary>
            /// Método para agregar un elemento en la cima de la pila
            /// </summary>
            /// <param name="Element">Elemento a agregar</param>
            public void Push(object Element);
            /// <summary>
            /// Método para retornar la longitud de la pila o la cantidad de elementos de la pila
            /// </summary>
            /// <returns>Entero que representa el <i>número de elemento</i></returns>
            public int Size();
        }
        public class CNodoStack
        {
            #region Atributos y propiedades/campos
            private Object? _Element;
            public object? Element { get => _Element; set => _Element = value; }
            #endregion
            #region Constructor
            public CNodoStack(object? element)
            {
                Element = element;
            }
            #endregion

        }
        public class Stack : IStack
        {
            private object? _TopElement;
            public object? TopElement { get => _TopElement; set => _TopElement = value; }
            // Constructor para un stack vacío
            public Stack()
            {
                TopElement = null;
            }
            // En caso de tener un elemento desde el inicio
            public Stack(object? top)
            {
                TopElement = top;
            }
            #region Methods/ Implementation of interface
            public bool IsEmpty()
            {
                return TopElement == null;
            }

            public object? Top()
            {
                return TopElement ?? null;
            }

            public void Push(object Element)
            {
                throw new NotImplementedException();

            }

            public int Size()
            {
                throw new NotImplementedException();
            }
            #endregion
        }
    }
}
