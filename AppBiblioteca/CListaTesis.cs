using ClasesGenerales;
using EstDatos;

namespace AppBiblioteca
{
    public class CListaTesis : CListaObjetos
    {
        public CListaTesis() : base() { }
        public CListaTesis(CListaRecursiva Lista) : base(Lista) {}
        #region Metodos
        public void Agregar()
        {
            // Creación del objeto y registro de los datos a través de consola
            CTesis _ = new();
            _.Registrar();
            // Este método ya verifica si el elemento ya existe previamente en la lista
            base.Agregar(_);
        }

        public void Agregar(string IdTesis, string Titulo, string Autor, int Anio, string Area, string Asesor)
        {
            CTesis _ = new(IdTesis, Titulo, Autor, Anio, Area, Asesor);
            base.Agregar(_);
        }

        public void Consultar()
        {
            Console.WriteLine("Escriba el ID de la tesis a buscar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            base.Consultar(KeyWord);
        }

        public new void Listar()
        {
            // Se define el delegado para ejecutar la función heredada con el delegado que mostrará cada objeto
            deProcesarObjeto = delegate (Object Objeto)
            {
                if (Objeto is CTesis Tesis)
                {
                    Tesis.Mostrar();
                }
            };
            base.Listar();
        }

        public void Eliminar()
        {
            Console.Write("Escriba el ID de la tesis a eliminar: ");
            string KeyWord = Console.ReadLine();
            int Position = Indice(KeyWord);
            base.Eliminar(Position);
        }

        public void ListarAsesor()
        {
            Console.Write("Especifique al asesor: ");
            string asesor = Console.ReadLine();
            // Se define el delegado para ejecutar la función heredada con el delegado que mostrará cada objeto
            deProcesarObjeto = delegate (Object Objeto)
            {
                if (Objeto is CTesis Tesis)
                {
                    // Se verifica si la tesis coincide con el asesor
                    if (Tesis.asesor() == asesor)
                        Tesis.Mostrar();
                }
            };
            base.Listar();
        }
        public void FiltrarAnnio()
        {
            // Ingreso del annio deseado
            Console.Write("Ingrese el año a comparar: ");
            int annio = Utilidades.ValidarEntero("El número debe ser positivo", 0, int.MaxValue);
            // Declaración del delegado que filtra según año
            deSeleccionarObjeto = delegate (object o)
            {
                CTesis _ = (CTesis) o;
                return _.Anio >= annio;
            };
            CListaRecursiva _ = GenerarSubLista();
            CListaTesis SubLista = new(_);
            Console.WriteLine("*************************FILTRO POR AÑO*************************");
            SubLista.Listar();
            Console.WriteLine("****************************************************************");
        }
        public void Top3Asesores()
        {
            // Generar una lista que contenga el nombre de todos los asesores, aun con repeticiones
            // Contar las repeticiones de la lista
            List<string> Asesores = new();
            deSeleccionarObjeto = delegate (object Objeto)
            {
                // Se crea una lista que solo contenga a los asesores
                CTesis TesisToCompare = (CTesis)Objeto;
                string Asesor = TesisToCompare.Asesor.ToUpper();
                Asesores.Add(Asesor);
                return true;
            };
            // Una vez se ejecuta generar sub lista se modifica la lista Asesor por referencia
            GenerarSubLista();
            // Se agrupan los asesores y se cuentan las ocurrencias de cada asesor
            var Enumerado = Asesores.GroupBy(i => i);
            // Se ordenan descendentemente
            Enumerado = Enumerado.OrderByDescending(i => i.Count());
            // Se crea un contador para que solo se muestren los tres asesores con más incidencias
            int k = 0;
            foreach (var elemento in Enumerado)
            {
                Console.WriteLine("--> (Asesor) {0} asesoró {1} tesi(s)", elemento.Key, elemento.Count());
                k++;
                if (k == 3)
                    break;
            }
        }
        #endregion
    }
}

