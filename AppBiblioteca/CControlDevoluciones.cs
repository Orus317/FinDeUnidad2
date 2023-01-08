using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlDevoluciones
    {
        private CListaDevoluciones _ListaDevoluciones;
        public CListaDevoluciones ListaDevoluciones { get => _ListaDevoluciones; set => _ListaDevoluciones = value; }
        #region Constructores
        public CControlDevoluciones()
        {
            ListaDevoluciones = new();
        }
        public CControlDevoluciones(CListaDevoluciones listaDevoluciones)
        {
            // Constructor para trabajar con listas que ya contengan elementos
            ListaDevoluciones = listaDevoluciones;
        }
        #endregion
        #region Metodos
        public void Menu()
        {
            // Aqui va el menu para lectores
            Console.WriteLine("===========CONTROL DE DEVOLUCIONES===========");
            Console.WriteLine("1. Registrar devolucion");
            Console.WriteLine("2. Consultar devolucion");
            Console.WriteLine("3. Listar devoluciones");
            Console.WriteLine("4. Eliminar devolucion");
            Console.WriteLine("5. Salir");
        }
        public void Ejecutar()
        {
            int Opcion;
            do
            {
                Menu();
                Console.Write("--> ");
                Opcion = Utilidades.ValidarEntero("Ingrese un número entre 1 y 5", 1, 5);
                switch (Opcion)
                {
                    case 1:
                        ListaDevoluciones.Agregar();
                        break;
                    case 2:
                        ListaDevoluciones.Consultar();
                        break;
                    case 3:
                        ListaDevoluciones.Listar();
                        break;
                    case 4:
                        ListaDevoluciones.Eliminar();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 5);
        }
        #endregion
    }
}
