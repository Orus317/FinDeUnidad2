using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaDevoluciones : CListaObjetos
    {
        public CListaDevoluciones() : base() { }
        public void Agregar()
        {
            // Creación del objeto y registro de los datos a través de consola
            CLector _ = new();
            _.Registrar();
            // Este método ya verifica si el elemento ya existe previamente en la lista
            base.Agregar(_);
        }
        public void Agregar(string IdDevolucion, string FechaDevolucion, string IdPrestamo)
        {
            // Método para agregar sin necesidad de registrar a través de consola
            CDevolucion _ = new(IdDevolucion, FechaDevolucion, IdPrestamo);
            base.Agregar(_);
        }
        public void Consultar()
        {
            Console.Write("Escriba el ID de la devolución que desea buscar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            base.Consultar(KeyWord);
        }
        public new void Listar()
        {
            // Se define el delegado para ejecutar la función heredada con el delegado que mostrará cada objeto
            deProcesarObjeto = delegate (Object Objeto)
            {
                if (Objeto is CDevolucion Devolucion)
                {
                    Devolucion.Mostrar();
                }
            };
            base.Listar();
        }
        public void Eliminar()
        {
            Console.Write("Escriba el ID de la devolucion que desea eliminar: ");
            string KeyWord = Console.ReadLine();
            int Position = Indice(KeyWord);
            base.Eliminar(Position);
        }
    }
}
