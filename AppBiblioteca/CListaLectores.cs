using System.Xml.Serialization;
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
        public void Agregar(string IdLector, string Apellido, string Nombre, string Direccion, string Sexo, int Edad)
        {
            // Método agregar para agregar métodos directamente desde el programa
            CLector _ = new(IdLector, Apellido, Nombre, Direccion, Sexo, Edad);
            base.Agregar(_);
        }
        public void Consultar()
        {
            Console.Write("Escriba el ID o nombre/apellido del lector que desea buscar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            base.Consultar(KeyWord);
        }
        public new void Listar()
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
        public void Eliminar()
        {
            Console.Write("Escriba el ID o nombre/apellido del lector que desea eliminar: ");
            string KeyWord = Console.ReadLine();
            int Position = Indice(KeyWord);
            base.Eliminar(Position);
        }
        #endregion
    }
}
