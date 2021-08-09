using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
  public  class ServicioEdito
    {
   
        public ServicioEdito()
        {
        }

        public void AddE(Editorial item)
        {
           Repositorio.Instancia.Editoriales.Add(item);
        }
        public void EditE(int Index, Editorial Item)
        {
            Repositorio.Instancia.Editoriales[Index] = Item; ;
        }
        public void RemoveE(int Index)
        {
            Repositorio.Instancia.Editoriales.RemoveAt(Index);
        }
        public Editorial GetbyIdE(int Index)
        {
           return Repositorio.Instancia.Editoriales[Index];
        }
    }
}
