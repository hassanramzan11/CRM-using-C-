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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void passwordtxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void loginbtn_Click(object sender, EventArgs e)
		{
			string username = usernametxt.Text;
			string password = passwordtxt.Text;

			// You should replace the connection string with your actual database connection string
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM admin WHERE Username = @Username AND Password = @Password";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Username", username);
					command.Parameters.AddWithValue("@Password", password);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							MessageBox.Show("Login successful. Press Ok");
							// Successful login, open the main application form
							Selection slct= new Selection();
							slct.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Invalid username or password. Please try again.");
						}
					}
				}
			}
		}

		private void signupbtn_Click(object sender, EventArgs e)
		{
			// Open the signup form
			SignUp signupForm = new SignUp();
			signupForm.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
