using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlPrestamo : CListaPrestamo
    {
        private CListaPrestamo _ListaPrestamo;
        public CListaPrestamo ListaPrestamo { get => _ListaPrestamo; set => _ListaPrestamo = value; }

        public CControlPrestamo()
        {
            ListaPrestamo = new();
        }
        #region Metodos
        public void Menu()
        {
            // Aqui va el menu para lectores
            Console.WriteLine("===========CONTROL DE LECTORES===========");
            Console.WriteLine("1. Registrar préstamo");
            Console.WriteLine("2. Consultar préstamo");
            Console.WriteLine("3. Listar préstamos");
            Console.WriteLine("4. Salir");
            Console.WriteLine();
            Console.Write(" -- Ingrese la opción: ");
        }
        public void Ejecutar()
        {
            int Opcion;
            do
            {
                Menu();
                Opcion = Utilidades.ValidarEntero("Ingrese un número entre 1 y 4", 1, 4);
                switch (Opcion)
                {
                    case 1:
                        ListaPrestamo.Agregar();
                        break;
                    case 2:
                        ListaPrestamo.Consultar();
                        break;
                    case 3:
                        ListaPrestamo.Listar();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 5);
        }
        #endregion

    }
}

