using System;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;

namespace WindowsFormsUsu
{
    public class UserrManagement
    {
        // Class where queries to the DB are managed.
        public bool createTable(SqlConnection con)
        {
            //Userr table is created if it does not exist.
            try
            {
                con.Open();
                string query = @"
                        IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'USERR')
                        BEGIN
                            CREATE TABLE [dbo].[USERR](
                                [id] [int] IDENTITY(1,1) NOT NULL,
                                [username] [varchar](255) NOT NULL,
                                [password] [varchar](255) NOT NULL,
                                [age] [int] NOT NULL,
                                [country] [varchar](max) NOT NULL,
                                PRIMARY KEY CLUSTERED 
                                (
                                    [id] ASC
                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
                                CONSTRAINT [UK_USERNAME] UNIQUE NONCLUSTERED 
                                (
                                    [username] ASC
                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                            ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
                        END"
                ;

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating table: {ex.Message}");
                con.Close();
                return false;
            }

        }
        public void InsertUserr(SqlConnection con, Userr userr)
        {
            string query = "INSERT INTO Userr (Username, Password, Age, Country) VALUES (@Username, @Password, @Age, @Country)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", userr.Username);
                cmd.Parameters.AddWithValue("@Password", userr.Password);
                cmd.Parameters.AddWithValue("@Age", userr.Age);
                cmd.Parameters.AddWithValue("@Country", userr.Country);

                cmd.ExecuteNonQuery();
            }
        }
        public bool UpdateUserr(SqlConnection con, int? id, string value, string column)
        {
            try
            {
                string query = "UPDATE Userr SET " + column + " = @Value WHERE Id = " + id;
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@Value", value);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public Userr ObtainUserr(SqlConnection con, string username)
        {
            
            string query = "SELECT * FROM Userr WHERE Username = @Username";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Userr(
                            Convert.ToInt32(reader["Id"]),
                            reader["Username"].ToString(),
                            reader["Password"].ToString(),
                            Convert.ToInt32(reader["Age"]),
                            reader["Country"].ToString()
                        );
                    }
                }
            }
            return null;
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    stringBuilder.Append(hashedBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

    }
}
