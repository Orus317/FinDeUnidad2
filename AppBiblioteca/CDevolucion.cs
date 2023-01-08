using ClasesGenerales;

namespace AppBiblioteca
{
    public class CDevolucion : CObjeto
    {
        #region Atributos y Propiedades
        private string? _IdDevolucion;
        private string? _FechaDevolucion;
        private string? _IdPrestamo;
        public string IdDevolucion { get => _IdDevolucion; set => _IdDevolucion = value; }
        public string FechaDevolucion { get => _FechaDevolucion; set => _FechaDevolucion = value; }
        public string IdPrestamo { get => _IdPrestamo; set => _IdPrestamo = value; }
        #endregion
        public CDevolucion(string idDevolucion, string fechaDevolucion, string idPrestamo)
        {
            Id = idDevolucion;
            IdPrestamo = idPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
        public CDevolucion() 
        { 
            Id = null;
            FechaDevolucion = null;
            IdPrestamo = null;
        }
        public void Registrar(CListaPrestamo Prestamos)
        {
            Console.Write("Identificador de devolución : ");
            Id = Console.ReadLine();
            Console.Write("Identificador de prestamo: ");
            IdPrestamo = Console.ReadLine() ?? "";
            while (Prestamos.Indice(IdPrestamo) == -1)
            {
                Console.WriteLine("Este préstamo no existe");
                Console.Write("INGRESE Idetinficador de prestamo: ");
                IdPrestamo = Console.ReadLine() ?? "";
            }
            Console.Write("Fecha de devolución [DD/MM/AA]: ");
            FechaDevolucion = Console.ReadLine();
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Fecha: " + FechaDevolucion);
            Console.WriteLine("Identificador de préstamo: " + IdPrestamo);
        }
        public override bool Equals(object Objeto)
        {
            if (Objeto is string IdToCompare)
            {
                // Retornará true si coinciden los Id
                return Id == IdToCompare;
            }
            if (Objeto is CDevolucion DevolucionAComparar)
            {
                // Retornará True si buscamos por nombre
                return DevolucionAComparar.Id == Id;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return IdDevolucion;
        }
    }
}
