using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlTesis : CListaTesis
    {
        private CListaTesis _ListaTesis;
        public CListaTesis ListaTesis { get => _ListaTesis; set => _ListaTesis = value; }

        public CControlTesis()
        {
            ListaTesis = new();
        }
        public CControlTesis(CListaTesis listaTesis)
        {
            ListaTesis = listaTesis;
        }
        #region Metodos
        public void Menu()
        {
            // Opciones Con respecto a las tesis
            Console.WriteLine();
            Console.WriteLine("===========CONTROL DE TESIS===========");
            Console.WriteLine("1. Registrar tesis");
            Console.WriteLine("2. Consultar tesis");
            Console.WriteLine("3. Listar tesis");
            Console.WriteLine("4. Eliminar tesis");
            Console.WriteLine("5. Listar tesis por asesor");
            Console.WriteLine("6. Listar tesis por año");
            Console.WriteLine("7. Top 3 docentes con más asesorías");
            Console.WriteLine("8. Salir");
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
                Opcion = Utilidades.ValidarEntero("Ingrese un número entre 1 y 7", 1, 8);
                switch (Opcion)
                {
                    case 1:
                        ListaTesis.Agregar();
                        break;
                    case 2:
                        ListaTesis.Consultar();
                        break;
                    case 3:
                        ListaTesis.Listar();
                        break;
                    case 4:
                        ListaTesis.Eliminar();
                        break;
                    case 5:
                        ListaTesis.ListarAsesor();
                        break;
                    case 6:
                        ListaTesis.FiltrarAnnio();
                        break;
                    case 7:
                        ListaTesis.Top3Asesores();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 7);
        }
        #endregion

    }
}


