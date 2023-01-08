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
            if (Objeto is string IdToCompare)
            {
                // Retorna 'true' si coincide por ID
                return Id == IdToCompare;
            }
            else if (Objeto is CPrestamo PrestamoAComparar)
            {
                // Retornará True si buscamos por nombre
                return PrestamoAComparar.Id == Id;
            }
            else
            {
                return false;
            }
        }
        public string? IdPrestamo(){
            return Id;
        }

        public override void Mostrar(){
            // Se añade el texto al Mostrar de la clase abstracta
            base.Mostrar();
            Console.WriteLine("Fecha: " + FechaPrestamo);
            Console.WriteLine("Tesis: " + IdTesis);
            Console.WriteLine("Lector: {0}", IdLector);
        }

        public void Registrar(CListaLectores Lectores){
            // Se añaden los requerimientos al ya existente (Id) de la clase abstracta
            base.Registrar();
            Console.WriteLine("Fecha [DD/MM/AA]: ");
            FechaPrestamo = Console.ReadLine();
            Console.WriteLine("Identificador de tesis: ");
            IdTesis = Console.ReadLine();
            Console.WriteLine("Identificador del lector : ");
            IdLector = Console.ReadLine() ?? "";
            // Verificar si el lector existe 
            while (Lectores.Indice(IdLector) == -1)
            {
                Console.WriteLine("El lector no existe");
                Console.Write("INGRESE Idetinficador del lector: ");
                IdLector = Console.ReadLine() ?? "";
            }
        }

    }
}

