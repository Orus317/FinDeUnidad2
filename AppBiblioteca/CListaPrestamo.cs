using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaPrestamo : CListaObjetos
    {
        public CListaPrestamo() : base() { }
        #region Metodos
        public void Agregar()
        {
            // Creación del objeto y registro de los datos a través de consola
            CPrestamo _ = new();
            _.Registrar();
            // Este método ya verifica si el elemento ya existe previamente en la lista
            base.Agregar(_);
        }
        public void Consultar()
        {
            Console.WriteLine("Escriba el ID del préstamo a buscar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            base.Consultar(KeyWord);
        }
        public void Listar()
        {
            // Se define el delegado para ejecutar la función heredada con el delegado que mostrará cada objeto
            deProcesarObjeto = delegate (Object Objeto)
            {
                if (Objeto is CPrestamo Prestamo)
                {
                    Prestamo.Mostrar();
                }
            };
            base.Listar();
        }
        #endregion
    }
}


