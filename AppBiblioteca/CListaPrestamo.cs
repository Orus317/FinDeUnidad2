using ClasesGenerales;
using EstDatos;

namespace AppBiblioteca
{
    public class CListaPrestamo : CListaObjetos
    {
        // Constructores heredados
        public CListaPrestamo() : base() { }

        public CListaPrestamo(CListaRecursiva Lista) : base(Lista)
        {
        }

        #region Metodos 
        public void Agregar(CListaLectores Lectores, CListaTesis Tesis)
        {
            // Creación del objeto y registro de los datos a través de consola
            CPrestamo _ = new();
            _.Registrar(Lectores, Tesis);
            // Este método ya verifica si el elemento ya existe previamente en la lista
            base.Agregar(_);
        }
        public void Agregar(string IdPrestamo, string fechaPrestamo, string idTesis, string idLector, CListaLectores Lectores, CListaTesis Tesis)
        {
            // Método agregar con los atributos, para poder agregar elementos desde consola
            int flagLector = Lectores.Indice(idLector);
            int flagTesis = Tesis.Indice(idTesis);
            if (!flagLector.Equals(-1) && !flagTesis.Equals(-1))
            {
                CPrestamo _ = new(IdPrestamo, fechaPrestamo, idTesis, idLector);
                base.Agregar(_);
            }
            else
                Console.WriteLine("No existe el lector indicado");
        }
        public void NoDevueltos(CListaDevoluciones Devoluciones)
        {
            // Se crea un delegado que retorne un booleano que indique si una devolución no registra entre los prestamos
            deSeleccionarObjeto = delegate (object O)
            {
                // Se castea el objeto como un prestamo para poder comparar
                CPrestamo PrestamoToCompare = (CPrestamo)O;
                return Devoluciones.Indice(PrestamoToCompare) == -1;
            };
            // Se genera la sublista con el delegado que se declaro
            CListaRecursiva _ = GenerarSubLista();
            // Se construye otra lista de prestamos para acceder a todos las funcionalidades
            CListaPrestamo SubLista = new(_);
            Console.WriteLine($"*****************************TESIS NO DEVUELTAS*****************************");
            SubLista.Listar();
            Console.WriteLine($"****************************************************************************");
        }
        public void FiltraPorFecha()
        {
            // Se obtiene la fecha
            Console.Write("Ingrese una fecha en el formato [DD/MM/AA]: ");
            string fecha = Console.ReadLine();
            // Se crea un delegado que retorne un booleano que indique si una devolución no registra entre los prestamos
            deSeleccionarObjeto = delegate (object o)
            {
                // Se castea el objeto como un prestamo para poder acceder al atributo de la fecha y compararlo con la fecha que dio el usuario
                CPrestamo _ = (CPrestamo)o;
                return _.FechaPrestamo == fecha;
            };
            // Se genera la sublista con el delegado que se declaro
            CListaRecursiva _ = GenerarSubLista();
            // Se construye otra lista de prestamos para acceder a todos las funcionalidades
            CListaPrestamo SubLista = new(_);
            Console.WriteLine($"*****************************POR FECHA*****************************");
            SubLista.Listar();
            Console.WriteLine($"*******************************************************************");

        }

        public void Consultar()
        {
            Console.WriteLine("Escriba el ID del préstamo a buscar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            base.Consultar(KeyWord);
        }
        public void Listar()
        {
            // Se define el delegado para ejecutar la función heredada con el delegado que mostrará cada objeto
            deProcesarObjeto = delegate (Object Objeto)
            {
                if (Objeto is CPrestamo Prestamo)
                {
                    Prestamo.Mostrar();
                }
            };
            base.Listar();
        }
        public void Eliminar()
        {
            Console.Write("Escriba el ID del préstamo a eliminar: ");
            // Obtención del ID
            string KeyWord = Console.ReadLine();
            int Position = Indice(KeyWord);
            base.Eliminar(Position);
        }

        #endregion
    }
}


