using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlPrestamo : CListaPrestamo
    {
        private CListaPrestamo _ListaPrestamo;
        private CListaLectores _ListaLectores;
        public CListaPrestamo ListaPrestamo { get => _ListaPrestamo; set => _ListaPrestamo = value; }
        public CListaLectores ListaLectores { get => _ListaLectores; set => _ListaLectores = value; }

        public CControlPrestamo()
        {
            ListaPrestamo = new();
            ListaLectores = new();
        }
        public CControlPrestamo(CListaPrestamo listaPrestamo, CListaLectores Lectores){
            ListaPrestamo = listaPrestamo;
            ListaLectores = Lectores;
        }
        #region Metodos
        public void Menu()
        {
            // Opciones Con respecto a las tesis
            Console.WriteLine();
            Console.WriteLine("===========CONTROL DE PRESTAMOS===========");
            Console.WriteLine("1. Registrar préstamo");
            Console.WriteLine("2. Consultar préstamo");
            Console.WriteLine("3. Listar préstamos");
            Console.WriteLine("4. Eliminar Prestamo");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
            Console.Write(" -- Ingrese la opción: ");
        }
        public void Ejecutar()
        {
            // Ejecución de las opciones del menú
            int Opcion;
            do
            {
                Menu();
                Opcion = Utilidades.ValidarEntero("Ingrese un número entre 1 y 4", 1, 5);
                switch (Opcion)
                {
                    case 1:
                        ListaPrestamo.Agregar(ListaLectores);
                        break;
                    case 2:
                        ListaPrestamo.Consultar();
                        break;
                    case 3:
                        ListaPrestamo.Listar();
                        break;
                    case 4:
                        ListaPrestamo.Eliminar();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 5);
        }
        #endregion

    }
}

