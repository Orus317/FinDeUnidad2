using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaPrestamo : CListaObjetos
    {
        public CListaPrestamo() : base() { }
        #region Metodos
        public void Agregar(CListaLectores Lectores)
        {
            // Creación del objeto y registro de los datos a través de consola
            CPrestamo _ = new();
            _.Registrar(Lectores);
            // Este método ya verifica si el elemento ya existe previamente en la lista
            base.Agregar(_);
        }

        public void Agregar(string IdPrestamo, string fechaPrestamo, string idTesis, string idLector, CListaLectores Lectores)
        {
            int flag = Lectores.Indice(idLector);
            if (!flag.Equals(-1))
            {
                CPrestamo _ = new(IdPrestamo, fechaPrestamo, idTesis, idLector);
                base.Agregar(_);
            }
            else
                Console.WriteLine("No existe el lector indicado");
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
        public void Eliminar()
        {
            Console.Write("Escriba el ID del préstamo a eliminar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            int Position = Indice(KeyWord);
            base.Eliminar(Position);
        }

        #endregion
    }
}


