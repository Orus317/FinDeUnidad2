using ClasesGenerales;
namespace AppBiblioteca
{
    // TODO: CPrestamo (IdPrestamo, FechaPrestamo, IdTesis, IdLector)
    public class CPrestamo : CObjeto
    {
        private string? _FechaPrestamo;
        private string? _IdTesis;
        private string? _IdLector;

        public string? FechaPrestamo { get => _FechaPrestamo; set => _FechaPrestamo = value; }
        public string? IdTesis { get => _IdTesis; set => _IdTesis = value; }
        public string? IdLector { get => _IdLector; set => _IdLector = value; }

        public CPrestamo(string IdPrestamo, string fechaPrestamo, string idTesis, string idLector)
        {
            Id = IdPrestamo;
            FechaPrestamo = fechaPrestamo;
            IdTesis = idTesis;
            IdLector = idLector;
        }

        public CPrestamo()
        {
            Id = null;
            FechaPrestamo = null;
            IdTesis = null;
            IdLector = null;
        }



        public override bool Equals(object Objeto)
        {
            if (base.Equals(Objeto))
            {
                // Retorna 'true' si coincide por ID
                return true;
            }
            else if (Objeto is CPrestamo TesisAComparar)
            {
                // Retornará True si buscamos por nombre
                return TesisAComparar.Id.Contains(Id) || TesisAComparar.IdLector == IdLector;
            }
            else
            {
                return false;
            }
        }

        public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Fecha: " + FechaPrestamo);
            Console.WriteLine("Tesis: " + IdTesis);
            Console.WriteLine("Lector: {0}", IdLector);
        }

        public override void Registrar(){
            base.Registrar();
            Console.WriteLine("Fecha [DD/MM/AA]: ");
            FechaPrestamo = Console.ReadLine();
            Console.WriteLine("Identificador de tesis: ");
            IdTesis = Console.ReadLine();
            Console.WriteLine("Identificador del lector : ");
            IdLector = Console.ReadLine();
        }

    }
}

