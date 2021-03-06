using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MovieApp.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }
        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> GetAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetString("releasedate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(int id)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            releasedate = reader.GetString("releasedate")

                        });
                    }
                }
            }
            return list;
        }

        public string InsertMovie(string name, string genre, string duration, DateTime releasedate)
        {
            string result;

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movie (name, genre, duration, releasedate) VALUES(@name, @genre, @duration, @releasedate)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@releasedate", releasedate);

                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    result = "Data berhasil Ditambahkan!";
                else
                    result = "Data gagal Ditambahkan!";
            }
            return result;
        }

        public string UpdateMovie(int id, string name, string genre, string duration, DateTime releasedate)
        {
            string result;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE movie SET name = @name, genre = @genre, duration = @duration, releasedate = @releasedate WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@releasedate", releasedate);

                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    result = "Data berhasil Diupdate!";
                else
                    result = "Data gagal Diupdate!";
            }
            return result;
        }

        public string DeleteMovie(int id)
        {
            string result;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movie WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                    result = "Data berhasil Dihapus!";
                else
                    result = "Data gagal Dihapus!";
            }
            return result;
        }
    }
}
