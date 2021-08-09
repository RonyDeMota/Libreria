using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataBase.Modelos;
using System.Data;

namespace DataBase
{
   public class LibroRepositorio
    {
        private SqlConnection _connection;
        public LibroRepositorio(SqlConnection conecction)
        {
            _connection = conecction;
        }

        public bool AddL(Libros item)
        {

            SqlCommand command = new SqlCommand("insert into Libros(Nombre, añoDeP,IdAutor,IdEditoriales) values (@nombre, @añoDeP, @IdAutor,@IdEditoriales)", _connection);

            command.Parameters.AddWithValue("@Nombre", item.Nombre);
            command.Parameters.AddWithValue("@Correo", item.añoDeP);
            command.Parameters.AddWithValue("@Correo", item.IdAutor);
            command.Parameters.AddWithValue("@Correo", item.IdEditoriales);

            return ExecuteDML(command);


        }
        public bool EditL(Libros item)
        {
            SqlCommand command = new SqlCommand("update Libros set Nombre = @nombre, añoDeP = @añoDeP, IdAutor = @IdAutor, IdEditoriales = @IdEditoriales where id = @Id)", _connection);

            command.Parameters.AddWithValue("@Nombre", item.Nombre);
            command.Parameters.AddWithValue("@Correo", item.añoDeP);
            command.Parameters.AddWithValue("@Id", item.id);

            return ExecuteDML(command);
        }
        public bool DeleteL(int Id)
        {
            SqlCommand command = new SqlCommand("delete Libros where id = @Id)", _connection);

            command.Parameters.AddWithValue("@Id", Id);

            return ExecuteDML(command);
        }
        public Libros GetbyIdL(int Id)
        {
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand("Select id,Nombre,añoDeP,IdAutor,IdEditoriales from Libros where Id= @id", _connection);

                command.Parameters.AddWithValue("@Id", Id);

                SqlDataReader Reader = command.ExecuteReader();

                Libros data = new Libros();
                while (Reader.Read())
                {
                    data.id = Reader.IsDBNull(0) ? 0 : Reader.GetInt32(0);
                    data.Nombre = Reader.IsDBNull(1) ? "" : Reader.GetString(1);
                    data.añoDeP = Reader.IsDBNull(2) ? "" : Reader.GetString(2);
                    data.IdAutor = Reader.IsDBNull(2) ? 0 : Reader.GetInt32(3);
                    data.IdEditoriales = Reader.IsDBNull(2) ? 0 : Reader.GetInt32(4);


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
        public DataTable GetAllL()
        {
            SqlDataAdapter query = new SqlDataAdapter("select id  as Codigo, Nombre, añoDeP as añoDePublicacion,IdAutor as autor, IdEditoriales as Editoriales from Libros", _connection);
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
        public bool GetDependens(int id, bool eass)
        {
            try
            {
                if (eass == true)
                {
                    int eas = -1;
                    _connection.Open();
                    SqlCommand commands = new SqlCommand("Select IdAutor from Libros where IdAutor = @id", _connection);
                    commands.Parameters.AddWithValue("@id", id);
                    SqlDataReader readers = commands.ExecuteReader();
                    while (readers.Read())
                    {
                        eas = readers.IsDBNull(0) ? -1 : readers.GetInt32(0);
                    }
                    readers.Close();
                    readers.Dispose();
                    _connection.Close();
                    if (eas == id)
                    { return true; }
                    else { return false; }
                }
                else
                {
                    int eas = -1;
                    _connection.Open();
                    SqlCommand commands = new SqlCommand("Select IdEditoriales from Libros where IdEditoriales = @id", _connection);
                    commands.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader1 = commands.ExecuteReader();
                    while (reader1.Read())
                    {
                        eas = reader1.IsDBNull(0) ? -1 : reader1.GetInt32(0);
                    }
                    reader1.Close();
                    reader1.Dispose();
                    _connection.Close();
                    if (eas == id)
                    {return true;}
                    else { return false; }}
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
