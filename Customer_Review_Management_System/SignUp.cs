using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Review_Management_System
{
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btn_signup_Click(object sender, EventArgs e)
		{
			string username = usernameTextBox.Text;
			string email = emailTextBox.Text;
			string phoneNumber = phonenoTextBox.Text;
			string password = passwordTextBox.Text;

			// You should replace the connection string with your actual database connection string
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "INSERT INTO admin (Username, Email, PhoneNumber, Password) VALUES (@Username, @Email, @PhoneNumber, @Password)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Username", username);
					command.Parameters.AddWithValue("@Email", email);
					command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
					command.Parameters.AddWithValue("@Password", password);

					command.ExecuteNonQuery();

					MessageBox.Show("Signup successful. You can now login.");

					// Close the signup form and show the login form
					Login loginForm = new Login();
					loginForm.Show();
					this.Close();
				}
			}
		}

		private void backbtn_Click(object sender, EventArgs e)
		{
			// Close the signup form and show the login form
			Login loginForm = new Login();
			loginForm.Show();
			this.Close();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void SignUp_Load(object sender, EventArgs e)
		{

		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}
