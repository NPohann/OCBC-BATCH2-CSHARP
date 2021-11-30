using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }
        public EmployeeContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            return list;
        }

        public string InsertEmployee(string nama, string jeniskelamin, string alamat)
        {

            string result;

            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO employee (nama, jenis_kelamin, alamat) VALUES(@nama, @jeniskelamin, @alamat)", conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@jeniskelamin", jeniskelamin);
                cmd.Parameters.AddWithValue("@alamat", alamat);

                int exe = cmd.ExecuteNonQuery();

                if (exe == 1)
                   result = "Data Berhasil Ditambahkan!";
                else
                    result = "Data Gagal Ditambahkan!";
            }
            return result;
        }

        public string UpdateEmployee(int id, string nama, string jeniskelamin, string alamat)
        {
            string result;
            using(MySqlConnection conn = GetConnection())
            {
                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE employee SET nama = @nama, jenis_kelamin = @jeniskelamin, alamat = @alamat WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@jeniskelamin", jeniskelamin);
                cmd.Parameters.AddWithValue("@alamat", alamat);

                int exe = cmd.ExecuteNonQuery();

                if (exe == 1)
                    result = "Data Berhasil Diupdate!";
                else
                    result = "Data Gagal Diupdate!";
            }
            return result;
        }

        public string DeleteEmployee(int id)
        {
            string result;
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM employee WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                int exe = cmd.ExecuteNonQuery();

                if (exe == 1)
                    result = "Data Berhasil Dihapus!";
                else
                    result = "Data Gagal Dihapus!";
            }
            return result;
        }

    }
}
