using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public class Autores
    {
        public string NameAutor { get; set; }

        public string Correo { get; set; }

        public Autores(string NameAutor, string Correo)
        {
            this.NameAutor = NameAutor;
            this.Correo = Correo;
        }
    }
}
