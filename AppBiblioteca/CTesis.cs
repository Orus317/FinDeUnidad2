﻿using ClasesGenerales;
namespace AppBiblioteca
{
    // TODO: CTesis (IdTesis, Titulo, Autor, Año, Area, Asesor)
    public class CTesis : CObjeto
    {
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

        public CTesis(string titulo, string autor, int anio, string area, string asesor)
        {
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Area = area;
            Asesor = asesor;
        }

        public CTesis()
        {
            Titulo = null;
            Autor = null; 
            Anio = null;
            Area = null;
            Asesor = null;
        }

        public override bool Equals(object Objeto)
        {
            if (base.Equals(Objeto))
            {
                // Retorna 'true' si coincide por ID
                return true;
            }
            else if (Objeto is CTesis TesisAComparar)
            {
                // Retornará True si buscamos por nombre
                return TesisAComparar.Titulo.Contains(Titulo) || TesisAComparar.Autor == Autor;
            }
            else
            {
                return false;
            }
        }

        public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año: " + Anio);
            Console.WriteLine("Area:" + Area);
            Console.WriteLine("Asesor: " + Asesor);
        }

        public override void Registrar(){
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
    }
}

