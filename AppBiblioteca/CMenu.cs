using ClasesGenerales;
namespace AppBiblioteca
{
    public class CMenu
    {

        public static void MostrarMenu(CControlTesis Tesis, CControlLectores Lectores, CControlPrestamo Prestamos, CControlDevoluciones Devoluciones)
        {
            Console.WriteLine("========= Bibliteca =========");
            Console.WriteLine("1• Tesis");
            Console.WriteLine("2• Lectores");
            Console.WriteLine("3• Préstamos");
            Console.WriteLine("4• Devoluciones");
            Console.WriteLine();

            Console.Write(" -- Ingrese la opción: ");
            int Opcion = Utilidades.ValidarEntero("Debe ingresar un número del 1 al 4: ", 1, 5);
            EjecutarOpcion(Opcion, Tesis, Lectores, Prestamos, Devoluciones);
        }

        private static void EjecutarOpcion(int opcion, CControlTesis Tesis, CControlLectores Lectores, CControlPrestamo Prestamos, CControlDevoluciones Devoluciones)
        {
            switch (opcion)
            {
                case 1:
                    Tesis.Ejecutar();
                    break;
                case 2:
                    Lectores.Ejecutar();
                    break;
                case 3:
                    Prestamos.Ejecutar();
                    break;
                case 4:
                    Devoluciones.Ejecutar();
                    break;
                default:
                    break;
            }
        }
    }
}
