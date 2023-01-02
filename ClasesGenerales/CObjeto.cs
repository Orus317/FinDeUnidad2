namespace ClasesGenerales
{
    // Acá van las clases: CObjeto, CListaObjetos (que debe funcionar con la lista recursiva)
    //public abstract class CObjeto
    public class CObjeto
    {
        #region  ATRIBUTOS 
        private string _Id;

        public string Id { get => _Id; set => _Id = value; }
        #endregion

        #region  CONSTRUCTORES
        public CObjeto()
        {
            Id = "";
        }
        public CObjeto(string pId)
        {
            Id = pId;
        }
        #endregion   

        #region MÉTODOS     
        // ================================================================
        public override string ToString()
        {
            return Id;
        }

        // ================================================================
        public override bool Equals(object Objeto)
        {
            return (Objeto.ToString() == ToString());
        }

        // ================================================================
        public virtual void Leer()
        {
            Console.Write("Identificador: ");
            Id = Console.ReadLine();
        }

        // ================================================================
        public virtual void Escribir()
        {
            Console.WriteLine(Id);
        }

        // ================================================================
        public virtual void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("DATOS DE OBJETO");
            Console.WriteLine("================");
            Console.WriteLine("Identificador: " + Id);
        }
        #endregion          
    }

}