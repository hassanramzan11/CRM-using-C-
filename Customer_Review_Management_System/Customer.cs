using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Customer_Review_Management_System
{
	public partial class Customer : Form
	{
		public Customer()
		{
			InitializeComponent();
		}

		private void submitbtn_Click(object sender, EventArgs e)
		{
			string customerId = txtCustomerid.Text;
			string customerName = txtCustomerName.Text;
			string phoneNo = txtCustomerPhoneNo.Text;
			string email = txtCustomerEmail.Text;
			string customerReview = txtCustomerReview.Text;

			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Adjust the table and column names as per your database schema
				string query = "INSERT INTO CustomerReviews (CustomerId, CustomerName, PhoneNo, Email, CustomerReview) VALUES (@CustomerId, @CustomerName, @PhoneNo, @Email, @CustomerReview)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@CustomerId", customerId);
					command.Parameters.AddWithValue("@CustomerName", customerName);
					command.Parameters.AddWithValue("@PhoneNo", phoneNo);
					command.Parameters.AddWithValue("@Email", email);
					command.Parameters.AddWithValue("@CustomerReview", customerReview);

					command.ExecuteNonQuery();

					Selection slct = new Selection();
					slct.Show();
					this.Hide();
				}
			}
		}

		private void Customer_Load(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Selection slect = new Selection();
			slect.Show();
			this.Hide();
		}
	}
}
