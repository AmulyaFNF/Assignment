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

namespace SampleWebFormsApp
{
    public partial class Ex14LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string passwordHash = ComputeSha256Hash(password);
            string connStr = ConfigurationManager.ConnectionStrings["FnfTrainingConnectionString1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM Register WHERE Username=@Username AND Passwod=@Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username",username);
                    cmd.Parameters.AddWithValue ("@Password",passwordHash);
                    conn.Open();
                    int count=Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count == 1)
                    {
                        lblMsg.Text = "Login Successful";
                        Response.Redirect("Ex15Register.aspx");
                    }
                    else
                    {
                        lblMsg.Text = "Invalid USername or password";
                    }
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