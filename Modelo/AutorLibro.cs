﻿namespace Store.MicroServices.Autor.api.Modelo
{
    public class AutorLibro
    {
        public int AutorLibroId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }  
        public ICollection<GradoAcademico> GradosAcademicos { get; set; }
        public string AutorLibroGuid { get; set; }
    }
}
