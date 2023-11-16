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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Customer_Review_Management_System
{
	public partial class Product : Form
	{
		public Product()
		{
			InitializeComponent();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Get product details from form controls
			string productkey = productIdTextBox.Text;
			string productName = productNameTextBox.Text;
			string productReference = productReferenceTextBox.Text;
			string productDescription = productDescriptionTextBox.Text;

			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"EAD Project DB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			using (SqlCommand command = new SqlCommand("INSERT INTO Product (Product_Key, Product_Name, Product_Reference, Product_Desc) VALUES (@Product_Key, @Product_Name, @Product_Reference, @Product_Desc)", connection))
			{
				command.Parameters.AddWithValue("@Product_Key", productkey);
				command.Parameters.AddWithValue("@Product_Name", productName);
				command.Parameters.AddWithValue("@Product_Reference", productReference);
				command.Parameters.AddWithValue("@Product_Desc", productDescription);


				command.ExecuteNonQuery();


				// Open CustomerDetailsForm
				Customer customerDetailsForm = new Customer();
				customerDetailsForm.Show();
				// Optionally, hide the current form
				this.Hide();
			}


		}

		private void productDescriptionTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void Product_Load(object sender, EventArgs e)
		{

		}
	}
}
