using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.DataAccessLayer.SqlClient
{
    public class SQLAdmin : AccountProvider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public override User GetUserByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId, Email, PasswordHash,Salt FROM Users WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = reader.GetInt32(0),
                            Email = reader.GetString(1),
                            PasswordHash = reader.GetString(2),
                            Salt=reader.GetString(3)
                        };
                    }
                }
            }
            return null;
        }
        public override bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            // Hash the entered password with the stored salt
            string enteredHash = HashPassword(enteredPassword, storedSalt);
            //    string enteredHash = HashPassword(enteredPassword, salt);

            // Compare the entered hash with the stored hash
            return enteredHash == storedHash;

        }

        public override string generatePwd(string password)
        {
            return HashPassword(password, GenerateSalt());
        }

        #region Internal method
        private static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes); // Store salt as Base64 string
        }
        private static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Combine the password and the salt
                string saltedPassword = password + salt;

                // Compute the hash
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));

                // Convert to hex string
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        #endregion
    }
}
