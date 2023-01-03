namespace AppBiblioteca
{
    // TODO: CPrestamo (IdPrestamo, FechaPrestamo, IdTesis, IdLector)
    public class CPrestamo 
    {
        private string _IdPrestamo;
        private string _FechaPrestamo;
        private string _IdTesis;
        private string _IdLector;

        public CPrestamo(string idPrestamo, string fechaPrestamo, string idTesis, string idLector)
        {
            IdPrestamo = idPrestamo;
            FechaPrestamo = fechaPrestamo;
            IdTesis = idTesis;
            IdLector = idLector;
        }

        public string IdPrestamo { get => _IdPrestamo; set => _IdPrestamo = value; }
        public string FechaPrestamo { get => _FechaPrestamo; set => _FechaPrestamo = value; }
        public string IdTesis { get => _IdTesis; set => _IdTesis = value; }
        public string IdLector { get => _IdLector; set => _IdLector = value; }

        public void Mostrar(){
            Console.WriteLine("Identificador de préstamo: " + IdPrestamo);
            Console.WriteLine("Fecha: " + FechaPrestamo);
            Console.WriteLine("Tesis: " + IdTesis);
            Console.WriteLine("Lector: " + IdLector);
        }
    }
}

