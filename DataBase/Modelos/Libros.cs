using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Modelos
{
   public class Libros
    {
        public int id { get; set; }
     
             public string Nombre { get; set; }
        public string añoDeP { get; set; }
        public int IdAutor { get; set; }
        public int IdEditoriales { get; set; }

    }
}
