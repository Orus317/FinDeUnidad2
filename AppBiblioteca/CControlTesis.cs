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
        #region Metodos
        public void Menu()
        {
            // Aqui va el menu para lectores
            Console.WriteLine("===========CONTROL DE TESIS===========");
            Console.WriteLine("1. Registrar tesis");
            Console.WriteLine("2. Consultar tesis");
            Console.WriteLine("3. Listar tesis");
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
                        ListaTesis.Agregar();
                        break;
                    case 2:
                        ListaTesis.Consultar();
                        break;
                    case 3:
                        ListaTesis.Listar();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 4);
        }
        #endregion

    }
}


