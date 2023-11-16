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
	public partial class Update : Form
	{
		public Update()
		{
			InitializeComponent();
		}

		private void txtProductKey_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Get the customer ID and new review from the TextBoxes
			int customerId = int.Parse(txtCustomerID.Text);
			string newReview = txtReview.Text;

			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "UPDATE CustomerReviews SET [CustomerReview] = @NewReview WHERE [customerid] = @CustomerId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@NewReview", newReview);
					command.Parameters.AddWithValue("@CustomerId", customerId);
					command.ExecuteNonQuery();
					MessageBox.Show("Review updated successfully.");
					 
					Selection slct=new Selection();
					slct.Show();
					this.Hide();
				}
			}
		}

		private void Update_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Selection slect = new Selection();
			slect.Show();
			this.Hide();
		}
	}
}
