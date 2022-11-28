namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string? nombre;
        public string Nombre
        {
            get { return "Copia " + nombre;}
            set { nombre = value.ToUpper();}
        }

        public int AñodeCracion { get; set; }

        public string? pais { get; set; }
        public string? ciudad { get; set; }
        
        public TiposEscuela typeSchool { get; set; }
        
        // public Escuela (string nameInput, int yearInput)
        // {
        //     this.nombre = nameInput;
        //     this.AñodeCracion = yearInput;
        // }
        public Escuela (string nameInput, int yearInput) => (Nombre, AñodeCracion) = (nameInput, yearInput);
    }
}