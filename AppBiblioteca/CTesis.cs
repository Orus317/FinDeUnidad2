using ClasesGenerales;
namespace AppBiblioteca
{
    public class CTesis : CObjeto
    {
        //el atributo ID es heredado de la clase abstracta
        private string? _Titulo;
        private string? _Autor;
        private int? _Anio;
        private string? _Area;
        private string? _Asesor;
        public string? Titulo { get => _Titulo; set => _Titulo = value; }
        public string? Autor { get => _Autor; set => _Autor = value; }
        public int? Anio { get => _Anio; set => _Anio = value; }
        public string? Area { get => _Area; set => _Area = value; }
        public string? Asesor { get => _Asesor; set => _Asesor = value; }

        public CTesis(string idTesis, string titulo, string autor, int anio, string area, string asesor)
        {
            Id = idTesis;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Area = area;
            Asesor = asesor;
        }

        public CTesis()
        {
            Id = null;
            Titulo = null;
            Autor = null;
            Anio = null;
            Area = null;
            Asesor = null;
        }

        // Servirá para listar las tesis por Asesor
        public string? asesor()
        {
            return Asesor;
        }

        public override void Mostrar()
        {
            // Se añade el texto al Mostrar de la clase abstracta
            base.Mostrar();
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año: {0}", Anio);
            Console.WriteLine("Area:" + Area);
            Console.WriteLine("Asesor: " + Asesor);
        }

        public override void Registrar()
        {
            // Se añaden los requerimientos al ya existente de la clase abstracta
            base.Registrar();
            Console.WriteLine("Título: ");
            Titulo = Console.ReadLine();
            Console.WriteLine("Autor: ");
            Autor = Console.ReadLine();
            Console.WriteLine("Año [DD/MM/AA]: ");
            Anio = Utilidades.ValidarEntero("Debe ingresar un año real", 0, int.MaxValue);
            Console.WriteLine("Area : ");
            Area = Console.ReadLine();
            Console.WriteLine("Asesor : ");
            Asesor = Console.ReadLine();
        }
        public override bool Equals(object Objeto)
        {
            if (Objeto is string IdToCompare)
            {
                return Id == IdToCompare;
            }
            else if (Objeto is CTesis TesisToCompare)
            {
                return TesisToCompare.Id == Id;
            }
            return false;
        }
    }
}

