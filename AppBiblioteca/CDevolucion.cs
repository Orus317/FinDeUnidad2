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
            IdDevolucion = idDevolucion;
            IdPrestamo = idPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
        public CDevolucion() 
        { 
            IdDevolucion = null;
            FechaDevolucion = null;
            IdPrestamo = null;
        }
        public override void Registrar()
        {
            Console.WriteLine("Identificador de devolución : ");
            IdDevolucion = Console.ReadLine();
            Console.WriteLine("Identificador de préstamo: ");
            IdPrestamo = Console.ReadLine();
            Console.WriteLine("Fecha de devolución [DD/MM/AA]: ");
            FechaDevolucion = Console.ReadLine();
        }
        public override bool Equals(object Objeto)
        {
            if (Objeto is CDevolucion DevolucionAComparar)
            {
                // Retornará True si buscamos por nombre
                return DevolucionAComparar.IdDevolucion == IdDevolucion;
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
