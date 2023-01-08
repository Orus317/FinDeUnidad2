using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaDevoluciones : CListaObjetos
    {
        public CListaDevoluciones() : base() { }
        public void Agregar(CListaPrestamo Prestamos)
        {
            // Creación del objeto y registro de los datos a través de consola
            CDevolucion _ = new();
            _.Registrar(Prestamos);
            // Este método ya verifica si el elemento ya existe previamente en la lista
            base.Agregar(_);
        }
        public void Agregar(string IdDevolucion, string FechaDevolucion, string IdPrestamo, CListaPrestamo Prestamos)
        {
            // Método para agregar sin necesidad de registrar a través de consola
            int flag = Prestamos.Indice(IdPrestamo);
            if (!flag.Equals(-1))
            {
                CDevolucion _ = new(IdDevolucion, FechaDevolucion, IdPrestamo);
                base.Agregar(_);
            }
            else
                Console.WriteLine("No existe el préstamo indicado");
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
