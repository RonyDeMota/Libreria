using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
    public class ServicioLibro
    {
        public ServicioLibro()
        {
        }

        public void AddL(Libros item)
        {
            Repositorio.Instancia.Libros.Add(item);
        }
        public void EditL(int Index, Libros Item)
        {
            Repositorio.Instancia.Libros[Index] = Item; ;
        }
        public void RemoveL(int Index)
        {
            Repositorio.Instancia.Libros.RemoveAt(Index);
        }
        public Libros GetbyIdL(int Index)
        {
            return Repositorio.Instancia.Libros[Index];
        }
    }
}
