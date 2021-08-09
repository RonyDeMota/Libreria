using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataBase.Modelos;
using System.Data;

namespace DataBase.Modelos
{
    public class LibreryRepositorio
    {
        private SqlConnection _connection;
        public LibreryRepositorio(SqlConnection conecction)
        {
            _connection = conecction;
        }

        public bool AddA(Autores item)
        {

            SqlCommand command = new SqlCommand("insert into Autores(Nombre, Correo) values (@nombre, @correo)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@correo", item.Correo);

            return ExecuteDML(command);


        }
        public bool EditA(Autores item)
        {
            SqlCommand command = new SqlCommand("update Autores set Nombre = @nombre, Correo = @correo where Id = @Id)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@Id", item.Id);

            return ExecuteDML(command);
        }
        public bool DeleteA(int Id)
        {
            SqlCommand command = new SqlCommand("delete Autores where Id = @Id)", _connection);

            command.Parameters.AddWithValue("@Id", Id);

            return ExecuteDML(command);
        }
        public Autores GetbyIdA(int Id)
        {
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand("Select Id,Nombre,Correo from Autores where Id= @id", _connection);

                command.Parameters.AddWithValue("@Id", Id);

                SqlDataReader Reader = command.ExecuteReader();

                Autores data = new Autores();
                while (Reader.Read())
                {
                    data.Id = Reader.IsDBNull(0) ? 0 : Reader.GetInt32(0);
                    data.Nombre = Reader.IsDBNull(1) ? "" : Reader.GetString(1);
                    data.Correo = Reader.IsDBNull(2) ? "" : Reader.GetString(2);
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
        public DataTable GetAllA()
        {
            SqlDataAdapter query = new SqlDataAdapter("select Id as Codigo, Nombre, Correo from Autores", _connection);
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
        public List<Autores> GetList()
        {
            try
            {
                List<Autores> list = new List<Autores>();

                _connection.Open();

                SqlCommand command = new SqlCommand("Select Id as ID, Name as Nombre, Mail as Correo from Autores order by Name", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Autores
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Correo = reader.IsDBNull(2) ? "" : reader.GetString(2)
                    });
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
