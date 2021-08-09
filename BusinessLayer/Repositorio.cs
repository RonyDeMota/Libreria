using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class Repositorio
    {
        public List<Autores> Autores { get; set; } = new List<Autores>();
        public List<Editorial> Editoriales { get; set; } = new List<Editorial>();
        public List<Libros> Libros { get; set; } = new List<Libros>();
        public static Repositorio Instancia { get; } = new Repositorio();
        private Repositorio() { }
    }
}
