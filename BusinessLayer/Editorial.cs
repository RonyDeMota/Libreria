using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public class Editorial
    {
        public string NameEditorial { get; set; }

        public string Telefono { get; set; }
        public string Pais { get; set; }

        public Editorial(string NameEditorial, string Telefono, string Pais)
        {
            this.NameEditorial = NameEditorial;
            this.Telefono = Telefono;
            this.Pais = Pais;
        }
    }
}
