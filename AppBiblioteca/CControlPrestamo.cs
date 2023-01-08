using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlPrestamo : CListaPrestamo
    {
        private CListaPrestamo _ListaPrestamo;
        private CListaLectores _ListaLectores;
        private CListaTesis _ListaTesis;
        private CListaDevoluciones _ListaDevoluciones;
        public CListaPrestamo ListaPrestamo { get => _ListaPrestamo; set => _ListaPrestamo = value; }
        public CListaLectores ListaLectores { get => _ListaLectores; set => _ListaLectores = value; }
        public CListaTesis ListaTesis { get => _ListaTesis; set => _ListaTesis = value; }
        public CListaDevoluciones ListaDevoluciones { get => _ListaDevoluciones; set => _ListaDevoluciones = value; }

        public CControlPrestamo()
        {
            ListaPrestamo = new();
            ListaLectores = new();
        }
        public CControlPrestamo(CListaPrestamo listaPrestamo, CListaLectores Lectores, CListaTesis Tesis, CListaDevoluciones Devoluciones)
        {
            ListaPrestamo = listaPrestamo;
            ListaLectores = Lectores;
            ListaTesis = Tesis;
            ListaDevoluciones = Devoluciones;
        }
        public void Menu()
        {
            // Opciones Con respecto a las tesis
            Console.WriteLine();
            Console.WriteLine("===========CONTROL DE PRESTAMOS===========");
            Console.WriteLine("1. Registrar préstamo");
            Console.WriteLine("2. Consultar préstamo");
            Console.WriteLine("3. Listar préstamos");
            Console.WriteLine("4. Eliminar Prestamo");
            Console.WriteLine("5. Listar tesis no devueltas");
            Console.WriteLine("6. Listar prestamos en una determinada fecha");
            Console.WriteLine("7. Salir");
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
                Opcion = Utilidades.ValidarEntero("Ingrese un número entre 1 y 7", 1, 7);
                switch (Opcion)
                {
                    case 1:
                        ListaPrestamo.Agregar(ListaLectores, ListaTesis);
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
                    case 5:
                        ListaPrestamo.NoDevueltos(ListaDevoluciones);
                        break;
                        case 6:
                        ListaPrestamo.FiltraPorFecha();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 7);
        }

    }
}

