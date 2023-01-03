using ClasesGenerales;

namespace AppBiblioteca
{
    // Acá deben ir las clases que nos repartimos, las clases que manejen las listas de dichos objetos y las clases de control
    public class CLector : CObjeto
    {
        #region Métodos y propiedades
        //el atributo ID es heredado de la clase abstracta
        private string? _Apellido;
        private string? _Nombre;
        private string? _Direccion;
        private string? _Sexo;
        private int? _Edad;
        public string? Apellido { get => _Apellido; set => _Apellido = value; }
        public string? Nombre { get => _Nombre; set => _Nombre = value; }
        public string? Direccion { get => _Direccion; set => _Direccion = value; }
        public string? Sexo { get => _Sexo; set => _Sexo = value; }
        public int? Edad { get => _Edad; set => _Edad = value; }
        #endregion
        #region Constructor
        public CLector(string IdLector, string apellido, string nombre, string direccion, string sexo, int edad)
        {
            Id = IdLector;
            Apellido = apellido;
            Nombre = nombre;
            Direccion = direccion;
            Sexo = sexo;
            Edad = edad;
        }
        public CLector() 
        {
            Id = null;
            Apellido = null;
            Nombre = null;
            Direccion = null;
            Sexo = null;
            Edad = null;
        }
        #endregion
        #region Metodos
        public override bool Equals(object Objeto)
        {
            if (base.Equals(Objeto))
            {
                // Retorna 'true' si coincide por ID
                return true;
            }
            else if (Objeto is CLector LectorAComparar)
            {
                // Retornará True si buscamos por nombre
                return LectorAComparar.Nombre.Contains(Nombre) || LectorAComparar.Apellido == Apellido;
            }
            else
            {
                return false;
            }
        }
        public override void Mostrar()
        {
            // Se añade el texto al Mostrar de la clase abstracta
            base.Mostrar();
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Direccion: " + Direccion);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Edad: {0}", Edad);
        }
        public override void Registrar()
        {
            // Se añaden los requerimientos al ya existente de la clase abstracta
            base.Registrar();
            Console.Write("Apellido: ");
            Apellido = Console.ReadLine();
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Direccion: ");
            Direccion = Console.ReadLine();
            Console.Write("Sexo: ");
            Sexo = Console.ReadLine();
            Console.WriteLine("Edad: ");
            Edad = Utilidades.ValidarEntero("Debe ser un número positivo", 0, int.MaxValue);
        }
        #endregion
    }
}