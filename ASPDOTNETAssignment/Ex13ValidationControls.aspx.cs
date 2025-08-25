using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SampleWbFormsApp
{
    public partial class Ex13ValidationControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string passwordHash = ComputeSha256Hash(txtPassword.Text.Trim());
            string connstring = ConfigurationManager.ConnectionStrings["FnfTrainingConnectionString1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string query = "INSERT INTO Register(Username,Passwod,Email,Age) VALUES (@Username,@Password,@Email,@Age)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username",txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password",passwordHash);
                    cmd.Parameters.AddWithValue ("@Email",txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@Age",Convert.ToInt32(txtAge.Text.Trim()));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    lblError.Text = "Registration successful!";
                }
            }
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }

        }

    }
}