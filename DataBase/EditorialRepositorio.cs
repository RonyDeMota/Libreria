using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataBase.Modelos;
using System.Data;

namespace DataBase
{
   public class EditorialRepositorio
    {
            private SqlConnection _connection;
            public EditorialRepositorio(SqlConnection conecction)
            {
                _connection = conecction;
            }

            public bool AddE(Editoriales item)
            {

                SqlCommand command = new SqlCommand("insert into Editoriales(NombreE, Telefono, Pais) values (@NombreE, @Telefono,@Pais)", _connection);

                command.Parameters.AddWithValue("@NombreE", item.NombreE);
                command.Parameters.AddWithValue("@Telefono", item.Telefono);
                command.Parameters.AddWithValue("@Pais", item.Pais);

                return ExecuteDML(command);


            }
            public bool EditE(Editoriales item)
            {
                SqlCommand command = new SqlCommand("update Editoriales set NombreE = @NombreE, Telefono = @Telefono, Pais = @Pais where id = @Id)", _connection);

            command.Parameters.AddWithValue("@Nombre", item.NombreE);
            command.Parameters.AddWithValue("@Telefono", item.Telefono);
            command.Parameters.AddWithValue("@Pais", item.Pais);

            return ExecuteDML(command);
            }
            public bool DeleteE(int Id)
            {
                SqlCommand command = new SqlCommand("delete Editoriales where id = @Id)", _connection);

                command.Parameters.AddWithValue("@Id", Id);

                return ExecuteDML(command);
            }
            public Editoriales GetbyIdE(int Id)
            {
                try
                {
                    _connection.Open();
                    SqlCommand command = new SqlCommand("Select id,NombreE,Telefono,Pais from Editoriales where id= @Id", _connection);

                    command.Parameters.AddWithValue("@Id", Id);

                    SqlDataReader Reader = command.ExecuteReader();

                Editoriales data = new Editoriales();
                    while (Reader.Read())
                    {
                        data.id = Reader.IsDBNull(0) ? 0 : Reader.GetInt32(0);
                        data.NombreE = Reader.IsDBNull(1) ? "" : Reader.GetString(1);
                        data.Telefono = Reader.IsDBNull(2) ? "" : Reader.GetString(2);
                        data.Pais = Reader.IsDBNull(2) ? "" : Reader.GetString(2);
                    }
                    Reader.Close();
                    Reader.Dispose();


                    _connection.Close();

                    return data;


                }
                catch (Exception)
                {

                    return null;
                }

            }
            public DataTable GetAllE()
            {
                SqlDataAdapter query = new SqlDataAdapter("select id as Codigo, NombreE as Nombre,Telefono,Pais  from Editoriales", _connection);
                return LoadData(query);
            }


            private DataTable LoadData(SqlDataAdapter query)
            {
                try
                {
                    DataTable data = new DataTable();
                    _connection.Open();

                    query.Fill(data);
                    _connection.Close();
                    return data;
                }
                catch (Exception)
                {

                    return null;
                }
            }
            private bool ExecuteDML(SqlCommand query)
            {
                try
                {
                    _connection.Open();
                    query.ExecuteNonQuery();
                    _connection.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        public List<Editoriales> GetList()
        {
            try
            {
                List<Editoriales> list = new List<Editoriales>();

                _connection.Open();

                SqlCommand command = new SqlCommand("Select id as ID, NombreE as Nombre, Telefono, Pais from Autores order by Name", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Editoriales
                    { id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        NombreE = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Pais = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Telefono = reader.IsDBNull(2) ? "" : reader.GetString(2)});
                }
                reader.Close();
                reader.Dispose();
                _connection.Close();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
