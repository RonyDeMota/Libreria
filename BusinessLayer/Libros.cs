using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public class Libros
    {
        public string NameLibro { get; set; }
        public string Date { get; set; }
        public object Autor { get; set; }
        public object Editorial { get; set; }

        public Libros(string NameLibro, string Date, object Autor, object Editorial)
        {
            this.NameLibro = NameLibro;
            this.Date = Date;
            this.Autor = Autor;
            this.Editorial = Editorial;
        }
    }
}
