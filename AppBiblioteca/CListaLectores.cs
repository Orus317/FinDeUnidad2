using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaLectores : CListaObjetos
    {
        public CListaLectores() : base() { }
        #region Metodos
        public void Agregar()
        {
            // Creación del objeto y registro de los datos a través de consola
            CLector _ = new();
            _.Registrar();
            // Este método ya verifica si el elemento ya existe previamente en la lista
            base.Agregar(_);
        }
        public void Consultar()
        {
            Console.WriteLine("Escriba el ID o nombre/apellido del lector que desea buscar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            base.Consultar(KeyWord);
        }
        public void Listar()
        {
            // Se define el delegado para ejecutar la función heredada con el delegado que mostrará cada objeto
            deProcesarObjeto = delegate (Object Objeto)
            {
                if (Objeto is CLector Lector)
                {
                    Lector.Mostrar();
                }
            };
            base.Listar();
        }
        #endregion
    }
}
