using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using System.Data.SqlClient;


namespace LibreryApp
{
    public class ComboBoxItem
    {
        public string Name { get; set; }

        public object Value { get; set; }



        public override string ToString()
        {
            return Name;
        }
        
    }

}
