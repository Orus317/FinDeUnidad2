namespace AppBiblioteca
{
    // TODO: CTesis (IdTesis, Titulo, Autor, Año, Area, Asesor)
    public class CTesis
    {
        private string _IdTesis;
        private string _Titulo;
        private string _Autor;
        private string _Anio;
        private string _Area;
        private string _Asesor;

        public CTesis(string idTesis, string titulo, string autor, string anio, string area, string asesor)
        {
            IdTesis = idTesis;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Area = area;
            Asesor = asesor;
        }

        public string IdTesis { get => _IdTesis; set => _IdTesis = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Autor { get => _Autor; set => _Autor = value; }
        public string Anio { get => _Anio; set => _Anio = value; }
        public string Area { get => _Area; set => _Area = value; }
        public string Asesor { get => _Asesor; set => _Asesor = value; }

        public void Mostrar(){
            Console.WriteLine("Identificador de tesis: " + IdTesis);
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año: " + Anio);
            Console.WriteLine("Anio:" + Area);
            Console.WriteLine("Area: " + Asesor);
        }
    }
}

