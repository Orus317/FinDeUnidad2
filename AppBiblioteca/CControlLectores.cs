using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlLectores : CListaLectores
    {
        private CListaLectores _ListaLectores;
        public CListaLectores ListaLectores { get => _ListaLectores; set => _ListaLectores = value; }
        #region Constructores
        public CControlLectores()
        {
            ListaLectores = new();
        }
        public CControlLectores(CListaLectores listaLectores)
        {
            // Constructor para trabajar con listas que ya contengan elementos
            ListaLectores = listaLectores;
        }
        #endregion
        #region Metodos
        public void Menu()
        {
            // Aqui va el menu para lectores
            Console.WriteLine();
            Console.WriteLine("===========CONTROL DE LECTORES===========");
            Console.WriteLine("1. Registrar lector");
            Console.WriteLine("2. Consultar lector");
            Console.WriteLine("3. Listar lectores");
            Console.WriteLine("4. Eliminar lector");
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
                        ListaLectores.Agregar();
                        break;
                    case 2:
                        ListaLectores.Consultar();
                        break;
                    case 3:
                        ListaLectores.Listar();
                        break;
                    case 4:
                        ListaLectores.Eliminar();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 5);
        }
        #endregion

    }
}
