using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlLectores : CListaLectores
    {
        private CListaLectores _ListaLectores;
        public CListaLectores ListaLectores { get => _ListaLectores; set => _ListaLectores = value; }
        public CControlLectores()
        {
            ListaLectores = new();
        }
        #region Metodos
        public void Menu()
        {
            // Aqui va el menu para lectores
            Console.WriteLine("===========CONTROL DE LECTORES===========");
            Console.WriteLine("1. Registrar lector");
            Console.WriteLine("2. Consultar lector");
            Console.WriteLine("3. Listar lectores");
            Console.WriteLine("4. Salir");
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
                        ListaLectores.Agregar();
                        break;
                    case 2:
                        ListaLectores.Consultar();
                        break;
                    case 3:
                        ListaLectores.Listar();
                        break;
                    default:
                        break;
                }

            } while (0 < Opcion && Opcion < 5);
        }
        #endregion

    }
}
