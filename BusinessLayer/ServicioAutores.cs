using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace BusinessLayer
{
  public  class ServicioAutores
    {
        public ServicioAutores()
        {
        }

        public void AddA(Autores item)
        {
            Repositorio.Instancia.Autores.Add(item);
        }
        public void EditA(int Index, Autores Item)
        {
            Repositorio.Instancia.Autores[Index] = Item; ;
        }
        public void RemoveA(int Index)
        {
            Repositorio.Instancia.Autores.RemoveAt(Index);
        }
        public Autores GetbyIdA(int Index)
        {
            return Repositorio.Instancia.Autores[Index];
        }
    }
}
