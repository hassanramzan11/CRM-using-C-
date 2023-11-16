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
	public partial class Delete : Form
	{
		public Delete()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Get the product key and customer id from the TextBoxes
			int productKey = int.Parse(txtProductKey.Text);
			int customerId = int.Parse(txtCustomerID.Text);

			// Delete from the Products table
			DeleteProduct(productKey);

			// Delete from the Customers table
			DeleteCustomer(customerId);

			MessageBox.Show("Review deleted successfully.");

			Selection slect= new Selection();
			slect.Show();
			this.Hide();
		}

		private void DeleteProduct(int productKey)
		{
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "DELETE FROM Product WHERE [Product_Key] = @Product_Key";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Product_Key", productKey);
					command.ExecuteNonQuery();
				}
			}
		}

		private void DeleteCustomer(int customerId)
		{
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "DELETE FROM CustomerReviews WHERE [customerid] = @CustomerId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@CustomerId", customerId);
					command.ExecuteNonQuery();
				}
			}
		}

		private void Delete_Load(object sender, EventArgs e)
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
